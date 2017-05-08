Attribute VB_Name = "modGlobal"
Option Explicit
'Copyright 2000 by AQUA TERRA Consultants

'Public myMonitor As clsStatus
Public IPC As ATCoIPC

Public myUci As HspfUci
Public myMsg As HspfMsg
Public myMsgBox As ATCoMessage
Public reg As ATCoRegistry
Public defUci As HspfUci

Public PollutantList As Collection 'of strings

'declaration to execute html files
Declare Function ShellExecute Lib _
    "shell32.dll" Alias "ShellExecuteA" _
    (ByVal hwnd As Long, _
    ByVal lpOperation As String, _
    ByVal lpFile As String, _
    ByVal lpParameters As String, _
    ByVal lpDirectory As String, _
    ByVal nShowCmd As Long) As Long

Sub Main()
    
End Sub

'Public Sub CheckAndAddMissingTables(opname$)
'  Dim cTablesRequiredMissing As Collection 'of HspfStatusType
'  Dim lOpnBlk As HspfOpnBlk, lOper As HspfOperation, vOper As Variant
'  Dim vTableStatus As Variant
'  Dim lStatus As HspfStatusType
'  Dim tabname$
'
'  Set lOpnBlk = myUci.OpnBlks(opname)
'
'  For Each vOper In lOpnBlk.Ids
'    Set lOper = vOper  'setting the collection forces build of tablestatus
'    Set cTablesRequiredMissing = lOper.TableStatus.GetInfo(1, False)
'    lOper.TableStatus.Update 'need to update in case we just changed flags
'  Next vOper
'
'  For Each vOper In lOpnBlk.Ids
'    Set lOper = vOper
'    Set cTablesRequiredMissing = lOper.TableStatus.GetInfo(1, False)
'
'    For Each vTableStatus In cTablesRequiredMissing
'      Set lStatus = vTableStatus
'      If lStatus.Occur > 1 Then
'        tabname = lStatus.Name & ":" & lStatus.Occur
'      Else
'        tabname = lStatus.Name
'      End If
'      If lOpnBlk.Count > 0 Then
'        'double check to see if this table exists
'        If Not lOpnBlk.TableExists(tabname) Then
'          lOpnBlk.AddTableForAll tabname, opname
'          setDefaultsForTable myUci, defUci, opname, tabname
'        End If
'      End If
'    Next vTableStatus
'  Next vOper
'  For Each vOper In lOpnBlk.Ids
'    Set lOper = vOper
'    lOper.TableStatus.Update
'  Next vOper
'End Sub

Public Sub UpdateFlagDependencies(opname$)
  Dim lOpnBlk As HspfOpnBlk
  Dim lOper As HspfOperation, vOper As Variant

  Set lOpnBlk = myUci.OpnBlks(opname)
  For Each vOper In lOpnBlk.Ids
    Set lOper = vOper
    If lOper.TableExists("ACTIVITY") Then
      If lOper.Tables("ACTIVITY").Parms("SEDFG").Value = 1 Then
        If lOper.TableExists("HYDR-PARM1") Then
          'change aux flags
          lOper.Tables("HYDR-PARM1").Parms("AUX1FG").Value = 1
          lOper.Tables("HYDR-PARM1").Parms("AUX2FG").Value = 1
          lOper.Tables("HYDR-PARM1").Parms("AUX3FG").Value = 1
        End If
      End If
      If lOper.Tables("ACTIVITY").Parms("PLKFG").Value = 1 Then
        If lOper.TableExists("NUT-FLAGS") Then
          'change po4 flag
          lOper.Tables("NUT-FLAGS").Parms("PO4FG").Value = 1
        End If
      End If
    End If
  Next vOper
End Sub

