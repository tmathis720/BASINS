Imports MapWindow.Interfaces
Imports MapWinUtility
Imports atcUtility
Imports SwatObject

Module SWATAddHruTypeToEachSubbasinIfNeeded
    Private pDrive As String = "G:"
    Private pBaseFolder As String = pDrive & "\project\UMRB\baseline90"
    Private pSWATGDB As String = "c:\Program Files\SWAT 2005 Editor\Databases\SWAT2005.mdb"
    Private pInGDB As String = "baseline90.mdb"
    Private pOutGDB As String = "baseline90X.mdb"
    Private pLogsFolder As String
    Private pScenario As String = "AddHruAsNeeded"
    Private pCropToCreate As String = "CRP"

    Public Sub ScriptMain(ByRef aMapWin As IMapWin)
        ChDriveDir(pBaseFolder)
        Dim lLogFileName As String = Logger.FileName
        pLogsFolder = IO.Path.Combine(pBaseFolder, "logs")
        Logger.StartToFile(IO.Path.Combine(pLogsFolder, pScenario & ".log"), , , True)

        Dim lOutGDB As String = IO.Path.Combine(pBaseFolder, pOutGDB)
        If IO.File.Exists(lOutGDB) Then
            Logger.Dbg("DeleteExisting " & lOutGDB)
            IO.File.Delete(lOutGDB)
        End If
        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(lOutGDB))
        IO.File.Copy(IO.Path.Combine(pBaseFolder, pInGDB), lOutGDB)
        Logger.Dbg("Copied " & pOutGDB & " from " & pInGDB)

        Dim lHUC8ToSubBasin As New atcCollection
        Dim lHUC8TableToSubBasin As New atcTableDelimited
        With lHUC8TableToSubBasin
            .Delimiter = ","
            .NumHeaderRows = 0
            .OpenFile(IO.Path.Combine(pBaseFolder, "flowfig.csv"))
            For lRowIndex As Integer = 1 To .NumRecords
                lHUC8ToSubBasin.Add(.Value(7), .Value(5))
                .MoveNext()
            Next
            .Clear()
        End With
        Dim lHuc8Crp As New atcCollection
        Dim lHuc8CrpTable As New atcTableDelimited
        With lHuc8CrpTable
            .Delimiter = vbTab
            .NumHeaderRows = 0
            .OpenFile(IO.Path.Combine(pBaseFolder, "crp2005.txt"))
            For lRowIndex As Integer = 1 To .NumRecords
                Dim lHuc8 As String = .Value(1).ToString.PadLeft(8, "0")
                Dim lSubBasin As String = lHUC8ToSubBasin.ItemByKey(lHuc8)
                lHuc8Crp.Add(lSubBasin, .Value(2))
                'Logger.Dbg("Huc8 " & lHuc8 & " SubBasin " & lSubBasin & " CropAcres " & .Value(2))
                .MoveNext()
            Next
            .Clear()
        End With

        Logger.Dbg("InitializeSwatInput")
        Dim lSwatInput As New SwatInput(pSWATGDB, lOutGDB, pBaseFolder, pscenario)

        Dim lSubBasinTable As DataTable = lSwatInput.SubBsn.Table
        For Each lSubBasinRow As DataRow In lSubBasinTable.Rows
            Dim lSubBasinId As String = lSubBasinRow.Item(1).ToString
            Dim lWhereClause As String = "(subbasin=" & lSubBasinId & " AND landuse='" & pCropToCreate & "')"
            Dim lSubBasinHruTableCrp As DataTable = lSwatInput.QueryInputDB("SELECT * FROM hru WHERE " & lWhereClause & " ORDER BY HRU;")
            Dim lSubBasinHruCrpArea As Double = 0.0
            Dim lSubBasinArea As Double = lSubBasinRow.Item("SUB_KM")
            For Each lCrp As DataRow In lSubBasinHruTableCrp.Rows
                lSubBasinHruCrpArea += lSubBasinArea * lCrp.Item("HRU_FR")
            Next
            Dim lHuc8CrpNeed As Double = lHuc8Crp.ItemByKey(lSubBasinId) / 247.0 'acre -> km2
            If lSubBasinHruCrpArea >= lHuc8CrpNeed Then
                Logger.Dbg("SubBasin " & lSubBasinId & " has " & lSubBasinHruCrpArea & " km2 of " & pCropToCreate & " only need " & lHuc8CrpNeed)
            Else
                If lSubBasinHruTableCrp.Rows.Count = 0 Then
                    lWhereClause = "subbasin=" & lSubBasinId
                    Dim lSubBasinHruTable As DataTable = lSwatInput.QueryInputDB("SELECT * FROM hru WHERE " & lWhereClause & " ORDER BY hru_fr;")
                    Dim lChanged As Boolean = False
                    For Each lHruRow As DataRow In lSubBasinHruTable.Rows
                        Dim lHruLandUse As String = lHruRow.Item("LANDUSE")
                        Dim lHruSlope As String = lHruRow.Item("SLOPE_CD")
                        Dim lHruFraction As Double = lHruRow.Item("HRU_FR")
                        Dim lHruArea As Double = lHruFraction * lSubBasinArea
                        If lHruArea > lHuc8CrpNeed And Not lChanged Then
                            Logger.Dbg("SubBasin " & lSubBasinId & " HUCMinArea " & lHruArea & " too big, only need " & lHuc8CrpNeed)
                            lChanged = True 'dont need something else
                            Exit For
                        Else
                            If lHruLandUse = "AGRR" AndAlso _
                               lHruSlope = "4-9999" AndAlso _
                               lHruArea < lHuc8CrpNeed Then
                                lHuc8CrpNeed -= lHruArea
                                Logger.Dbg("SubBasin " & lSubBasinId & " Change " & lHruLandUse & " to " & pCropToCreate & " for " & lHruArea & " need " & lHuc8CrpNeed)
                                lChanged = True
                            End If
                        End If
                    Next
                    If Not lChanged Then
                        Logger.Dbg("Need to convert something else for " & lSubBasinId)
                    End If
                Else
                    Logger.Dbg("SubBasin " & lSubBasinId & " has " & lSubBasinHruTableCrp.Rows.Count & " HRUs of " & pCropToCreate _
                              & " (" & lSubBasinHruCrpArea & " km2, need " & lHuc8CrpNeed & ")")
                End If
            End If
        Next

        'back to basins log
        Logger.StartToFile(lLogFileName, True, False, True)
    End Sub
End Module
