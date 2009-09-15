﻿Imports atcUCI
Imports atcUtility
Imports MapWinUtility

''' <summary>
''' updates HSPF PERLND parameter tables with values extracted from an ATC standard spreadsheet of parameter values.
''' </summary>
''' <remarks></remarks>
Module modHSPFTableBuilder
    Private g_Project As String = "WILL"
    Private g_BaseFolder As String
    Private g_LandSurfaceSegmentRepeat As Integer = 25 'TODO: hardcoded for TT_GCRP - make generic
    Private pUci As HspfUci
    Private pDefUci As HspfUci

    Sub Initialize()
        Select Case g_Project
            Case "WILL"
                g_BaseFolder = "c:\Projects\TT_GCRP\ProjectsTT\Willamette\"
        End Select
    End Sub

    Sub main()
        Initialize()
        My.Computer.FileSystem.CurrentDirectory = g_BaseFolder
        Logger.StartToFile("parms\HSPFTableBuilderLog.txt", , False)

        Dim lPrmUpdTable As New atcTableDelimited
        lPrmUpdTable.Delimiter = vbTab
        lPrmUpdTable.OpenFile("parms\parms.txt")

        Dim lSlpRecTable As New atcTableDelimited
        lSlpRecTable.Delimiter = vbTab
        lSlpRecTable.OpenFile("parms\HruSummarizeSubBasin.txt")

        Dim lMsg As New HspfMsg("hspfmsg.mdb")
        pUci = New HspfUci
        pDefUci = New HspfUci

        Try
            pUci.FastReadUciForStarter(lMsg, "parms\" & g_Project & ".uci")
            Dim lError As String = pUci.ErrorDescription
            If lError.Length > 0 Then
                Logger.Dbg("UciReadError " & lError)
                Exit Sub
            End If
            Logger.Dbg("UCI " & pUci.Name & " Opened")
            pDefUci.FastReadUciForStarter(lMsg, "parms\starter.uci")
            lError = pDefUci.ErrorDescription
            If lError.Length > 0 Then
                Logger.Dbg("StarterUciReadError " & lError)
                Exit Sub
            End If

            Dim lOperationNames() As String = {"PERLND", "IMPLND", "RCHRES"}
            For Each lOperationName As String In lOperationNames
                Dim lOpnBlkStarter As HspfOpnBlk = pDefUci.OpnBlks(lOperationName)
                Dim lOpnBlk As HspfOpnBlk = pUci.OpnBlks(lOperationName)
                For Each lTable As HspfTable In lOpnBlkStarter.Tables
                    Dim lTableName As String = lTable.Name
                    If lTable.OccurNum > 1 Then
                        lTableName &= ":" & lTable.OccurNum
                    End If
                    If Not lOpnBlk.TableExists(lTableName) Then
                        lOpnBlk.AddTableForAll(lTableName, lOperationName, lTable.OccurIndex)
                    End If
                    SetDefaultsForTable(pUci, pDefUci, lOperationName, lTableName, False)
                Next
            Next
            pUci.Name = pUci.Name.ToUpper.Replace(g_Project, g_Project.ToLower & "Rev1")
            pUci.Save()

            Dim lSlpRecFieldNumber() As Integer = {2, 3}
            Dim lSlpRecFieldOperation() As String = {"=", "="}
            Dim lSlpRecFieldValue(1) As String
            Dim lPrmUpdFieldNumber() As Integer = {1, 4, 5}
            Dim lPrmUpdFieldOperation() As String = {"=", "=", "="}
            Dim lPrmUpdFieldValue(2) As String
            For Each lOperationName As String In lOperationNames
                For Each lOperation As atcUCI.HspfOperation In pUci.OpnSeqBlock.Opns
                    Dim lMetSegmentComment As String = lOperation.MetSeg.Comment
                    Dim lMetSegmentName As String = lMetSegmentComment.Substring(lMetSegmentComment.Length - 8)
                    Dim lLandUseName As String = lOperation.Tables("GEN-INFO").Parms(0).Value
                    Dim lSlopeReclassValue As Integer = 1
                    lSlpRecFieldValue(0) = lMetSegmentName
                    lSlpRecFieldValue(1) = lLandUseName
                    If lSlpRecTable.FindMatch(lSlpRecFieldNumber, lSlpRecFieldOperation, lSlpRecFieldValue) Then
                        lSlopeReclassValue = lSlpRecTable.Value(4)
                        'Logger.Dbg("Met,LU,SlopeReclass:" & lMetSegmentName & ":" & lLandUseName & ":" & lSlopeReclassValue)
                        lPrmUpdFieldValue(0) = lOperationName
                        lPrmUpdFieldValue(1) = lLandUseName
                        lPrmUpdFieldValue(2) = lSlopeReclassValue
                        Dim lRecordStart As Integer = 1
                        Dim lRecordsFound As Integer = 0
                        While lPrmUpdTable.FindMatch(lPrmUpdFieldNumber, lPrmUpdFieldOperation, lPrmUpdFieldValue, , lRecordStart)
                            lRecordsFound += 1
                            Dim lTableName As String = lPrmUpdTable.Value(1)
                            Dim lParmName As String = lPrmUpdTable.Value(2)
                            Dim lParmValue As String = lPrmUpdTable.Value(5)
                            lRecordStart = lPrmUpdTable.CurrentRecord + 1
                            For Each lTable As HspfTable In lOperation.Tables
                                If lTable.Name = lTableName Then
                                    For Each lParm As HspfParm In lTable.Parms
                                        If lParmName = lParm.Name Then
                                            'Logger.Dbg("Update:" & lTableName & ":" & lParmName & ":" & lParm.Value & ":" & lParmValue)
                                            lParm.Value = lParmValue
                                            Exit For
                                        End If
                                    Next
                                    Exit For
                                End If
                            Next
                        End While
                        If lRecordsFound = 0 Then
                            Logger.Dbg("NoParmUpdatesFor " & lMetSegmentName & ":" & lLandUseName)
                        End If
                    Else
                        Logger.Dbg("NoSlopeReclassFor " & lMetSegmentName & ":" & lLandUseName)
                    End If
                Next lOperation
            Next
            pUci.Name = pUci.Name.ToUpper.Replace("REV1", "Rev")
            pUci.Save()
        Catch lEx As Exception
            Logger.Dbg("Error " & lEx.ToString)
        End Try

    End Sub

    '
    'TODO: remaining code from WinHSPF - modWinHSPF - need to refactor both and move to atcUCI
    '
    Public Sub SetDefaultsForTable(ByVal aUCI As HspfUci, ByVal aDefUCI As HspfUci, ByVal aOpName As String, ByVal TableName As String, Optional ByVal aWinHspf As Boolean = False)
        If aUCI.OpnBlks(aOpName).Count > 0 Then
            Dim lOptyp As HspfOpnBlk = aUCI.OpnBlks(aOpName)
            For Each lOpn As HspfOperation In lOptyp.Ids
                Dim lId As Integer = DefaultOpnId(lOpn, aDefUCI)
                If lId > 0 Then
                    Dim lDOpn As HspfOperation = aDefUCI.OpnBlks(lOpn.Name).OperFromID(lId)
                    If Not lDOpn Is Nothing Then
                        If lOpn.TableExists(TableName) Then
                            Dim lTab As HspfTable = lOpn.Tables(TableName)
                            If DefaultThisTable(lOptyp.Name, lTab.Name, aWinHspf) Then
                                If lDOpn.TableExists(TableName) Then
                                    Dim lDTab As HspfTable = lDOpn.Tables(TableName)
                                    For Each lPar As HspfParm In lTab.Parms
                                        If DefaultThisParameter(lOptyp.Name, TableName, lPar.Name, aWinHspf) Then
                                            If lPar.Value <> lPar.Name Then
                                                lPar.Value = lDTab.Parms(lPar.Name).Value
                                            End If
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Public Function DefaultOpnId(ByVal aOpn As HspfOperation, ByVal aDefUCI As HspfUci) As Long

        If aOpn.DefOpnId <> 0 Then
            DefaultOpnId = aOpn.DefOpnId
        Else
            Dim lDOpn As HspfOperation = matchOperWithDefault(aOpn.Name, aOpn.Description, aDefUCI)
            If lDOpn Is Nothing Then
                DefaultOpnId = 0
            Else
                DefaultOpnId = lDOpn.Id
            End If
        End If

    End Function

    Private Function DefaultThisTable(ByVal aOperName As String, ByVal aTableName As String, Optional ByVal aWinHSPF As Boolean = True) As Boolean
        If aOperName = "PERLND" Or aOperName = "IMPLND" Then
            If (aWinHSPF AndAlso aTableName = "ACTIVITY") Or _
               aTableName = "PRINT-INFO" Or _
               aTableName = "GEN-INFO" Or _
               aTableName = "PWAT-PARM5" Then
                DefaultThisTable = False
            ElseIf aWinHSPF AndAlso aTableName.StartsWith("QUAL") Then
                DefaultThisTable = False
            Else
                DefaultThisTable = True
            End If
        ElseIf aOperName = "RCHRES" Then
            If (aWinHSPF AndAlso aTableName = "ACTIVITY") Or _
               aTableName = "PRINT-INFO" Or _
               aTableName = "GEN-INFO" Or _
               aTableName = "HYDR-PARM1" Then
                DefaultThisTable = False
            ElseIf aWinHSPF AndAlso aTableName.StartsWith("GQ-") Then
                DefaultThisTable = False
            Else
                DefaultThisTable = True
            End If
        Else
            DefaultThisTable = False
        End If
    End Function

    Private Function DefaultThisParameter(ByVal aOperName As String, ByVal aTableName As String, ByVal aParmName As String, Optional ByVal aWinHSPF As Boolean = True) As Boolean
        DefaultThisParameter = True
        If aOperName = "PERLND" Then
            If aTableName = "PWAT-PARM2" Then
                If aParmName = "SLSUR" Or aParmName = "LSUR" Then
                    DefaultThisParameter = False
                End If
            ElseIf aWinHSPF AndAlso aTableName = "NQUALS" Then
                If aParmName = "NQUAL" Then
                    DefaultThisParameter = False
                End If
            End If
        ElseIf aOperName = "IMPLND" Then
            If aTableName = "IWAT-PARM2" Then
                If aParmName = "SLSUR" Or aParmName = "LSUR" Then
                    DefaultThisParameter = False
                End If
            ElseIf aWinHSPF AndAlso aTableName = "NQUALS" Then
                If aParmName = "NQUAL" Then
                    DefaultThisParameter = False
                End If
            End If
        ElseIf aOperName = "RCHRES" Then
            If aTableName = "HYDR-PARM2" Then
                If aParmName = "LEN" Or _
                   aParmName = "DELTH" Or _
                   aParmName = "FTBUCI" Then
                    DefaultThisParameter = False
                End If
            ElseIf aWinHSPF AndAlso aTableName = "GQ-GENDATA" Then
                If aParmName = "NGQUAL" Then
                    DefaultThisParameter = False
                End If
            End If
        End If
    End Function

    Public Function matchOperWithDefault(ByVal aOpTypName As String, ByVal aOpnDesc As String, ByVal aDefUCI As HspfUci) As HspfOperation

        For Each lOpn As HspfOperation In aDefUCI.OpnBlks(aOpTypName).Ids
            If lOpn.Description = aOpnDesc Then
                matchOperWithDefault = lOpn
                Exit Function
            End If
        Next
        'a complete match not found, look for partial
        Dim lTempString As String
        For Each lOpn As HspfOperation In aDefUCI.OpnBlks(aOpTypName).Ids
            If Len(lOpn.Description) > Len(aOpnDesc) Then
                lTempString = Microsoft.VisualBasic.Left(lOpn.Description, Len(aOpnDesc))
                If lTempString = aOpnDesc Then
                    matchOperWithDefault = lOpn
                    Exit Function
                End If
            ElseIf Len(lOpn.Description) < Len(aOpnDesc) Then
                lTempString = Microsoft.VisualBasic.Left(aOpnDesc, Len(lOpn.Description))
                If lOpn.Description = lTempString Then
                    matchOperWithDefault = lOpn
                    Exit Function
                End If
            End If
            If Len(aOpnDesc) > 4 And Len(lOpn.Description) > 4 Then
                lTempString = Microsoft.VisualBasic.Left(aOpnDesc, 4)
                If Microsoft.VisualBasic.Left(lOpn.Description, 4) = lTempString Then
                    matchOperWithDefault = lOpn
                    Exit Function
                End If
            End If
        Next
        'not found, use first one
        If aDefUCI.OpnBlks(aOpTypName).Count > 0 Then
            matchOperWithDefault = aDefUCI.OpnBlks(aOpTypName).Ids(0)
        Else
            matchOperWithDefault = Nothing
        End If
    End Function
End Module