Public Sub CheckAndAddMassLinks()
  Dim lOpnBlk As HspfOpnBlk
  Dim vId As Variant, lId As HspfOperation
  Dim pquals&, i&, iquals&, gquals&, nquals&, npest&
  Dim vML As Variant, lML As HspfMassLink, newML As HspfMassLink
  Dim vML2 As Variant, lML2 As HspfMassLink
  Dim ltable As HspfTable
  
  'find the number of quals to be in the masslink block
  
  'pquals, npest
  Set lOpnBlk = myUci.OpnBlks("PERLND")
  pquals = 0
  npest = 0
  For Each vId In lOpnBlk.Ids
    Set lId = vId
    If lId.TableExists("ACTIVITY") Then
      Set ltable = lId.Tables("ACTIVITY")
      If ltable.Parms("PQALFG") = 1 Then
        pquals = 1
      End If
      If ltable.Parms("PESTFG") = 1 Then
        npest = 1
      End If
    End If
    If lId.TableExists("NQUALS") Then
      i = lId.Tables("NQUALS").Parms("NQUAL")
      If i > pquals Then
        pquals = i
      End If
    End If
    If lId.TableExists("PEST-FLAGS") Then
      i = lId.Tables("PEST-FLAGS").Parms("NPST")
      If i > npest Then
        npest = i
      End If
    End If
  Next vId
  
  'iquals
  Set lOpnBlk = myUci.OpnBlks("IMPLND")
  iquals = 0
  For Each vId In lOpnBlk.Ids
    Set lId = vId
    If lId.TableExists("ACTIVITY") Then
      Set ltable = lId.Tables("ACTIVITY")
      If ltable.Parms("IQALFG") = 1 Then
        iquals = 1
      End If
    End If
    If lId.TableExists("NQUALS") Then
      i = lId.Tables("NQUALS").Parms("NQUAL")
      If i > iquals Then
        iquals = i
      End If
    End If
  Next vId
  Set lOpnBlk = myUci.OpnBlks("RCHRES")
  
  'gquals
  gquals = 0
  For Each vId In lOpnBlk.Ids
    Set lId = vId
    If lId.TableExists("ACTIVITY") Then
      Set ltable = lId.Tables("ACTIVITY")
      If ltable.Parms("GQALFG") = 1 Then
        gquals = 1
      End If
    End If
    If lId.TableExists("GQ-GENDATA") Then
      i = lId.Tables("GQ-GENDATA").Parms("NGQUAL")
      If i > gquals Then
        gquals = i
      End If
    End If
  Next vId
  
  If pquals > 1 And gquals > 1 Then
    If pquals >= gquals Then
      nquals = gquals
    Else
      nquals = pquals
    End If
    'make sure we have the masslinks for these p to r connections
    Call CopyMLsForAdditionalQuals("PERLND", "PQUAL", nquals)
  End If
  
  If iquals > 1 And gquals > 1 Then
    If iquals >= gquals Then
      nquals = gquals
    Else
      nquals = iquals
    End If
    'make sure we have the masslinks for these i to r connections
    Call CopyMLsForAdditionalQuals("IMPLND", "IQUAL", nquals)
  End If
  
  If npest > 1 And gquals > 1 Then
    If npest >= gquals Then
      nquals = gquals
    Else
      nquals = npest
    End If
    'make sure we have the masslinks for these p to r connections
    Call CopyMLsForAdditionalQuals("PERLND", "PEST", nquals)
  End If
  
End Sub

Private Sub CopyMLsForAdditionalQuals(opname$, opgroup$, nquals&)
  Dim vML As Variant, lML As HspfMassLink, newML As HspfMassLink
  Dim vML2 As Variant, lML2 As HspfMassLink, i&, found As Boolean
  'copy the masslinks for 1 pqual/iqual to all additional pqual/iquals
  
  For Each vML In myUci.MassLinks
    Set lML = vML
    If lML.Source.volname = opname And lML.Source.Group = opgroup And _
       lML.Target.volname = "RCHRES" Then
      If (lML.Source.memsub2 = 0 And lML.Source.memsub1 = 1) Or _
         lML.Source.memsub2 = 1 Then
        'need this record for each nqual
        For i = 2 To nquals
          found = False
          For Each vML2 In myUci.MassLinks 'see if we already have it
            Set lML2 = vML2
            If lML2.Source.volname = lML.Source.volname And _
               lML2.Source.Group = lML.Source.Group And _
               lML2.Source.member = lML.Source.member And _
               lML2.mfact = lML.mfact And _
               lML2.Target.volname = lML.Target.volname And _
               lML2.Target.Group = lML.Target.Group And _
               lML2.Target.member = lML.Target.member And _
               lML2.Source.memsub1 = i Then
              If lML.Target.memsub2 > 0 Then
                If lML2.Target.memsub1 = lML.Target.memsub1 And _
                  lML2.Target.memsub2 = i Then
                  found = True
                End If
              Else
                If lML2.Target.memsub1 = i Then
                  found = True
                End If
              End If
            End If
          Next vML2
          If found = False Then  'dont have it yet, so add it
            Set newML = New HspfMassLink
            newML.MassLinkID = lML.MassLinkID
            newML.mfact = lML.mfact
            newML.tran = lML.tran
            Set newML.Uci = lML.Uci
            newML.Source.volname = lML.Source.volname
            newML.Source.Group = lML.Source.Group
            newML.Source.member = lML.Source.member
            newML.Target.volname = lML.Target.volname
            newML.Target.Group = lML.Target.Group
            newML.Target.member = lML.Target.member
            newML.Target.memsub1 = lML.Target.memsub1
            newML.Source.memsub1 = i
            If lML.Target.memsub2 > 0 Then
              newML.Target.memsub2 = i
            Else
              newML.Target.memsub1 = i
            End If
            myUci.MassLinks.Add newML
          End If
        Next i
      End If
    End If
  Next vML
