Imports atcUtility
Imports atcControls
Imports atcMwGisUtility
Imports MapWinUtility

Public Class frmReport
  Inherits System.Windows.Forms.Form

  Dim pPlugIn As atcReport.PlugIn

#Region " Windows Form Designer generated code "

  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()
  End Sub

  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cboSub1 As System.Windows.Forms.ComboBox
  Friend WithEvents cboSub2 As System.Windows.Forms.ComboBox
  Friend WithEvents cmdNext As System.Windows.Forms.Button
  Friend WithEvents cmdCancel As System.Windows.Forms.Button
  Friend WithEvents lblSubid As System.Windows.Forms.Label
  Friend WithEvents lblSubname As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lbxReports As System.Windows.Forms.ListBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblFolder As System.Windows.Forms.Label
  Friend WithEvents fbdFolder As System.Windows.Forms.FolderBrowserDialog
  Friend WithEvents cboAreas As System.Windows.Forms.ComboBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReport))
    Me.cboAreas = New System.Windows.Forms.ComboBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.cboSub1 = New System.Windows.Forms.ComboBox
    Me.lblSubid = New System.Windows.Forms.Label
    Me.lblSubname = New System.Windows.Forms.Label
    Me.cboSub2 = New System.Windows.Forms.ComboBox
    Me.cmdNext = New System.Windows.Forms.Button
    Me.cmdCancel = New System.Windows.Forms.Button
    Me.lbxReports = New System.Windows.Forms.ListBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.lblFolder = New System.Windows.Forms.Label
    Me.fbdFolder = New System.Windows.Forms.FolderBrowserDialog
    Me.SuspendLayout()
    '
    'cboAreas
    '
    Me.cboAreas.AllowDrop = True
    Me.cboAreas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAreas.Location = New System.Drawing.Point(192, 16)
    Me.cboAreas.Name = "cboAreas"
    Me.cboAreas.Size = New System.Drawing.Size(224, 25)
    Me.cboAreas.TabIndex = 12
    '
    'Label3
    '
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(16, 16)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(168, 25)
    Me.Label3.TabIndex = 10
    Me.Label3.Text = "Area of Interest Layer:"
    '
    'cboSub1
    '
    Me.cboSub1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboSub1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSub1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSub1.Location = New System.Drawing.Point(208, 48)
    Me.cboSub1.Name = "cboSub1"
    Me.cboSub1.Size = New System.Drawing.Size(208, 25)
    Me.cboSub1.TabIndex = 18
    '
    'lblSubid
    '
    Me.lblSubid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSubid.Location = New System.Drawing.Point(40, 48)
    Me.lblSubid.Name = "lblSubid"
    Me.lblSubid.Size = New System.Drawing.Size(152, 25)
    Me.lblSubid.TabIndex = 17
    Me.lblSubid.Text = "ID Field:"
    '
    'lblSubname
    '
    Me.lblSubname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSubname.Location = New System.Drawing.Point(40, 80)
    Me.lblSubname.Name = "lblSubname"
    Me.lblSubname.Size = New System.Drawing.Size(152, 25)
    Me.lblSubname.TabIndex = 21
    Me.lblSubname.Text = "Name Field:"
    '
    'cboSub2
    '
    Me.cboSub2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboSub2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSub2.Location = New System.Drawing.Point(208, 80)
    Me.cboSub2.Name = "cboSub2"
    Me.cboSub2.Size = New System.Drawing.Size(208, 25)
    Me.cboSub2.TabIndex = 22
    '
    'cmdNext
    '
    Me.cmdNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdNext.Location = New System.Drawing.Point(240, 392)
    Me.cmdNext.Name = "cmdNext"
    Me.cmdNext.Size = New System.Drawing.Size(88, 34)
    Me.cmdNext.TabIndex = 23
    Me.cmdNext.Text = "Generate"
    '
    'cmdCancel
    '
    Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdCancel.Location = New System.Drawing.Point(128, 392)
    Me.cmdCancel.Name = "cmdCancel"
    Me.cmdCancel.Size = New System.Drawing.Size(88, 34)
    Me.cmdCancel.TabIndex = 24
    Me.cmdCancel.Text = "Close"
    '
    'lbxReports
    '
    Me.lbxReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lbxReports.ItemHeight = 17
    Me.lbxReports.Location = New System.Drawing.Point(40, 144)
    Me.lbxReports.Name = "lbxReports"
    Me.lbxReports.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
    Me.lbxReports.Size = New System.Drawing.Size(384, 191)
    Me.lbxReports.TabIndex = 25
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(16, 120)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(200, 24)
    Me.Label1.TabIndex = 26
    Me.Label1.Text = "Available Reports:"
    '
    'Label2
    '
    Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label2.Location = New System.Drawing.Point(16, 352)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(112, 24)
    Me.Label2.TabIndex = 27
    Me.Label2.Text = "Report Folder:"
    '
    'lblFolder
    '
    Me.lblFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblFolder.Location = New System.Drawing.Point(128, 352)
    Me.lblFolder.Name = "lblFolder"
    Me.lblFolder.Size = New System.Drawing.Size(296, 24)
    Me.lblFolder.TabIndex = 28
    Me.lblFolder.Text = "C:\BASINS\reports\"
    '
    'frmReport
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
    Me.ClientSize = New System.Drawing.Size(464, 448)
    Me.Controls.Add(Me.lblFolder)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lbxReports)
    Me.Controls.Add(Me.cmdCancel)
    Me.Controls.Add(Me.cmdNext)
    Me.Controls.Add(Me.cboSub2)
    Me.Controls.Add(Me.lblSubname)
    Me.Controls.Add(Me.cboSub1)
    Me.Controls.Add(Me.lblSubid)
    Me.Controls.Add(Me.cboAreas)
    Me.Controls.Add(Me.Label3)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmReport"
    Me.Text = "BASINS Watershed Characterization Reports"
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
    Me.Close()
  End Sub

  Private Sub cboSubbasins_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAreas.SelectedIndexChanged
    Dim lLayer As Long
    Dim i As Long
    Dim lString As String

    cboSub1.Items.Clear()
    cboSub2.Items.Clear()
    If cboAreas.Items(cboAreas.SelectedIndex) = "<none>" Then
      cboSub1.Visible = False
      cboSub2.Visible = False
      lblSubid.Visible = False
      lblSubname.Visible = False
    Else
      cboSub1.Visible = True
      cboSub2.Visible = True
      lblSubid.Visible = True
      lblSubname.Visible = True
      lLayer = GisUtil.LayerIndex(cboAreas.Items(cboAreas.SelectedIndex))
      If lLayer > -1 Then
        For i = 0 To GisUtil.NumFields(lLayer) - 1
          lString = GisUtil.FieldName(i, lLayer)
          cboSub1.Items.Add(lString)
          cboSub2.Items.Add(lString)
          If UCase(lString) = "SUBBASIN" Or UCase(lString) = "CU" Then
            cboSub1.SelectedIndex = i
          End If
          If UCase(lString) = "NAME" Or UCase(lString) = "BNAME" Then
            cboSub2.SelectedIndex = i
          End If
        Next
      End If
      If cboSub1.Items.Count > 0 And cboSub1.SelectedIndex < 0 Then
        cboSub1.SelectedIndex = 0
      End If
      If cboSub2.Items.Count > 0 And cboSub2.SelectedIndex < 0 Then
        cboSub2.SelectedIndex = 0
      End If
    End If
  End Sub

  Private Sub cmdNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNext.Click
    Dim lAreaLayerName As String
    Dim lAreaIDFieldName As String
    Dim lAreaNameFieldName As String

    If lbxReports.SelectedItems.Count = 0 Then
      Logger.Msg("At least one report must be selected to generate.", MsgBoxStyle.OKOnly, "BASINS Report Problem")
    Else 'set arguments for scripting
      If cboAreas.SelectedIndex > -1 Then
        lAreaLayerName = cboAreas.Items(cboAreas.SelectedIndex)
      Else
        lAreaLayerName = "<none>"
      End If
      If cboSub1.SelectedIndex > -1 Then
        lAreaIDFieldName = cboSub1.Items(cboSub1.SelectedIndex)
      Else
        lAreaIDFieldName = ""
      End If
      If cboSub2.SelectedIndex > -1 Then
        lAreaNameFieldName = cboSub2.Items(cboSub2.SelectedIndex)
      Else
        lAreaNameFieldName = ""
      End If

      'make sure output folder exists
      If Not FileExists(lblFolder.Text, True, False) Then
        MkDirPath(lblFolder.Text)
      End If

      'now run each script
      For i As Integer = 0 To lbxReports.SelectedItems.Count - 1
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim lOutput As Object
        Dim lProblem As String = ""
        Dim lOutputGridSource As New atcGridSource
        lOutput = pPlugIn.BuildReport(lAreaLayerName, _
                                      lAreaIDFieldName, _
                                      lAreaNameFieldName, _
                                      lbxReports.SelectedIndices(i) + 1)
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Try
          lOutputGridSource = lOutput
        Catch
          lProblem = lOutput
        End Try
        Dim lTitle1 As String = "Watershed Characterization Report"
        Dim lTitle2 As String = FilenameOnly(pPlugIn.Reports(lbxReports.SelectedIndices(i) + 1))
        If Not lOutputGridSource Is Nothing And Len(lProblem) = 0 Then
          'write file
          SaveFileString(lblFolder.Text & lTitle2 & ".out", _
             lTitle1 & vbCrLf & "  " & lTitle2 & vbCrLf & vbCrLf & lOutputGridSource.ToString)

          'form showing output
          Dim lfrmResult As New frmResult
          lfrmResult.InitializeResults(lTitle1, lTitle2, lOutputGridSource)
          lfrmResult.Show()
        Else
          Logger.Msg("atcReport:" & lTitle2 & vbCrLf & lProblem, "BASINS Report Problem")
        End If
      Next i

    End If

  End Sub

  Public Sub InitializeUI(ByVal aPlugIn As Object)
    pPlugIn = aPlugIn
    cboAreas.Items.Add("<none>")

    For lLayer As Long = 0 To GisUtil.NumLayers() - 1
      Dim lString As String = GisUtil.LayerName(lLayer)
      If GisUtil.LayerType(lLayer) = 3 Then
        'PolygonShapefile 
        cboAreas.Items.Add(lString)
        If GisUtil.CurrentLayer = lLayer Then
          cboAreas.SelectedIndex = cboAreas.Items.Count - 1
        End If
        If UCase(lString) = "SUBBASINS" And cboAreas.SelectedIndex < 0 Then
          cboAreas.SelectedIndex = cboAreas.Items.Count - 1
        End If
        If UCase(lString) = "CATALOGING UNIT BOUNDARIES" And cboAreas.SelectedIndex < 0 Then
          cboAreas.SelectedIndex = cboAreas.Items.Count - 1
        End If
      End If
    Next
    If cboAreas.Items.Count > 0 And cboAreas.SelectedIndex < 0 Then
      cboAreas.SelectedIndex = 0
    End If

    For Each lReport As String In pPlugIn.Reports
      lbxReports.Items.Add(FilenameOnly(lReport))
    Next lReport

  End Sub

  Private Sub lblFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFolder.Click
    fbdFolder.ShowDialog()
    lblFolder.Text = fbdFolder.SelectedPath
  End Sub
End Class