End Sub

Public Function AnyMissingTables(opname$)
  Dim cTablesRequiredMissing As Collection 'of HspfStatusType
  Dim lOpnBlk As HspfOpnBlk, lOper As HspfOperation, vOper As Variant
  Dim vTableStatus As Variant
  Dim lStatus As HspfStatusType
  Dim tabname$
  
  AnyMissingTables = False
  Set lOpnBlk = myUci.OpnBlks(opname)
  
  For Each vOper In lOpnBlk.Ids
    Set lOper = vOper  'setting the collection forces build of tablestatus
    Set cTablesRequiredMissing = lOper.TableStatus.GetInfo(1, False)
    lOper.TableStatus.Update 'need to update in case we just changed flags
  Next vOper
        
  For Each vOper In lOpnBlk.Ids
    Set lOper = vOper
    Set cTablesRequiredMissing = lOper.TableStatus.GetInfo(1, False)
    If cTablesRequiredMissing.Count > 0 Then
      AnyMissingTables = True
    End If
  Next vOper
  
End Function

Public Function WaitForChildMessage() As String
  Dim pipeBuffer$, s$, res&, ExitCode&

  Do 'process messages from parent
    'res = GetExitCodeProcess(myMonitor.Launch.hComputeProcess, ExitCode)
    'If ExitCode = &H103 Then 'front end STILL_ACTIVE
    '  s = ReadTokenFromPipe(myMonitor.Launch.ParentRead, pipeBuffer, False)
    'Else
    '  s = "Child has exited"
    'End If
    s = IPC.GetProcessMessage("HSPFUCI")
    If Len(s) > 3 Then
      Select Case LCase(Left(s, 3))
        Case "dbg", "msg"
          IPC.SendMonitorMessage s
          s = ""
      End Select
    End If
  Loop While Len(s) = 0
  WaitForChildMessage = s
  
End Function

Public Sub StartHSPFEngine()
  Dim M$
  
  With IPC
    .StartProcess "HSPFUCI", "hspfengine.exe " & GetCurrentProcessId
    .SendProcessMessage "HSPFUCI", "W99OPN"
    .SendProcessMessage "HSPFUCI", "WDBFIN"
    .SendProcessMessage "HSPFUCI", "PUTOLV 10"
    .SendProcessMessage "HSPFUCI", "SPIPH " & _
                        CStr(.hPipeReadFromParent("HSPFUCI")) & " " & _
                        CStr(.hPipeWriteToParent("HSPFUCI")) & " "
    .SendProcessMessage "HSPFUCI", "WDBOPN " & frmPestDriver.W_HSPFMSGWDM & " 1"
    M = WaitForChildMessage
    frmPestDriver.MessageUnit = Right(M, 3)
  End With
End Sub

'Public Sub DisableAll(onoff As Boolean)
'  If onoff = True Then
'    frmUCIUpdate.MousePointer = vbHourglass
'    frmUCIUpdate.Enabled = False
'  Else
'    frmUCIUpdate.MousePointer = vbNormal
'    frmUCIUpdate.Enabled = True
'  End If
'End Sub


