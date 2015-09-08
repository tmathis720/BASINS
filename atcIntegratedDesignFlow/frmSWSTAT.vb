Imports atcData
Imports atcUtility
Imports MapWinUtility
Imports System.Windows.Forms

Public Class frmSWSTAT
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        InitializeComponent() 'required by Windows Form Designer
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuAnalysis As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSelectData As System.Windows.Forms.MenuItem
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabSelectDates As System.Windows.Forms.TabPage
    Friend WithEvents tabNDay As System.Windows.Forms.TabPage
    Friend WithEvents grpDates As System.Windows.Forms.GroupBox
    Friend WithEvents cboStartMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblYearStart As System.Windows.Forms.Label
    Friend WithEvents txtEndDay As System.Windows.Forms.TextBox
    Friend WithEvents txtStartDay As System.Windows.Forms.TextBox
    Friend WithEvents cboEndMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblYearEnd As System.Windows.Forms.Label
    Friend WithEvents grpYears As System.Windows.Forms.GroupBox
    Friend WithEvents lblDataStart As System.Windows.Forms.Label
    Friend WithEvents lblDataEnd As System.Windows.Forms.Label
    Friend WithEvents lblOmitBefore As System.Windows.Forms.Label
    Friend WithEvents lblOmitAfter As System.Windows.Forms.Label
    Friend WithEvents txtOmitAfterYear As System.Windows.Forms.TextBox
    Friend WithEvents txtOmitBeforeYear As System.Windows.Forms.TextBox
    Friend WithEvents cboYears As System.Windows.Forms.ComboBox
    Friend WithEvents btnNDay As System.Windows.Forms.Button
    Friend WithEvents btnDisplayTrend As System.Windows.Forms.Button
    Friend WithEvents btnDisplayBasic As System.Windows.Forms.Button
    Friend WithEvents btnDoFrequencyGrid As System.Windows.Forms.Button
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents grpRecurrence As System.Windows.Forms.GroupBox
    Friend WithEvents btnRecurrenceDefault As System.Windows.Forms.Button
    Friend WithEvents btnRecurrenceRemove As System.Windows.Forms.Button
    Friend WithEvents lstRecurrence As System.Windows.Forms.ListBox
    Friend WithEvents btnRecurrenceAdd As System.Windows.Forms.Button
    Friend WithEvents txtRecurrenceAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnRecurrenceNone As System.Windows.Forms.Button
    Friend WithEvents btnRecurrenceAll As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents grpNday As System.Windows.Forms.GroupBox
    Friend WithEvents btnNdayDefault As System.Windows.Forms.Button
    Friend WithEvents btnNdayRemove As System.Windows.Forms.Button
    Friend WithEvents btnNdayAdd As System.Windows.Forms.Button
    Friend WithEvents txtNdayAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnNdayNone As System.Windows.Forms.Button
    Friend WithEvents btnNdayAll As System.Windows.Forms.Button
    Friend WithEvents lstNday As System.Windows.Forms.ListBox
    Friend WithEvents chkLog As System.Windows.Forms.CheckBox
    Friend WithEvents grpHighLow As System.Windows.Forms.GroupBox
    Friend WithEvents radioHigh As System.Windows.Forms.RadioButton
    Friend WithEvents radioLow As System.Windows.Forms.RadioButton
    Friend WithEvents btnDoFrequencyGraph As System.Windows.Forms.Button
    Friend WithEvents chkMultipleStationPlots As System.Windows.Forms.CheckBox
    Friend WithEvents chkMultipleNDayPlots As System.Windows.Forms.CheckBox
    Friend WithEvents gbTextOutput As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutputDir As System.Windows.Forms.TextBox
    Friend WithEvents lblOutputDir As System.Windows.Forms.Label
    Friend WithEvents txtOutputRootName As System.Windows.Forms.TextBox
    Friend WithEvents lblBaseFilename As System.Windows.Forms.Label
    Friend WithEvents tabDFLOW As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbNonBio3 As System.Windows.Forms.TextBox
    Friend WithEvents tbNonBio4 As System.Windows.Forms.TextBox
    Friend WithEvents tbNonBio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbNonBio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbNonBio3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbNonBio2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbNonBio1 As System.Windows.Forms.RadioButton
    Friend WithEvents gbBio As System.Windows.Forms.GroupBox
    Friend WithEvents tbBio3 As System.Windows.Forms.TextBox
    Friend WithEvents tbBio4 As System.Windows.Forms.TextBox
    Friend WithEvents tbBio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbBio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbBio3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbBio2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbBio1 As System.Windows.Forms.RadioButton
    Friend WithEvents ckbBio As System.Windows.Forms.CheckBox
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSWSTAT))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFileSelectData = New System.Windows.Forms.MenuItem
        Me.mnuAnalysis = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.tabMain = New System.Windows.Forms.TabControl
        Me.tabSelectDates = New System.Windows.Forms.TabPage
        Me.gbTextOutput = New System.Windows.Forms.GroupBox
        Me.txtOutputDir = New System.Windows.Forms.TextBox
        Me.lblOutputDir = New System.Windows.Forms.Label
        Me.txtOutputRootName = New System.Windows.Forms.TextBox
        Me.lblBaseFilename = New System.Windows.Forms.Label
        Me.grpHighLow = New System.Windows.Forms.GroupBox
        Me.radioHigh = New System.Windows.Forms.RadioButton
        Me.radioLow = New System.Windows.Forms.RadioButton
        Me.btnDisplayBasic = New System.Windows.Forms.Button
        Me.grpDates = New System.Windows.Forms.GroupBox
        Me.cboStartMonth = New System.Windows.Forms.ComboBox
        Me.lblYearStart = New System.Windows.Forms.Label
        Me.txtEndDay = New System.Windows.Forms.TextBox
        Me.txtStartDay = New System.Windows.Forms.TextBox
        Me.cboEndMonth = New System.Windows.Forms.ComboBox
        Me.lblYearEnd = New System.Windows.Forms.Label
        Me.grpYears = New System.Windows.Forms.GroupBox
        Me.lblDataStart = New System.Windows.Forms.Label
        Me.lblDataEnd = New System.Windows.Forms.Label
        Me.lblOmitBefore = New System.Windows.Forms.Label
        Me.lblOmitAfter = New System.Windows.Forms.Label
        Me.txtOmitAfterYear = New System.Windows.Forms.TextBox
        Me.txtOmitBeforeYear = New System.Windows.Forms.TextBox
        Me.cboYears = New System.Windows.Forms.ComboBox
        Me.tabNDay = New System.Windows.Forms.TabPage
        Me.chkMultipleStationPlots = New System.Windows.Forms.CheckBox
        Me.chkMultipleNDayPlots = New System.Windows.Forms.CheckBox
        Me.btnDoFrequencyGraph = New System.Windows.Forms.Button
        Me.chkLog = New System.Windows.Forms.CheckBox
        Me.panelTop = New System.Windows.Forms.Panel
        Me.grpRecurrence = New System.Windows.Forms.GroupBox
        Me.btnRecurrenceDefault = New System.Windows.Forms.Button
        Me.btnRecurrenceRemove = New System.Windows.Forms.Button
        Me.lstRecurrence = New System.Windows.Forms.ListBox
        Me.btnRecurrenceAdd = New System.Windows.Forms.Button
        Me.txtRecurrenceAdd = New System.Windows.Forms.TextBox
        Me.btnRecurrenceNone = New System.Windows.Forms.Button
        Me.btnRecurrenceAll = New System.Windows.Forms.Button
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.grpNday = New System.Windows.Forms.GroupBox
        Me.btnNdayDefault = New System.Windows.Forms.Button
        Me.btnNdayRemove = New System.Windows.Forms.Button
        Me.btnNdayAdd = New System.Windows.Forms.Button
        Me.txtNdayAdd = New System.Windows.Forms.TextBox
        Me.btnNdayNone = New System.Windows.Forms.Button
        Me.btnNdayAll = New System.Windows.Forms.Button
        Me.lstNday = New System.Windows.Forms.ListBox
        Me.btnDoFrequencyGrid = New System.Windows.Forms.Button
        Me.btnDisplayTrend = New System.Windows.Forms.Button
        Me.btnNDay = New System.Windows.Forms.Button
        Me.tabDFLOW = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbNonBio3 = New System.Windows.Forms.TextBox
        Me.tbNonBio4 = New System.Windows.Forms.TextBox
        Me.tbNonBio2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbNonBio1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.rbNonBio3 = New System.Windows.Forms.RadioButton
        Me.rbNonBio2 = New System.Windows.Forms.RadioButton
        Me.rbNonBio1 = New System.Windows.Forms.RadioButton
        Me.gbBio = New System.Windows.Forms.GroupBox
        Me.tbBio3 = New System.Windows.Forms.TextBox
        Me.tbBio4 = New System.Windows.Forms.TextBox
        Me.tbBio2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbBio1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.rbBio3 = New System.Windows.Forms.RadioButton
        Me.rbBio2 = New System.Windows.Forms.RadioButton
        Me.rbBio1 = New System.Windows.Forms.RadioButton
        Me.ckbBio = New System.Windows.Forms.CheckBox
        Me.tabMain.SuspendLayout()
        Me.tabSelectDates.SuspendLayout()
        Me.gbTextOutput.SuspendLayout()
        Me.grpHighLow.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.grpYears.SuspendLayout()
        Me.tabNDay.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.grpRecurrence.SuspendLayout()
        Me.grpNday.SuspendLayout()
        Me.tabDFLOW.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbBio.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuAnalysis, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileSelectData})
        Me.mnuFile.Text = "File"
        '
        'mnuFileSelectData
        '
        Me.mnuFileSelectData.Index = 0
        Me.mnuFileSelectData.Text = "Select &Data"
        '
        'mnuAnalysis
        '
        Me.mnuAnalysis.Index = 1
        Me.mnuAnalysis.Text = "Analysis"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.mnuHelp.Text = "Help"
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.tabSelectDates)
        Me.tabMain.Controls.Add(Me.tabNDay)
        Me.tabMain.Controls.Add(Me.tabDFLOW)
        Me.tabMain.Location = New System.Drawing.Point(0, 2)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(443, 416)
        Me.tabMain.TabIndex = 1
        '
        'tabSelectDates
        '
        Me.tabSelectDates.BackColor = System.Drawing.SystemColors.Control
        Me.tabSelectDates.Controls.Add(Me.gbTextOutput)
        Me.tabSelectDates.Controls.Add(Me.grpHighLow)
        Me.tabSelectDates.Controls.Add(Me.btnDisplayBasic)
        Me.tabSelectDates.Controls.Add(Me.grpDates)
        Me.tabSelectDates.Controls.Add(Me.grpYears)
        Me.tabSelectDates.Location = New System.Drawing.Point(4, 22)
        Me.tabSelectDates.Name = "tabSelectDates"
        Me.tabSelectDates.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSelectDates.Size = New System.Drawing.Size(435, 390)
        Me.tabSelectDates.TabIndex = 0
        Me.tabSelectDates.Text = "Select Dates"
        Me.tabSelectDates.UseVisualStyleBackColor = True
        '
        'gbTextOutput
        '
        Me.gbTextOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTextOutput.Controls.Add(Me.txtOutputDir)
        Me.gbTextOutput.Controls.Add(Me.lblOutputDir)
        Me.gbTextOutput.Controls.Add(Me.txtOutputRootName)
        Me.gbTextOutput.Controls.Add(Me.lblBaseFilename)
        Me.gbTextOutput.Location = New System.Drawing.Point(214, 6)
        Me.gbTextOutput.Name = "gbTextOutput"
        Me.gbTextOutput.Size = New System.Drawing.Size(213, 144)
        Me.gbTextOutput.TabIndex = 73
        Me.gbTextOutput.TabStop = False
        Me.gbTextOutput.Text = "Output"
        Me.gbTextOutput.Visible = False
        '
        'txtOutputDir
        '
        Me.txtOutputDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputDir.Location = New System.Drawing.Point(6, 45)
        Me.txtOutputDir.Name = "txtOutputDir"
        Me.txtOutputDir.Size = New System.Drawing.Size(201, 20)
        Me.txtOutputDir.TabIndex = 12
        '
        'lblOutputDir
        '
        Me.lblOutputDir.AutoSize = True
        Me.lblOutputDir.Location = New System.Drawing.Point(6, 29)
        Me.lblOutputDir.Name = "lblOutputDir"
        Me.lblOutputDir.Size = New System.Drawing.Size(29, 13)
        Me.lblOutputDir.TabIndex = 31
        Me.lblOutputDir.Text = "Path"
        '
        'txtOutputRootName
        '
        Me.txtOutputRootName.Location = New System.Drawing.Point(6, 102)
        Me.txtOutputRootName.Name = "txtOutputRootName"
        Me.txtOutputRootName.Size = New System.Drawing.Size(201, 20)
        Me.txtOutputRootName.TabIndex = 13
        '
        'lblBaseFilename
        '
        Me.lblBaseFilename.AutoSize = True
        Me.lblBaseFilename.Location = New System.Drawing.Point(6, 86)
        Me.lblBaseFilename.Name = "lblBaseFilename"
        Me.lblBaseFilename.Size = New System.Drawing.Size(52, 13)
        Me.lblBaseFilename.TabIndex = 30
        Me.lblBaseFilename.Text = "File Prefix"
        '
        'grpHighLow
        '
        Me.grpHighLow.Controls.Add(Me.radioHigh)
        Me.grpHighLow.Controls.Add(Me.radioLow)
        Me.grpHighLow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpHighLow.Location = New System.Drawing.Point(8, 6)
        Me.grpHighLow.Name = "grpHighLow"
        Me.grpHighLow.Size = New System.Drawing.Size(200, 65)
        Me.grpHighLow.TabIndex = 72
        Me.grpHighLow.TabStop = False
        Me.grpHighLow.Text = "Flow Condition"
        '
        'radioHigh
        '
        Me.radioHigh.AutoSize = True
        Me.radioHigh.Checked = True
        Me.radioHigh.Location = New System.Drawing.Point(6, 19)
        Me.radioHigh.Name = "radioHigh"
        Me.radioHigh.Size = New System.Drawing.Size(47, 17)
        Me.radioHigh.TabIndex = 1
        Me.radioHigh.TabStop = True
        Me.radioHigh.Text = "High"
        Me.radioHigh.UseVisualStyleBackColor = True
        '
        'radioLow
        '
        Me.radioLow.AutoSize = True
        Me.radioLow.Location = New System.Drawing.Point(6, 42)
        Me.radioLow.Name = "radioLow"
        Me.radioLow.Size = New System.Drawing.Size(45, 17)
        Me.radioLow.TabIndex = 2
        Me.radioLow.Text = "Low"
        Me.radioLow.UseVisualStyleBackColor = True
        '
        'btnDisplayBasic
        '
        Me.btnDisplayBasic.Location = New System.Drawing.Point(8, 270)
        Me.btnDisplayBasic.Name = "btnDisplayBasic"
        Me.btnDisplayBasic.Size = New System.Drawing.Size(157, 23)
        Me.btnDisplayBasic.TabIndex = 10
        Me.btnDisplayBasic.Text = "Display Basic Statistics"
        Me.btnDisplayBasic.UseVisualStyleBackColor = True
        '
        'grpDates
        '
        Me.grpDates.BackColor = System.Drawing.SystemColors.Control
        Me.grpDates.Controls.Add(Me.cboStartMonth)
        Me.grpDates.Controls.Add(Me.lblYearStart)
        Me.grpDates.Controls.Add(Me.txtEndDay)
        Me.grpDates.Controls.Add(Me.txtStartDay)
        Me.grpDates.Controls.Add(Me.cboEndMonth)
        Me.grpDates.Controls.Add(Me.lblYearEnd)
        Me.grpDates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpDates.Location = New System.Drawing.Point(8, 77)
        Me.grpDates.Name = "grpDates"
        Me.grpDates.Size = New System.Drawing.Size(200, 73)
        Me.grpDates.TabIndex = 67
        Me.grpDates.TabStop = False
        Me.grpDates.Text = "Year / Season Boundaries"
        '
        'cboStartMonth
        '
        Me.cboStartMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboStartMonth.Location = New System.Drawing.Point(41, 19)
        Me.cboStartMonth.MaxDropDownItems = 12
        Me.cboStartMonth.Name = "cboStartMonth"
        Me.cboStartMonth.Size = New System.Drawing.Size(88, 21)
        Me.cboStartMonth.TabIndex = 3
        Me.cboStartMonth.Text = "January"
        '
        'lblYearStart
        '
        Me.lblYearStart.AutoSize = True
        Me.lblYearStart.Location = New System.Drawing.Point(6, 22)
        Me.lblYearStart.Name = "lblYearStart"
        Me.lblYearStart.Size = New System.Drawing.Size(29, 13)
        Me.lblYearStart.TabIndex = 23
        Me.lblYearStart.Text = "Start"
        '
        'txtEndDay
        '
        Me.txtEndDay.Location = New System.Drawing.Point(135, 46)
        Me.txtEndDay.Name = "txtEndDay"
        Me.txtEndDay.Size = New System.Drawing.Size(24, 20)
        Me.txtEndDay.TabIndex = 6
        Me.txtEndDay.Text = "31"
        Me.txtEndDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartDay
        '
        Me.txtStartDay.Location = New System.Drawing.Point(135, 19)
        Me.txtStartDay.Name = "txtStartDay"
        Me.txtStartDay.Size = New System.Drawing.Size(24, 20)
        Me.txtStartDay.TabIndex = 4
        Me.txtStartDay.Text = "1"
        Me.txtStartDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboEndMonth
        '
        Me.cboEndMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboEndMonth.Location = New System.Drawing.Point(41, 46)
        Me.cboEndMonth.MaxDropDownItems = 12
        Me.cboEndMonth.Name = "cboEndMonth"
        Me.cboEndMonth.Size = New System.Drawing.Size(88, 21)
        Me.cboEndMonth.TabIndex = 5
        Me.cboEndMonth.Text = "December"
        '
        'lblYearEnd
        '
        Me.lblYearEnd.AutoSize = True
        Me.lblYearEnd.Location = New System.Drawing.Point(6, 49)
        Me.lblYearEnd.Name = "lblYearEnd"
        Me.lblYearEnd.Size = New System.Drawing.Size(26, 13)
        Me.lblYearEnd.TabIndex = 61
        Me.lblYearEnd.Text = "End"
        '
        'grpYears
        '
        Me.grpYears.BackColor = System.Drawing.SystemColors.Control
        Me.grpYears.Controls.Add(Me.lblDataStart)
        Me.grpYears.Controls.Add(Me.lblDataEnd)
        Me.grpYears.Controls.Add(Me.lblOmitBefore)
        Me.grpYears.Controls.Add(Me.lblOmitAfter)
        Me.grpYears.Controls.Add(Me.txtOmitAfterYear)
        Me.grpYears.Controls.Add(Me.txtOmitBeforeYear)
        Me.grpYears.Controls.Add(Me.cboYears)
        Me.grpYears.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpYears.Location = New System.Drawing.Point(8, 156)
        Me.grpYears.Name = "grpYears"
        Me.grpYears.Size = New System.Drawing.Size(250, 102)
        Me.grpYears.TabIndex = 66
        Me.grpYears.TabStop = False
        Me.grpYears.Text = "Years to Include in Analysis"
        '
        'lblDataStart
        '
        Me.lblDataStart.AutoSize = True
        Me.lblDataStart.Enabled = False
        Me.lblDataStart.Location = New System.Drawing.Point(123, 49)
        Me.lblDataStart.Name = "lblDataStart"
        Me.lblDataStart.Size = New System.Drawing.Size(119, 13)
        Me.lblDataStart.TabIndex = 45
        Me.lblDataStart.Tag = "Data Starts"
        Me.lblDataStart.Text = "Start Date: 11/22/1934"
        '
        'lblDataEnd
        '
        Me.lblDataEnd.AutoSize = True
        Me.lblDataEnd.Enabled = False
        Me.lblDataEnd.Location = New System.Drawing.Point(123, 75)
        Me.lblDataEnd.Name = "lblDataEnd"
        Me.lblDataEnd.Size = New System.Drawing.Size(116, 13)
        Me.lblDataEnd.TabIndex = 1
        Me.lblDataEnd.Tag = "Data Ends"
        Me.lblDataEnd.Text = "End Date: 11/22/1934"
        '
        'lblOmitBefore
        '
        Me.lblOmitBefore.AutoSize = True
        Me.lblOmitBefore.Enabled = False
        Me.lblOmitBefore.Location = New System.Drawing.Point(6, 49)
        Me.lblOmitBefore.Name = "lblOmitBefore"
        Me.lblOmitBefore.Size = New System.Drawing.Size(54, 13)
        Me.lblOmitBefore.TabIndex = 40
        Me.lblOmitBefore.Text = "Start Year"
        '
        'lblOmitAfter
        '
        Me.lblOmitAfter.AutoSize = True
        Me.lblOmitAfter.Enabled = False
        Me.lblOmitAfter.Location = New System.Drawing.Point(6, 75)
        Me.lblOmitAfter.Name = "lblOmitAfter"
        Me.lblOmitAfter.Size = New System.Drawing.Size(51, 13)
        Me.lblOmitAfter.TabIndex = 43
        Me.lblOmitAfter.Text = "End Year"
        '
        'txtOmitAfterYear
        '
        Me.txtOmitAfterYear.Enabled = False
        Me.txtOmitAfterYear.Location = New System.Drawing.Point(66, 72)
        Me.txtOmitAfterYear.Name = "txtOmitAfterYear"
        Me.txtOmitAfterYear.Size = New System.Drawing.Size(37, 20)
        Me.txtOmitAfterYear.TabIndex = 9
        Me.txtOmitAfterYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOmitBeforeYear
        '
        Me.txtOmitBeforeYear.Enabled = False
        Me.txtOmitBeforeYear.Location = New System.Drawing.Point(66, 46)
        Me.txtOmitBeforeYear.Name = "txtOmitBeforeYear"
        Me.txtOmitBeforeYear.Size = New System.Drawing.Size(37, 20)
        Me.txtOmitBeforeYear.TabIndex = 8
        Me.txtOmitBeforeYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboYears
        '
        Me.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Location = New System.Drawing.Point(6, 18)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(233, 21)
        Me.cboYears.TabIndex = 7
        '
        'tabNDay
        '
        Me.tabNDay.BackColor = System.Drawing.SystemColors.Control
        Me.tabNDay.Controls.Add(Me.chkMultipleStationPlots)
        Me.tabNDay.Controls.Add(Me.chkMultipleNDayPlots)
        Me.tabNDay.Controls.Add(Me.btnDoFrequencyGraph)
        Me.tabNDay.Controls.Add(Me.chkLog)
        Me.tabNDay.Controls.Add(Me.panelTop)
        Me.tabNDay.Controls.Add(Me.btnDoFrequencyGrid)
        Me.tabNDay.Controls.Add(Me.btnDisplayTrend)
        Me.tabNDay.Controls.Add(Me.btnNDay)
        Me.tabNDay.Location = New System.Drawing.Point(4, 22)
        Me.tabNDay.Name = "tabNDay"
        Me.tabNDay.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNDay.Size = New System.Drawing.Size(435, 390)
        Me.tabNDay.TabIndex = 2
        Me.tabNDay.Text = "N-Day, Trend, Frequency"
        Me.tabNDay.UseVisualStyleBackColor = True
        '
        'chkMultipleStationPlots
        '
        Me.chkMultipleStationPlots.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMultipleStationPlots.AutoSize = True
        Me.chkMultipleStationPlots.Location = New System.Drawing.Point(283, 210)
        Me.chkMultipleStationPlots.Name = "chkMultipleStationPlots"
        Me.chkMultipleStationPlots.Size = New System.Drawing.Size(124, 17)
        Me.chkMultipleStationPlots.TabIndex = 40
        Me.chkMultipleStationPlots.Text = "Multiple Station Plots"
        Me.chkMultipleStationPlots.UseVisualStyleBackColor = True
        '
        'chkMultipleNDayPlots
        '
        Me.chkMultipleNDayPlots.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMultipleNDayPlots.AutoSize = True
        Me.chkMultipleNDayPlots.Location = New System.Drawing.Point(283, 191)
        Me.chkMultipleNDayPlots.Name = "chkMultipleNDayPlots"
        Me.chkMultipleNDayPlots.Size = New System.Drawing.Size(121, 17)
        Me.chkMultipleNDayPlots.TabIndex = 39
        Me.chkMultipleNDayPlots.Text = "Multiple N-Day Plots"
        Me.chkMultipleNDayPlots.UseVisualStyleBackColor = True
        '
        'btnDoFrequencyGraph
        '
        Me.btnDoFrequencyGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDoFrequencyGraph.Location = New System.Drawing.Point(138, 204)
        Me.btnDoFrequencyGraph.Name = "btnDoFrequencyGraph"
        Me.btnDoFrequencyGraph.Size = New System.Drawing.Size(139, 23)
        Me.btnDoFrequencyGraph.TabIndex = 38
        Me.btnDoFrequencyGraph.Text = "Frequency Graph"
        Me.btnDoFrequencyGraph.UseVisualStyleBackColor = True
        '
        'chkLog
        '
        Me.chkLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkLog.AutoSize = True
        Me.chkLog.Checked = True
        Me.chkLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLog.Location = New System.Drawing.Point(221, 157)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.Size = New System.Drawing.Size(80, 17)
        Me.chkLog.TabIndex = 36
        Me.chkLog.Text = "Logarithmic"
        Me.chkLog.UseVisualStyleBackColor = True
        '
        'panelTop
        '
        Me.panelTop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTop.Controls.Add(Me.grpRecurrence)
        Me.panelTop.Controls.Add(Me.Splitter1)
        Me.panelTop.Controls.Add(Me.grpNday)
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(435, 151)
        Me.panelTop.TabIndex = 34
        '
        'grpRecurrence
        '
        Me.grpRecurrence.BackColor = System.Drawing.SystemColors.Control
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceDefault)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceRemove)
        Me.grpRecurrence.Controls.Add(Me.lstRecurrence)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceAdd)
        Me.grpRecurrence.Controls.Add(Me.txtRecurrenceAdd)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceNone)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceAll)
        Me.grpRecurrence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpRecurrence.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpRecurrence.Location = New System.Drawing.Point(208, 0)
        Me.grpRecurrence.Name = "grpRecurrence"
        Me.grpRecurrence.Size = New System.Drawing.Size(227, 151)
        Me.grpRecurrence.TabIndex = 7
        Me.grpRecurrence.TabStop = False
        Me.grpRecurrence.Text = "Recurrence Interval"
        '
        'btnRecurrenceDefault
        '
        Me.btnRecurrenceDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceDefault.Location = New System.Drawing.Point(165, 92)
        Me.btnRecurrenceDefault.Name = "btnRecurrenceDefault"
        Me.btnRecurrenceDefault.Size = New System.Drawing.Size(56, 20)
        Me.btnRecurrenceDefault.TabIndex = 31
        Me.btnRecurrenceDefault.Text = "Default"
        '
        'btnRecurrenceRemove
        '
        Me.btnRecurrenceRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceRemove.Location = New System.Drawing.Point(132, 92)
        Me.btnRecurrenceRemove.Name = "btnRecurrenceRemove"
        Me.btnRecurrenceRemove.Size = New System.Drawing.Size(27, 20)
        Me.btnRecurrenceRemove.TabIndex = 30
        Me.btnRecurrenceRemove.Text = "-"
        '
        'lstRecurrence
        '
        Me.lstRecurrence.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstRecurrence.IntegralHeight = False
        Me.lstRecurrence.Location = New System.Drawing.Point(6, 19)
        Me.lstRecurrence.Name = "lstRecurrence"
        Me.lstRecurrence.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstRecurrence.Size = New System.Drawing.Size(213, 67)
        Me.lstRecurrence.TabIndex = 27
        Me.lstRecurrence.Tag = "Return Period"
        '
        'btnRecurrenceAdd
        '
        Me.btnRecurrenceAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceAdd.Location = New System.Drawing.Point(99, 92)
        Me.btnRecurrenceAdd.Name = "btnRecurrenceAdd"
        Me.btnRecurrenceAdd.Size = New System.Drawing.Size(27, 20)
        Me.btnRecurrenceAdd.TabIndex = 29
        Me.btnRecurrenceAdd.Text = "+"
        '
        'txtRecurrenceAdd
        '
        Me.txtRecurrenceAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecurrenceAdd.Location = New System.Drawing.Point(6, 92)
        Me.txtRecurrenceAdd.Name = "txtRecurrenceAdd"
        Me.txtRecurrenceAdd.Size = New System.Drawing.Size(87, 20)
        Me.txtRecurrenceAdd.TabIndex = 28
        '
        'btnRecurrenceNone
        '
        Me.btnRecurrenceNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceNone.Location = New System.Drawing.Point(157, 121)
        Me.btnRecurrenceNone.Name = "btnRecurrenceNone"
        Me.btnRecurrenceNone.Size = New System.Drawing.Size(64, 24)
        Me.btnRecurrenceNone.TabIndex = 33
        Me.btnRecurrenceNone.Text = "None"
        '
        'btnRecurrenceAll
        '
        Me.btnRecurrenceAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceAll.Location = New System.Drawing.Point(6, 121)
        Me.btnRecurrenceAll.Name = "btnRecurrenceAll"
        Me.btnRecurrenceAll.Size = New System.Drawing.Size(64, 24)
        Me.btnRecurrenceAll.TabIndex = 32
        Me.btnRecurrenceAll.Text = "All"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Control
        Me.Splitter1.Location = New System.Drawing.Point(200, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 151)
        Me.Splitter1.TabIndex = 13
        Me.Splitter1.TabStop = False
        '
        'grpNday
        '
        Me.grpNday.BackColor = System.Drawing.SystemColors.Control
        Me.grpNday.Controls.Add(Me.btnNdayDefault)
        Me.grpNday.Controls.Add(Me.btnNdayRemove)
        Me.grpNday.Controls.Add(Me.btnNdayAdd)
        Me.grpNday.Controls.Add(Me.txtNdayAdd)
        Me.grpNday.Controls.Add(Me.btnNdayNone)
        Me.grpNday.Controls.Add(Me.btnNdayAll)
        Me.grpNday.Controls.Add(Me.lstNday)
        Me.grpNday.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpNday.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpNday.Location = New System.Drawing.Point(0, 0)
        Me.grpNday.Name = "grpNday"
        Me.grpNday.Size = New System.Drawing.Size(200, 151)
        Me.grpNday.TabIndex = 1
        Me.grpNday.TabStop = False
        Me.grpNday.Text = "Number of Days"
        '
        'btnNdayDefault
        '
        Me.btnNdayDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayDefault.Location = New System.Drawing.Point(138, 92)
        Me.btnNdayDefault.Name = "btnNdayDefault"
        Me.btnNdayDefault.Size = New System.Drawing.Size(56, 20)
        Me.btnNdayDefault.TabIndex = 24
        Me.btnNdayDefault.Text = "Default"
        '
        'btnNdayRemove
        '
        Me.btnNdayRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayRemove.Location = New System.Drawing.Point(105, 92)
        Me.btnNdayRemove.Name = "btnNdayRemove"
        Me.btnNdayRemove.Size = New System.Drawing.Size(27, 20)
        Me.btnNdayRemove.TabIndex = 23
        Me.btnNdayRemove.Text = "-"
        '
        'btnNdayAdd
        '
        Me.btnNdayAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayAdd.Location = New System.Drawing.Point(72, 92)
        Me.btnNdayAdd.Name = "btnNdayAdd"
        Me.btnNdayAdd.Size = New System.Drawing.Size(27, 20)
        Me.btnNdayAdd.TabIndex = 22
        Me.btnNdayAdd.Text = "+"
        '
        'txtNdayAdd
        '
        Me.txtNdayAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNdayAdd.Location = New System.Drawing.Point(6, 92)
        Me.txtNdayAdd.Name = "txtNdayAdd"
        Me.txtNdayAdd.Size = New System.Drawing.Size(54, 20)
        Me.txtNdayAdd.TabIndex = 21
        '
        'btnNdayNone
        '
        Me.btnNdayNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayNone.Location = New System.Drawing.Point(130, 121)
        Me.btnNdayNone.Name = "btnNdayNone"
        Me.btnNdayNone.Size = New System.Drawing.Size(64, 23)
        Me.btnNdayNone.TabIndex = 26
        Me.btnNdayNone.Text = "None"
        '
        'btnNdayAll
        '
        Me.btnNdayAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNdayAll.Location = New System.Drawing.Point(6, 121)
        Me.btnNdayAll.Name = "btnNdayAll"
        Me.btnNdayAll.Size = New System.Drawing.Size(64, 24)
        Me.btnNdayAll.TabIndex = 25
        Me.btnNdayAll.Text = "All"
        '
        'lstNday
        '
        Me.lstNday.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstNday.IntegralHeight = False
        Me.lstNday.Location = New System.Drawing.Point(6, 19)
        Me.lstNday.Name = "lstNday"
        Me.lstNday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstNday.Size = New System.Drawing.Size(188, 67)
        Me.lstNday.TabIndex = 20
        Me.lstNday.Tag = "NDay"
        '
        'btnDoFrequencyGrid
        '
        Me.btnDoFrequencyGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDoFrequencyGrid.Location = New System.Drawing.Point(138, 175)
        Me.btnDoFrequencyGrid.Name = "btnDoFrequencyGrid"
        Me.btnDoFrequencyGrid.Size = New System.Drawing.Size(139, 23)
        Me.btnDoFrequencyGrid.TabIndex = 37
        Me.btnDoFrequencyGrid.Text = "Frequency Grid"
        Me.btnDoFrequencyGrid.UseVisualStyleBackColor = True
        '
        'btnDisplayTrend
        '
        Me.btnDisplayTrend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDisplayTrend.Location = New System.Drawing.Point(8, 204)
        Me.btnDisplayTrend.Name = "btnDisplayTrend"
        Me.btnDisplayTrend.Size = New System.Drawing.Size(124, 23)
        Me.btnDisplayTrend.TabIndex = 35
        Me.btnDisplayTrend.Text = "Trend List"
        Me.btnDisplayTrend.UseVisualStyleBackColor = True
        '
        'btnNDay
        '
        Me.btnNDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNDay.Location = New System.Drawing.Point(8, 175)
        Me.btnNDay.Name = "btnNDay"
        Me.btnNDay.Size = New System.Drawing.Size(124, 23)
        Me.btnNDay.TabIndex = 34
        Me.btnNDay.Text = "N-Day Timeseries List"
        Me.btnNDay.UseVisualStyleBackColor = True
        '
        'tabDFLOW
        '
        Me.tabDFLOW.Controls.Add(Me.GroupBox2)
        Me.tabDFLOW.Controls.Add(Me.gbBio)
        Me.tabDFLOW.Location = New System.Drawing.Point(4, 22)
        Me.tabDFLOW.Name = "tabDFLOW"
        Me.tabDFLOW.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDFLOW.Size = New System.Drawing.Size(435, 390)
        Me.tabDFLOW.TabIndex = 3
        Me.tabDFLOW.Text = "Design Flow"
        Me.tabDFLOW.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbNonBio3)
        Me.GroupBox2.Controls.Add(Me.tbNonBio4)
        Me.GroupBox2.Controls.Add(Me.tbNonBio2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbNonBio1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.rbNonBio3)
        Me.GroupBox2.Controls.Add(Me.rbNonBio2)
        Me.GroupBox2.Controls.Add(Me.rbNonBio1)
        Me.GroupBox2.Location = New System.Drawing.Point(95, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 142)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Non-Biological Design Flow Parameters"
        '
        'tbNonBio3
        '
        Me.tbNonBio3.Enabled = False
        Me.tbNonBio3.Location = New System.Drawing.Point(263, 88)
        Me.tbNonBio3.Name = "tbNonBio3"
        Me.tbNonBio3.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio3.TabIndex = 11
        Me.tbNonBio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNonBio4
        '
        Me.tbNonBio4.Enabled = False
        Me.tbNonBio4.Location = New System.Drawing.Point(263, 110)
        Me.tbNonBio4.Name = "tbNonBio4"
        Me.tbNonBio4.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio4.TabIndex = 10
        Me.tbNonBio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNonBio2
        '
        Me.tbNonBio2.Enabled = False
        Me.tbNonBio2.Location = New System.Drawing.Point(263, 58)
        Me.tbNonBio2.Name = "tbNonBio2"
        Me.tbNonBio2.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio2.TabIndex = 9
        Me.tbNonBio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(308, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "cfs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(308, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(19, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(226, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Return period on years with excursions (years):"
        '
        'tbNonBio1
        '
        Me.tbNonBio1.Enabled = False
        Me.tbNonBio1.Location = New System.Drawing.Point(263, 36)
        Me.tbNonBio1.Name = "tbNonBio1"
        Me.tbNonBio1.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio1.TabIndex = 5
        Me.tbNonBio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(19, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Flow averaging period (days):"
        '
        'rbNonBio3
        '
        Me.rbNonBio3.AutoSize = True
        Me.rbNonBio3.Location = New System.Drawing.Point(6, 111)
        Me.rbNonBio3.Name = "rbNonBio3"
        Me.rbNonBio3.Size = New System.Drawing.Size(99, 17)
        Me.rbNonBio3.TabIndex = 3
        Me.rbNonBio3.Text = "Flow percentile:"
        Me.rbNonBio3.UseVisualStyleBackColor = True
        '
        'rbNonBio2
        '
        Me.rbNonBio2.AutoSize = True
        Me.rbNonBio2.Location = New System.Drawing.Point(6, 88)
        Me.rbNonBio2.Name = "rbNonBio2"
        Me.rbNonBio2.Size = New System.Drawing.Size(112, 17)
        Me.rbNonBio2.TabIndex = 2
        Me.rbNonBio2.Text = "Explicit flow value:"
        Me.rbNonBio2.UseVisualStyleBackColor = True
        '
        'rbNonBio1
        '
        Me.rbNonBio1.AutoSize = True
        Me.rbNonBio1.Checked = True
        Me.rbNonBio1.Location = New System.Drawing.Point(6, 19)
        Me.rbNonBio1.Name = "rbNonBio1"
        Me.rbNonBio1.Size = New System.Drawing.Size(83, 17)
        Me.rbNonBio1.TabIndex = 1
        Me.rbNonBio1.TabStop = True
        Me.rbNonBio1.Text = "Hydrological"
        Me.rbNonBio1.UseVisualStyleBackColor = True
        '
        'gbBio
        '
        Me.gbBio.Controls.Add(Me.tbBio3)
        Me.gbBio.Controls.Add(Me.tbBio4)
        Me.gbBio.Controls.Add(Me.tbBio2)
        Me.gbBio.Controls.Add(Me.Label4)
        Me.gbBio.Controls.Add(Me.Label3)
        Me.gbBio.Controls.Add(Me.Label2)
        Me.gbBio.Controls.Add(Me.tbBio1)
        Me.gbBio.Controls.Add(Me.Label1)
        Me.gbBio.Controls.Add(Me.rbBio3)
        Me.gbBio.Controls.Add(Me.rbBio2)
        Me.gbBio.Controls.Add(Me.rbBio1)
        Me.gbBio.Controls.Add(Me.ckbBio)
        Me.gbBio.Location = New System.Drawing.Point(95, 6)
        Me.gbBio.Name = "gbBio"
        Me.gbBio.Size = New System.Drawing.Size(332, 229)
        Me.gbBio.TabIndex = 5
        Me.gbBio.TabStop = False
        Me.gbBio.Text = "Biological Design Flow Parameters"
        '
        'tbBio3
        '
        Me.tbBio3.Enabled = False
        Me.tbBio3.Location = New System.Drawing.Point(263, 170)
        Me.tbBio3.Name = "tbBio3"
        Me.tbBio3.Size = New System.Drawing.Size(46, 20)
        Me.tbBio3.TabIndex = 11
        Me.tbBio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio4
        '
        Me.tbBio4.Enabled = False
        Me.tbBio4.Location = New System.Drawing.Point(263, 195)
        Me.tbBio4.Name = "tbBio4"
        Me.tbBio4.Size = New System.Drawing.Size(46, 20)
        Me.tbBio4.TabIndex = 10
        Me.tbBio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio2
        '
        Me.tbBio2.Enabled = False
        Me.tbBio2.Location = New System.Drawing.Point(263, 145)
        Me.tbBio2.Name = "tbBio2"
        Me.tbBio2.Size = New System.Drawing.Size(46, 20)
        Me.tbBio2.TabIndex = 9
        Me.tbBio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(3, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Average number of excursions counted per cluster:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(3, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Length of excursion clustering period (days):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(3, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Average number of years between excursions:"
        '
        'tbBio1
        '
        Me.tbBio1.Enabled = False
        Me.tbBio1.Location = New System.Drawing.Point(263, 120)
        Me.tbBio1.Name = "tbBio1"
        Me.tbBio1.Size = New System.Drawing.Size(46, 20)
        Me.tbBio1.TabIndex = 5
        Me.tbBio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(3, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Flow averaging period (days):"
        '
        'rbBio3
        '
        Me.rbBio3.AutoSize = True
        Me.rbBio3.Location = New System.Drawing.Point(22, 88)
        Me.rbBio3.Name = "rbBio3"
        Me.rbBio3.Size = New System.Drawing.Size(68, 17)
        Me.rbBio3.TabIndex = 3
        Me.rbBio3.Text = "Ammonia"
        Me.rbBio3.UseVisualStyleBackColor = True
        '
        'rbBio2
        '
        Me.rbBio2.AutoSize = True
        Me.rbBio2.Location = New System.Drawing.Point(22, 65)
        Me.rbBio2.Name = "rbBio2"
        Me.rbBio2.Size = New System.Drawing.Size(230, 17)
        Me.rbBio2.TabIndex = 2
        Me.rbBio2.Text = "Criterion continuous concentration (chronic)"
        Me.rbBio2.UseVisualStyleBackColor = True
        '
        'rbBio1
        '
        Me.rbBio1.AutoSize = True
        Me.rbBio1.Checked = True
        Me.rbBio1.Location = New System.Drawing.Point(22, 42)
        Me.rbBio1.Name = "rbBio1"
        Me.rbBio1.Size = New System.Drawing.Size(213, 17)
        Me.rbBio1.TabIndex = 1
        Me.rbBio1.TabStop = True
        Me.rbBio1.Text = "Criterion maximum concentration (acute)"
        Me.rbBio1.UseVisualStyleBackColor = True
        '
        'ckbBio
        '
        Me.ckbBio.AutoSize = True
        Me.ckbBio.Checked = True
        Me.ckbBio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbBio.Location = New System.Drawing.Point(6, 19)
        Me.ckbBio.Name = "ckbBio"
        Me.ckbBio.Size = New System.Drawing.Size(85, 17)
        Me.ckbBio.TabIndex = 0
        Me.ckbBio.Text = "Use defaults"
        Me.ckbBio.UseVisualStyleBackColor = True
        '
        'frmSWSTAT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(443, 418)
        Me.Controls.Add(Me.tabMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmSWSTAT"
        Me.Text = "Integrated Design Flow"
        Me.tabMain.ResumeLayout(False)
        Me.tabSelectDates.ResumeLayout(False)
        Me.gbTextOutput.ResumeLayout(False)
        Me.gbTextOutput.PerformLayout()
        Me.grpHighLow.ResumeLayout(False)
        Me.grpHighLow.PerformLayout()
        Me.grpDates.ResumeLayout(False)
        Me.grpDates.PerformLayout()
        Me.grpYears.ResumeLayout(False)
        Me.grpYears.PerformLayout()
        Me.tabNDay.ResumeLayout(False)
        Me.tabNDay.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.grpRecurrence.ResumeLayout(False)
        Me.grpRecurrence.PerformLayout()
        Me.grpNday.ResumeLayout(False)
        Me.grpNday.PerformLayout()
        Me.tabDFLOW.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbBio.ResumeLayout(False)
        Me.gbBio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'The group of atcTimeseries displayed
    Private WithEvents pDataGroup As atcTimeseriesGroup
    Private WithEvents pNDayGroup As atcTimeseriesGroup

    Private pDateFormat As New atcDateFormat

    'Value formatting options, can be overridden by timeseries attributes
    Private pMaxWidth As Integer = 10
    Private pFormat As String = "#,##0.########"
    Private pExpFormat As String = "#.#e#"
    Private pCantFit As String = "#"
    Private pSignificantDigits As Integer = 5

    'Private pDataAttributes As ArrayList
    Private pBasicAttributes As Generic.List(Of String)
    Private pNDayAttributes As Generic.List(Of String)
    Private pTrendAttributes As Generic.List(Of String)

    Private pYearStartMonth As Integer = 0
    Private pYearStartDay As Integer = 0
    Private pYearEndMonth As Integer = 0
    Private pYearEndDay As Integer = 0
    Private pFirstYear As Integer = 0
    Private pLastYear As Integer = 0

    Private pCommonStart As Double = GetMinValue()
    Private pCommonEnd As Double = GetMaxValue()

    Private Const pNoDatesInCommon As String = ": No dates in common"

    Public Event ParametersSet(ByVal aArgs As atcDataAttributes)
    Private pAttributes As atcDataAttributes
    Private pSetGlobal As Boolean = False
    Private pBatch As Boolean = False

    Private pHelpLocation As String = "BASINS Details\Analysis\USGS Surface Water Statistics.html"
    Private Sub mnuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click
        ShowHelp(pHelpLocation)
    End Sub

    Private Sub PopulateForm()
        pDateFormat = New atcDateFormat
        With pDateFormat
            .IncludeHours = False
            .IncludeMinutes = False
            .IncludeSeconds = False
        End With

        If GetSetting("atcFrequencyGrid", "Defaults", "HighOrLow", "High") = "High" Then
            radioHigh.Checked = True
        Else
            radioLow.Checked = True
        End If

        chkLog.Checked = (GetSetting("atcFrequencyGrid", "Defaults", "Logarithmic", "True") = "True")

        LoadListSettingsOrDefaults(lstNday)
        LoadListSettingsOrDefaults(lstRecurrence)
        RepopulateForm()
    End Sub

    Private Sub PopulateForm(ByVal attribs As atcDataAttributes)
        pDateFormat = New atcDateFormat
        With pDateFormat
            .IncludeHours = False
            .IncludeMinutes = False
            .IncludeSeconds = False
        End With

        Dim lHighLow As String = attribs.GetValue(InputNames.HighLow, "")
        If lHighLow.ToLower = "high" Then
            radioHigh.Checked = True
        Else
            radioLow.Checked = True
        End If

        chkLog.Checked = attribs.GetValue(InputNames.Logarithmic, True)
        chkMultipleNDayPlots.Checked = attribs.GetValue(InputNames.MultiNDayPlot, False)
        chkMultipleStationPlots.Checked = attribs.GetValue(InputNames.MultiStationPlot, False)
        Dim lOutDir As String = attribs.GetValue(InputNames.OutputDir, "")
        If IO.Directory.Exists(lOutDir) Then
            txtOutputDir.Text = lOutDir
        End If
        Dim lPrefix As String = attribs.GetValue(InputNames.OutputPrefix, "")
        txtOutputRootName.Text = lPrefix

        LoadListSettingsOrDefaults(lstNday, attribs)
        LoadListSettingsOrDefaults(lstRecurrence, attribs)
        RepopulateForm()
    End Sub

    Private Sub RepopulateForm()
        SeasonsYearsToForm()

        Dim lFirstDate As Double = GetMaxValue()
        Dim lLastDate As Double = GetMinValue()

        pCommonStart = GetMinValue()
        pCommonEnd = GetMaxValue()

        Dim lAllText As String = "All"
        Dim lCommonText As String = "Common"

        Dim lHaveAnnual As Boolean = False
        Dim lAnnualIsHigh As Boolean = False
        Dim lAnnualIsLow As Boolean = False
        Dim lAnnualNday As Integer = 0

        For Each lDataset As atcData.atcTimeseries In pDataGroup
            If lDataset.Dates.numValues > 0 Then
                Dim lThisDate As Double = lDataset.Dates.Value(1)
                If lThisDate < lFirstDate Then lFirstDate = lThisDate
                If lThisDate > pCommonStart Then pCommonStart = lThisDate
                lThisDate = lDataset.Dates.Value(lDataset.Dates.numValues)
                If lThisDate > lLastDate Then lLastDate = lThisDate
                If lThisDate < pCommonEnd Then pCommonEnd = lThisDate

                If lDataset.Attributes.GetValue("Tu", atcTimeUnit.TUDay) = atcTimeUnit.TUYear Then
                    lHaveAnnual = True
                    Dim lConstituent As String = lDataset.Attributes.GetValue("Constituent", "")
                    If lConstituent.Length < 4 Then
                        Logger.Msg("Dataset #" & lDataset.Attributes.GetValue("ID", "") & " " & lDataset.ToString, _
                                   "Annual Dataset Missing Constituent")
                    Else
                        Select Case lConstituent.Substring(0, 1).ToUpper
                            Case "L" : lAnnualIsLow = True
                            Case "H" : lAnnualIsHigh = True
                            Case Else
                                Logger.Msg("Dataset #" & lDataset.Attributes.GetValue("ID", "") & " " & lDataset.ToString, _
                                           "Annual Dataset Constituent does not start with L or H")
                        End Select
                        Dim lNday As Integer
                        If Integer.TryParse(lConstituent.Substring(1), lNday) Then
                            If lAnnualNday = 0 Then
                                lAnnualNday = lNday
                            ElseIf lAnnualNday <> lNday Then
                                Logger.Msg("Annual datasets with different N-Day cannot be analyzed at the same time." & vbCrLf _
                                           & "N-Day values of both " & lAnnualNday & " and " & lNday & " were found.", _
                                           "Incompatible Annual Data Selected")
                            End If
                        End If
                    End If
                End If
            End If
        Next

        grpHighLow.Enabled = True
        grpNday.Enabled = True
        If lHaveAnnual Then
            If lAnnualIsLow <> lAnnualIsHigh Then
                radioHigh.Checked = lAnnualIsHigh
                radioLow.Checked = Not lAnnualIsHigh
                grpHighLow.Enabled = False
            Else
                If lAnnualIsLow Then
                    Logger.Msg("Low and high annual datasets cannot be analyzed at the same time", _
                               "Incompatible Annual Data Selected")
                End If
            End If

            If lAnnualNday > 0 Then
                lstNday.ClearSelected()
                SelectNday(lAnnualNday)
                grpNday.Enabled = False
            End If
        End If

        If lFirstDate < GetMaxValue() AndAlso lLastDate > GetMinValue() Then
            lblDataStart.Text = lblDataStart.Tag & " " & pDateFormat.JDateToString(lFirstDate)
            lblDataEnd.Text = lblDataEnd.Tag & " " & pDateFormat.JDateToString(lLastDate)
            lAllText &= ": " & pDateFormat.JDateToString(lFirstDate) & " to " & pDateFormat.JDateToString(lLastDate)
        End If

        If pCommonStart > GetMinValue() AndAlso pCommonEnd < GetMaxValue() AndAlso pCommonStart < pCommonEnd Then
            lCommonText &= ": " & pDateFormat.JDateToString(pCommonStart) & " to " & pDateFormat.JDateToString(pCommonEnd)
        Else
            lCommonText &= pNoDatesInCommon
        End If

        Dim lLastSelectedIndex As Integer = cboYears.SelectedIndex
        If lLastSelectedIndex < 0 Then lLastSelectedIndex = 0
        With cboYears.Items
            .Clear()
            .Add(lAllText)
            .Add(lCommonText)
            .Add("Custom")
        End With
        cboYears.SelectedIndex = lLastSelectedIndex
    End Sub

    Private Sub LoadListSettingsOrDefaults(ByVal lst As Windows.Forms.ListBox)
        Dim lArgName As String = lst.Tag
        Dim lAvailableArray As String(,) = GetAllSettings("atcFrequencyGrid", "List." & lArgName)
        Dim lSelected As New ArrayList
        lst.Items.Clear()

        If Not lAvailableArray Is Nothing AndAlso lAvailableArray.Length > 0 Then
            Try
                For lIndex As Integer = 0 To lAvailableArray.GetUpperBound(0)
                    lst.Items.Add(lAvailableArray(lIndex, 0))
                    If lAvailableArray(lIndex, 1) = "True" Then
                        lst.SetSelected(lst.Items.Count - 1, True)
                    End If
                Next
            Catch e As Exception
                Logger.Dbg("Error retrieving saved settings: " & e.Message)
            End Try
        Else
            LoadListDefaults(lst)
        End If
    End Sub

    Private Sub LoadListSettingsOrDefaults(ByVal lst As Windows.Forms.ListBox, ByVal attribs As atcDataAttributes)
        Dim lArgName As String = lst.Tag & "s"
        Dim listing As atcCollection = attribs.GetValue(lArgName, Nothing)
        If listing Is Nothing Then
            Exit Sub
        End If

        Dim lSelected As New ArrayList
        lst.Items.Clear()

        If listing.Count > 0 Then
            Try
                For lIndex As Integer = 0 To listing.Count - 1
                    lst.Items.Add(listing.Keys(lIndex))
                    If listing.ItemByIndex(lIndex) Then
                        lst.SetSelected(lst.Items.Count - 1, True)
                    End If
                Next
            Catch e As Exception
                Logger.Dbg("Error retrieving " & lArgName & " settings: " & e.Message)
            End Try
        Else
            LoadListDefaults(lst)
        End If
    End Sub

    Private Sub frmSWSTAT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Windows.Forms.Keys.F1 Then
            ShowHelp(pHelpLocation)
        End If
    End Sub

    Public Sub Initialize(Optional ByVal aTimeseriesGroup As atcData.atcTimeseriesGroup = Nothing, _
                          Optional ByVal aBasicAttributes As Generic.List(Of String) = Nothing, _
                          Optional ByVal aNDayAttributes As Generic.List(Of String) = Nothing, _
                          Optional ByVal aTrendAttributes As Generic.List(Of String) = Nothing, _
                          Optional ByVal aShowForm As Boolean = True)
        If aTimeseriesGroup Is Nothing Then
            pDataGroup = New atcTimeseriesGroup
        Else
            pDataGroup = aTimeseriesGroup
        End If

        If aBasicAttributes Is Nothing Then
            pBasicAttributes = atcDataManager.DisplayAttributes
        Else
            pBasicAttributes = aBasicAttributes
        End If

        If aNDayAttributes Is Nothing Then
            pNDayAttributes = atcDataManager.DisplayAttributes
        Else
            pNDayAttributes = aNDayAttributes
        End If

        If aTrendAttributes Is Nothing Then
            pTrendAttributes = atcDataManager.DisplayAttributes
        Else
            pTrendAttributes = aTrendAttributes
        End If

        If aShowForm Then
            Dim DisplayPlugins As ICollection = atcDataManager.GetPlugins(GetType(atcDataDisplay))
            For Each lDisp As atcDataDisplay In DisplayPlugins
                Dim lMenuText As String = lDisp.Name
                If lMenuText <> "Analysis::USGS Surface Water Statistics (SWSTAT)::Integrated Frequency Analysis" Then
                    If lMenuText.StartsWith("Analysis::") Then lMenuText = lMenuText.Substring(10)
                    mnuAnalysis.MenuItems.Add(lMenuText, New EventHandler(AddressOf mnuAnalysis_Click))
                End If
            Next
        End If

        If pDataGroup.Count = 0 Then 'ask user to specify some timeseries
            pDataGroup = atcDataManager.UserSelectData("Select Data for Integrated Frequency Analysis", _
                                                       pDataGroup, Nothing, True, True, Me.Icon)
        End If

        If pDataGroup.Count > 0 Then
            PopulateForm()
            If aShowForm Then Me.Show()
        Else 'user declined to specify timeseries
            Me.Close()
        End If

    End Sub

    Public Sub Initialize(ByVal aTimeseriesGroup As atcData.atcTimeseriesGroup, _
                          ByVal attributes As atcDataAttributes)

        'Optional ByVal aBasicAttributes As Generic.List(Of String) = Nothing, _
        'Optional ByVal aNDayAttributes As Generic.List(Of String) = Nothing, _
        'Optional ByVal aTrendAttributes As Generic.List(Of String) = Nothing, _
        'Optional ByVal aShowForm As Boolean = True

        If aTimeseriesGroup Is Nothing Then
            pDataGroup = New atcTimeseriesGroup
        Else
            pDataGroup = aTimeseriesGroup
        End If

        pAttributes = attributes

        'If aNDayAttributes Is Nothing Then
        '    pNDayAttributes = atcDataManager.DisplayAttributes
        'Else
        '    pNDayAttributes = aNDayAttributes
        'End If

        'If aTrendAttributes Is Nothing Then
        '    pTrendAttributes = atcDataManager.DisplayAttributes
        'Else
        '    pTrendAttributes = aTrendAttributes
        'End If

        'If aShowForm Then
        '    Dim DisplayPlugins As ICollection = atcDataManager.GetPlugins(GetType(atcDataDisplay))
        '    For Each lDisp As atcDataDisplay In DisplayPlugins
        '        Dim lMenuText As String = lDisp.Name
        '        If lMenuText <> "Analysis::USGS Surface Water Statistics (SWSTAT)::Integrated Frequency Analysis" Then
        '            If lMenuText.StartsWith("Analysis::") Then lMenuText = lMenuText.Substring(10)
        '            mnuAnalysis.MenuItems.Add(lMenuText, New EventHandler(AddressOf mnuAnalysis_Click))
        '        End If
        '    Next
        'End If

        'If pDataGroup.Count = 0 Then 'ask user to specify some timeseries
        '    pDataGroup = atcDataManager.UserSelectData("Select Data for Integrated Frequency Analysis", _
        '                                               pDataGroup, Nothing, True, True, Me.Icon)
        'End If
        'PopulateForm()

        pBatch = True
        Dim loperation As String = attributes.GetValue("Operation", "")
        If loperation.ToLower = "globalsetparm" Then
            pSetGlobal = True
            btnDoFrequencyGrid.Text = "Set Global Parameters"
            Me.Text &= " -Batch Run Global Default Parameter Setup"

        Else
            pSetGlobal = False
            btnDoFrequencyGrid.Text = "Set Group Parameters"
            Dim lGroupname As String = attributes.GetValue("group", "")
            Me.Text &= " -Batch Run Group (" & lGroupname & ") Parameter Setup"
        End If
        btnNDay.Visible = False
        btnDisplayTrend.Visible = False
        btnDisplayBasic.Visible = False
        btnDoFrequencyGraph.Visible = False
        gbTextOutput.Visible = True

        PopulateForm(attributes)
        Me.Show()
    End Sub

    Public Property DateFormat() As atcDateFormat
        Get
            Return pDateFormat
        End Get
        Set(ByVal newValue As atcDateFormat)
            pDateFormat = newValue
        End Set
    End Property

    Private Sub mnuAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnalysis.Click
        atcDataManager.ShowDisplay(sender.Text, pDataGroup, Me.Icon)
    End Sub

    Private Sub pDataGroup_Added(ByVal aAdded As atcCollection) Handles pDataGroup.Added
        If Me.Visible Then RepopulateForm()
        'TODO: could efficiently insert newly added item(s)
    End Sub

    Private Sub pDataGroup_Removed(ByVal aRemoved As atcCollection) Handles pDataGroup.Removed
        If Me.Visible Then RepopulateForm()
        'TODO: could efficiently remove by serial number
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        pDataGroup = Nothing
    End Sub

    Private Sub mnuFileSelectData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSelectData.Click
        atcDataManager.UserSelectData("Select Data for Integrated Frequency Analysis", _
                                      pDataGroup, Nothing, False, True, Me.Icon)
    End Sub

    Private Sub SeasonsYearsToForm()
        If cboStartMonth.Items.Count > 0 Then
            cboStartMonth.SelectedIndex = pYearStartMonth - 1
            cboEndMonth.SelectedIndex = pYearEndMonth - 1
            If pYearStartDay > 0 Then txtStartDay.Text = pYearStartDay Else txtStartDay.Text = ""
            If pYearEndDay > 0 Then txtEndDay.Text = pYearEndDay Else txtEndDay.Text = ""
            If pFirstYear > 0 Then txtOmitBeforeYear.Text = pFirstYear Else txtOmitBeforeYear.Text = ""
            If pLastYear > 0 Then txtOmitAfterYear.Text = pLastYear Else txtOmitAfterYear.Text = ""
            If pFirstYear > 0 OrElse pLastYear > 0 Then
                ShowCustomYears(True)
            End If
        End If
    End Sub

    Private Function SeasonsYearsFromFormBatch() As String
        pYearStartMonth = cboStartMonth.SelectedIndex + 1
        pYearEndMonth = cboEndMonth.SelectedIndex + 1
        If IsNumeric(txtStartDay.Text) Then
            pYearStartDay = Math.Min(CInt(txtStartDay.Text), DayMon(1901, pYearStartMonth))
            txtStartDay.Text = pYearStartDay
        Else
            pYearStartDay = 0
        End If
        If IsNumeric(txtEndDay.Text) Then
            pYearEndDay = Math.Min(CInt(txtEndDay.Text), DayMon(1901, pYearEndMonth))
            txtEndDay.Text = pYearEndDay
        Else
            pYearEndDay = 0
        End If
        If IsNumeric(txtOmitBeforeYear.Text) Then
            pFirstYear = CInt(txtOmitBeforeYear.Text)
        Else
            pFirstYear = 0
        End If
        If IsNumeric(txtOmitAfterYear.Text) Then
            pLastYear = CInt(txtOmitAfterYear.Text)
        Else
            pLastYear = 0
        End If
        Dim lMsg As String = SaveSettingsBatch()
        Return lMsg
    End Function

    Private Sub SeasonsYearsFromForm()
        pYearStartMonth = cboStartMonth.SelectedIndex + 1
        pYearEndMonth = cboEndMonth.SelectedIndex + 1
        If IsNumeric(txtStartDay.Text) Then
            pYearStartDay = Math.Min(CInt(txtStartDay.Text), DayMon(1901, pYearStartMonth))
            txtStartDay.Text = pYearStartDay
        Else
            pYearStartDay = 0
        End If
        If IsNumeric(txtEndDay.Text) Then
            pYearEndDay = Math.Min(CInt(txtEndDay.Text), DayMon(1901, pYearEndMonth))
            txtEndDay.Text = pYearEndDay
        Else
            pYearEndDay = 0
        End If
        If IsNumeric(txtOmitBeforeYear.Text) Then
            pFirstYear = CInt(txtOmitBeforeYear.Text)
        Else
            pFirstYear = 0
        End If
        If IsNumeric(txtOmitAfterYear.Text) Then
            pLastYear = CInt(txtOmitAfterYear.Text)
        Else
            pLastYear = 0
        End If
        SaveSettings()
    End Sub

    Private Sub ShowCustomYears(ByVal aShowCustom As Boolean)
        'cboYears.Visible = Not aShowCustom
        txtOmitBeforeYear.Enabled = aShowCustom
        txtOmitAfterYear.Enabled = aShowCustom
        lblDataStart.Enabled = aShowCustom
        lblDataEnd.Enabled = aShowCustom
        lblOmitBefore.Enabled = aShowCustom
        lblOmitAfter.Enabled = aShowCustom
    End Sub

    'Return all selected items, or if none are selected then all items
    Private Function ListToArray(ByVal aList As Windows.Forms.ListBox) As Double()
        Dim lArray() As Double
        Dim lCollection As New ArrayList
        If aList.SelectedItems.Count > 0 Then
            For lIndex As Integer = 0 To aList.SelectedItems.Count - 1
                If IsNumeric(aList.SelectedItems(lIndex)) Then
                    lCollection.Add(CDbl(aList.SelectedItems(lIndex)))
                End If
            Next
        Else
            For lIndex As Integer = 0 To aList.Items.Count - 1
                If IsNumeric(aList.Items(lIndex)) Then
                    lCollection.Add(CDbl(aList.Items(lIndex)))
                End If
            Next
        End If
        ReDim lArray(lCollection.Count - 1)
        For lIndex As Integer = 0 To lCollection.Count - 1
            lArray(lIndex) = lCollection.Item(lIndex)
        Next
        Return lArray
    End Function

    Private Function SelectedData() As atcTimeseriesGroup
        Dim lDataGroupB As New atcTimeseriesGroup
        Dim lTsB As atcTimeseries
        SeasonsYearsFromForm()

        For Each lTs As atcTimeseries In pDataGroup
            If lTs.Attributes.GetValue("Time Unit") = atcTimeUnit.TUYear Then
                lTsB = lTs
            Else
                If pFirstYear > 0 AndAlso pLastYear > 0 Then
                    lTsB = SubsetByDateBoundary(lTs, pYearStartMonth, pYearStartDay, Nothing, pFirstYear, pLastYear, pYearEndMonth, pYearEndDay)
                Else
                    lTsB = lTs
                End If

                Dim lSeasons As New atcSeasonsYearSubset(pYearStartMonth, pYearStartDay, pYearEndMonth, pYearEndDay)
                lSeasons.SeasonSelected(0) = True
                lTsB = lSeasons.SplitBySelected(lTsB, Nothing).ItemByIndex(1)
                lTsB.Attributes.SetValue("ID", lTs.OriginalParent.Attributes.GetValue("ID"))
            End If
            lDataGroupB.Add(lTsB)
        Next

        Return lDataGroupB
    End Function

    Private Sub btnDisplayBasic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayBasic.Click
        Dim lList As New atcList.atcListForm

        With lList
            .Text = "Basic Statistics"
            .Initialize(SelectedData(), pBasicAttributes, False, , )
            .Width = 600
            .SwapRowsColumns = True
            .Icon = Me.Icon
        End With

        'Code section is to print out Text format of Basic Statistics, leave to remind how formatting is working to get 
        '     at the precise formatting in a SWSTAT format table
        '
        'Dim lselectedData As atcDataGroup = SelectedData()
        'Dim lfrmReport As New frmTextReport
        'lfrmReport.Title = "Basic Flow Statistics"

        'lfrmReport.ReportBody = "  DATA-                                                     NUMBER      NON-ZERO" & vbCrLf
        'lfrmReport.ReportBody &= "   SET                                        STANDARD   OF DATA VALUES RETURNS" & vbCrLf
        'lfrmReport.ReportBody &= " NUMBER    MINIMUM     MAXIMUM        MEAN   DEVIATION     USED  UNUSED CODE  NO." & vbCrLf
        'lfrmReport.ReportBody &= " ------ ---------- ----------- ----------- -----------  ------- ------- ---- ---" & vbCrLf

        'Dim lTemp As Double = 0.0
        'Dim lTSstats As New ArrayList()
        'If lselectedData.Count > 0 Then
        '    For Each aTS As atcTimeseries In lselectedData

        '        lTSstats = TSStats(aTS)

        '        lfrmReport.ReportBody &= CStr(aTS.Attributes.GetValue("ID")).PadLeft(6)
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(0), , 3, 6, False).PadLeft(13) 'min
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(1), , 3, 6, False).PadLeft(12) 'max
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(2), , 3, 6, False).PadLeft(12) 'mean
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(3), , 3, 6, False).PadLeft(12) 'lstdev
        '        lfrmReport.ReportBody &= CStr(lTSstats(4)).PadLeft(8) 'used
        '        lfrmReport.ReportBody &= CStr(lTSstats(5)).PadLeft(8) 'unused
        '        lfrmReport.ReportBody &= vbCrLf

        '    Next
        'Else
        'Logger.Msg("Select at least one time series")
        'End If

        'lfrmReport.displayReport()

    End Sub

    'Private Function TSStats(ByVal aTS As atcTimeseries) As ArrayList

    '    Dim lmean As Double
    '    Dim lmin As Double
    '    Dim lmax As Double
    '    Dim lstdev As Double
    '    Dim lUsed As Integer
    '    Dim lTotalCount As Integer
    '    Dim lSum As Double
    '    Dim lUnused As Integer
    '    Dim lSS As Double

    '    Dim lusedVals As New ArrayList()
    '    Dim lStats As New ArrayList()

    '    lmin = Double.MaxValue
    '    lmax = Double.MinValue
    '    For Each lVal As Double In aTS.Values
    '        lTotalCount += 1
    '        If lVal > 0 Then
    '            lUsed += 1
    '            lSum += lVal
    '            lusedVals.Add(lVal)
    '            If lVal > lmax Then
    '                lmax = lVal
    '            End If
    '            If lVal < lmin Then
    '                lmin = lVal
    '            End If
    '        End If
    '    Next

    '    lmean = lSum / lUsed
    '    lUnused = lTotalCount - lUsed

    '    For Each lVal As Double In lusedVals
    '        lSS += (lVal - lmean) ^ 2
    '    Next

    '    lstdev = Math.Sqrt(lSS / lUsed)

    '    lStats.Add(lmin)
    '    lStats.Add(lmax)
    '    lStats.Add(lmean)
    '    lStats.Add(lstdev)
    '    lStats.Add(lUsed)
    '    lStats.Add(lUnused)

    '    Return lStats

    'End Function

    Private Sub btnNDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNDay.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim lSelectedData As atcTimeseriesGroup = SelectedData()
        If lSelectedData.Count > 0 Then
            If lstNday.SelectedIndices.Count > 0 Then
                Dim lRankedAnnual As atcTimeseriesGroup = _
                   clsIDFPlugin.ComputeRankedAnnualTimeseries(aTimeseriesGroup:=lSelectedData, _
                                                                 aNDay:=ListToArray(lstNday), aHighFlag:=radioHigh.Checked, _
                                                                 aFirstYear:=pFirstYear, aLastYear:=pLastYear, _
                                                                 aBoundaryMonth:=pYearStartMonth, aBoundaryDay:=pYearStartDay, _
                                                                 aEndMonth:=pYearEndMonth, aEndDay:=pYearEndDay)
                If lRankedAnnual.Count > 0 Then
                    For Each lTS As atcTimeseries In lRankedAnnual
                        lTS.Attributes.SetValue("Units", "Common")
                    Next

                    Dim lList As New atcList.atcListForm
                    With lList
                        With .DateFormat
                            .IncludeDays = False
                            .IncludeHours = False
                            .IncludeMinutes = False
                            .IncludeMonths = False
                        End With
                        .Text = "N-Day " & HighOrLowString() & " Annual Time Series and Ranking"
                        .Initialize(lRankedAnnual.Clone, pNDayAttributes, True, , )
                        .DisplayValueAttributes = True
                        .Icon = Me.Icon
                    End With
                End If
            Else
                Logger.Msg("Select at least one number of days")
            End If
        Else
            Logger.Msg("Select at least one time series")
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnNdayAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayAdd.Click
        AddNday(txtNdayAdd.Text)
    End Sub

    Private Sub AddNday(ByVal aNday As String)
        If IsNumeric(aNday) Then
            Try
                Dim lIndex As Integer = 0
                Dim lNewValue As Double = CDbl(aNday)
                While lIndex < lstNday.Items.Count AndAlso CDbl(lstNday.Items(lIndex)) < lNewValue
                    lIndex += 1
                End While
                lstNday.Items.Insert(lIndex, aNday)
                lstNday.SetSelected(lIndex, True)
            Catch ex As Exception
                Logger.Dbg("Exception adding N-day '" & aNday & "': " & ex.Message)
            End Try
        Else
            Logger.Msg("Non-numeric value '" & aNday & "' could not be added to N-Day list")
        End If
    End Sub

    Private Sub SelectNday(ByVal aNday As String)
        If Not lstNday.Items.Contains(aNday) Then
            AddNday(aNday)
        End If
        For lNdayIndex As Integer = 0 To lstNday.Items.Count - 1
            If CInt(lstNday.Items(lNdayIndex)) = aNday Then
                lstNday.SelectedIndex = lNdayIndex
                Exit For
            End If
        Next
    End Sub

    Private Sub btnNdayRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayRemove.Click
        Dim lRemoveThese As New ArrayList
        Dim lIndex As Integer
        If lstNday.SelectedIndices.Count > 0 Then
            For lIndex = lstNday.SelectedIndices.Count - 1 To 0 Step -1
                lRemoveThese.Add(lstNday.SelectedIndices.Item(lIndex))
            Next
        Else
            For lIndex = lstNday.Items.Count - 1 To 0 Step -1
                If lstNday.Items(lIndex) = txtNdayAdd.Text Then
                    lRemoveThese.Add(lIndex)
                End If
            Next
        End If

        For Each lIndex In lRemoveThese
            lstNday.Items.RemoveAt(lIndex)
        Next
    End Sub

    Private Sub btnNdayDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayDefault.Click
        LoadListDefaults(lstNday)
    End Sub

    Private Sub LoadListDefaults(ByVal aList As Windows.Forms.ListBox)
        Dim lDefault() As Double = clsIDFPlugin.ListDefaultArray(aList.Tag)
        If Not lDefault Is Nothing Then
            aList.Items.Clear()
            For Each lNumber As Double In lDefault
                Dim lLabel As String = Format(lNumber, "0.####")
                aList.Items.Add(lLabel)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Calculate(aOperationName: = "n-day " & HighOrLowString() & " value", _
    ''' aReturnPeriods() = ListToArray(lstRecurrence))
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalculateBatch()
        If Not pSetGlobal AndAlso pDataGroup IsNot Nothing Then ClearAttributes()
        Dim lMsg As String = SeasonsYearsFromFormBatch()
        If Not String.IsNullOrEmpty(lMsg) Then
            Logger.Msg("Please address the following issues before proceeding:" & vbCrLf & vbCrLf & lMsg, MsgBoxStyle.Information, "Input Needs Correction")
            Exit Sub
        Else
            If pSetGlobal Then
                Logger.MsgCustomOwned("Parameters are set for Global Defaults.", "USGS Batch Processing", Me, New String() {"OK"})
                Me.Close()
            Else
                Dim lGroup As String = pAttributes.GetValue("Group", "")
                Logger.MsgCustomOwned("Group Parameters are set for " & lGroup, "USGS Batch Processing", Me, New String() {"OK"})
                Me.Close()
            End If
        End If
        RaiseEvent ParametersSet(pAttributes)
    End Sub

    Private Sub Calculate(ByVal aOperationName As String, ByVal aReturnPeriods() As Double)
        ClearAttributes()
        SeasonsYearsFromForm() 'setup all inputs from form
        Dim lCalculator As New atcTimeseriesNdayHighLow.atcTimeseriesNdayHighLow
        For Each lTs As atcTimeseries In pDataGroup
            lTs.Attributes.SetValueIfMissing("CalcEMA", True)
        Next
        Dim lArgs As New atcDataAttributes
        lArgs.SetValue("Timeseries", pDataGroup)
        lArgs.SetValue("NDay", ListToArray(lstNday))
        lArgs.SetValue("Return Period", aReturnPeriods)
        lArgs.SetValue("LogFlg", chkLog.Checked)
        If pYearStartMonth > 0 Then lArgs.SetValue("BoundaryMonth", pYearStartMonth)
        If pYearStartDay > 0 Then lArgs.SetValue("BoundaryDay", pYearStartDay)
        If pYearEndMonth > 0 Then lArgs.SetValue("EndMonth", pYearEndMonth)
        If pYearEndDay > 0 Then lArgs.SetValue("EndDay", pYearEndDay)
        If pFirstYear > 0 Then lArgs.SetValue("FirstYear", pFirstYear)
        If pLastYear > 0 Then lArgs.SetValue("LastYear", pLastYear)

        lCalculator.Open(aOperationName, lArgs)
        lCalculator.DataSets.Clear()
    End Sub

    Private Function SaveSettingsBatch() As String
        Dim lMsg As String = ""
        Dim lName As String = HighOrLowString()
        If pYearStartMonth = 0 OrElse pYearStartDay = 0 OrElse pYearEndMonth = 0 OrElse pYearEndDay = 0 Then
            lMsg &= "- Problem with start and/or end dates." & vbCrLf
        Else
            If pAttributes Is Nothing Then
                pAttributes = New atcDataAttributes()
            End If
            With pAttributes
                .SetValue(InputNames.StartMonth, pYearStartMonth)
                .SetValue(InputNames.StartDay, pYearStartDay)
                .SetValue(InputNames.EndMonth, pYearEndMonth)
                .SetValue(InputNames.EndDay, pYearEndDay)
                'For All years, txtOmitBeforeYear and txtOmitAfterYear are empty
                .SetValue(InputNames.IncludeYears, cboYears.SelectedItem.ToString())
                .SetValue(InputNames.StartYear, txtOmitBeforeYear.Text)
                .SetValue(InputNames.EndYear, txtOmitAfterYear.Text)
                .SetValue(InputNames.HighLow, lName)
                .SetValue(InputNames.Logarithmic, chkLog.Checked)
                .SetValue(InputNames.MultiNDayPlot, chkMultipleNDayPlots.Checked)
                .SetValue(InputNames.MultiStationPlot, chkMultipleStationPlots.Checked)
                If IO.Directory.Exists(txtOutputDir.Text) Then
                    .SetValue(InputNames.OutputDir, txtOutputDir.Text)
                Else
                    lMsg &= "- Need to specify a default output directory."
                End If
                If Not String.IsNullOrEmpty(txtOutputRootName.Text.Trim()) Then
                    .SetValue(InputNames.OutputPrefix, txtOutputRootName.Text.Trim())
                End If
            End With
        End If

        If Not pSetGlobal Then
            Dim lStationsInfo As atcCollection = InputNames.BuildStationsInfo(pDataGroup)
            pAttributes.SetValue(InputNames.StationsInfo, lStationsInfo)
        End If

        lMsg &= SaveListBatch(lstNday)
        lMsg &= SaveListBatch(lstRecurrence)

        Return lMsg
    End Function

    Private Sub SaveSettings()
        Dim lName As String = HighOrLowString()
        SaveSetting("atcFrequencyGrid", "StartMonth", lName, pYearStartMonth)
        SaveSetting("atcFrequencyGrid", "StartDay", lName, pYearStartDay)
        SaveSetting("atcFrequencyGrid", "EndMonth", lName, pYearEndMonth)
        SaveSetting("atcFrequencyGrid", "EndDay", lName, pYearEndDay)
        SaveSetting("atcFrequencyGrid", "Defaults", "HighOrLow", lName)
        SaveSetting("atcFrequencyGrid", "Defaults", "Logarithmic", chkLog.Checked.ToString)
        SaveList(lstNday)
        SaveList(lstRecurrence)
    End Sub

    Private Sub SaveList(ByVal lst As Windows.Forms.ListBox)
        SaveSetting("atcFrequencyGrid", "List." & lst.Tag, "dummy", "")
        DeleteSetting("atcFrequencyGrid", "List." & lst.Tag)
        For lIndex As Integer = 0 To lst.Items.Count - 1
            SaveSetting("atcFrequencyGrid", "List." & lst.Tag, lst.Items(lIndex), lst.SelectedIndices.Contains(lIndex))
        Next
    End Sub

    Private Function SaveListBatch(ByVal lst As Windows.Forms.ListBox) As String
        Dim lMsg As String = ""

        'Dim listing0() As Double = pAttributes.GetValue(lst.Tag, Nothing)
        'If listing0 IsNot Nothing Then
        '    ReDim listing0(0)
        '    listing0 = Nothing
        'End If
        Dim lCollection0 As atcCollection = pAttributes.GetValue(lst.Tag & "s", Nothing)
        If lCollection0 IsNot Nothing Then
            lCollection0.Clear()
            lCollection0 = Nothing
        End If
        pAttributes.RemoveByKey(lst.Tag)
        pAttributes.RemoveByKey(lst.Tag & "s")
        If lst.SelectedIndices.Count = 0 Then
            lMsg &= "- Need to select at least one " & lst.Tag & vbCrLf
            Return lMsg
        Else
            Dim listing(lst.Items.Count - 1) As Double
            Dim lCollection As New atcCollection()

            Dim lItemValue As Double
            For lIndex As Integer = 0 To lst.Items.Count - 1
                lItemValue = lst.Items(lIndex)
                listing(lIndex) = lItemValue
                lCollection.Add(lItemValue, lst.SelectedIndices.Contains(lIndex))
            Next
            pAttributes.SetValue(lst.Tag, listing)
            pAttributes.SetValue(lst.Tag & "s", lCollection)
        End If
        
        Return lMsg
    End Function

    Private Sub ClearAttributes()
        Dim lRemoveThese As New atcCollection
        For Each lData As atcDataSet In pDataGroup
            For Each lAttribute As atcDefinedValue In lData.Attributes
                If Not lAttribute.Arguments Is Nothing Then
                    If lAttribute.Arguments.ContainsAttribute("Nday") OrElse _
                       lAttribute.Arguments.ContainsAttribute("Return Period") Then
                        lRemoveThese.Add(lAttribute)
                    End If
                End If
            Next
            For Each lAttribute As atcDefinedValue In lRemoveThese
                lData.Attributes.Remove(lAttribute)
            Next
        Next
    End Sub

    Private Sub btnNdayAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayAll.Click
        For index As Integer = 0 To lstNday.Items.Count - 1
            lstNday.SetSelected(index, True)
        Next
    End Sub

    Private Sub btnNdayNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayNone.Click
        For index As Integer = 0 To lstNday.Items.Count - 1
            lstNday.SetSelected(index, False)
        Next
    End Sub

    Private Sub radioHigh_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioHigh.CheckedChanged
        GetDefaultYearStartEnd()
    End Sub

    Private Sub radioLow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioLow.CheckedChanged
        GetDefaultYearStartEnd()
    End Sub

    Private Sub GetDefaultYearStartEnd()
        If radioHigh.Checked Then
            pYearStartMonth = 10
            pYearStartDay = 1
            pYearEndMonth = 9
            pYearEndDay = 30
        Else
            pYearStartMonth = 4
            pYearStartDay = 1
            pYearEndMonth = 3
            pYearEndDay = 31
        End If

        Dim lName As String = HighOrLowString()
        pYearStartMonth = GetSetting("atcFrequencyGrid", "StartMonth", lName, pYearStartMonth)
        pYearStartDay = GetSetting("atcFrequencyGrid", "StartDay", lName, pYearStartDay)
        pYearEndMonth = GetSetting("atcFrequencyGrid", "EndMonth", lName, pYearEndMonth)
        pYearEndDay = GetSetting("atcFrequencyGrid", "EndDay", lName, pYearEndDay)
        SeasonsYearsToForm()
    End Sub

    Private Function HighOrLowString() As String
        If radioHigh.Checked Then
            Return "High"
        Else
            Return "Low"
        End If
    End Function

    Private Function MultipleNDayPlots() As Boolean
        If chkMultipleNDayPlots.Checked Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function MultipleStationPlots() As Boolean
        If chkMultipleStationPlots.Checked Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btnDisplayTrend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayTrend.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim lSelectedData As atcTimeseriesGroup = SelectedData()
        If lSelectedData.Count > 0 Then
            If lstNday.SelectedIndices.Count > 0 Then
                Dim lRankedAnnual As atcTimeseriesGroup = _
                   clsIDFPlugin.ComputeRankedAnnualTimeseries(aTimeseriesGroup:=lSelectedData, _
                                                                 aNDay:=ListToArray(lstNday), _
                                                                 aHighFlag:=radioHigh.Checked, _
                                                                 aFirstYear:=pFirstYear, _
                                                                 aLastYear:=pLastYear, _
                                                                 aBoundaryMonth:=pYearStartMonth, _
                                                                 aBoundaryDay:=pYearStartDay, _
                                                                 aEndMonth:=pYearEndMonth, _
                                                                 aEndDay:=pYearEndDay)
                If lRankedAnnual.Count > 0 Then
                    For Each lTS As atcTimeseries In lRankedAnnual
                        With lTS.Attributes
                            .SetValue("Original ID", lTS.OriginalParent.Attributes.GetValue("ID"))
                            .SetValue("From", pDateFormat.JDateToString(lTS.Dates.Value(1)))
                            .SetValue("To", pDateFormat.JDateToString(lTS.Dates.Value(lTS.numValues)))
                            .SetValue("Not Used", .GetValue("Count Missing"))
                        End With
                    Next
                    Dim lList As New atcList.atcListForm
                    With lList
                        With .DateFormat
                            .IncludeDays = False
                            .IncludeHours = False
                            .IncludeMinutes = False
                            .IncludeMonths = False
                        End With
                        .Text = "Trend of " & HighOrLowString() & " Annual Time Series and Statistics"
                        .Initialize(lRankedAnnual, pTrendAttributes, False)
                        .SwapRowsColumns = True
                        .Icon = Me.Icon
                    End With
                End If
            Else
                Logger.Msg("Select at least one number of days")
            End If
        Else
            Logger.Msg("Select at least one time series")
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnDoFrequencyGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoFrequencyGrid.Click
        If pBatch Then
            CalculateBatch() 'setting params for batch run
        Else
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Calculate("n-day " & HighOrLowString() & " value", ListToArray(lstRecurrence))

            Dim lFreqForm As New frmDisplayFrequencyGrid(aDataGroup:=pDataGroup, _
                                                         aHigh:=radioHigh.Checked, _
                                                         aNday:=ListToArray(lstNday), _
                                                         aReturns:=ListToArray(lstRecurrence))
            lFreqForm.SWSTATform = Me

            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub btnDoFrequencyGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoFrequencyGraph.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        DoFrequencyGraph()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Public Sub DoFrequencyGraph(Optional ByVal aDataGroup As atcData.atcTimeseriesGroup = Nothing)
        Calculate("n-day " & HighOrLowString() & " value", clsIDFPlugin.ListDefaultArray("Return Period"))
        Dim lGraphPlugin As New atcGraph.atcGraphPlugin
        Dim lGraphForm As atcGraph.atcGraphForm
        'Dim lSeparateGraphs As Boolean = False
        'Select Case pDataGroup.Count
        '    Case 0 : Return
        '    Case 1 : lSeparateGraphs = False
        '    Case Else
        '        lSeparateGraphs = (Logger.MsgCustomCheckbox("Create separate graphs or all on one graph?", _
        '                                                    pDataGroup.Count & " datasets selected", _
        '                                                    "Do not ask again", "BASINS", "SWSTAT", "SeparateFreqGraphs", _
        '                                                    "Separate", "One Graph") = "Separate")
        'End Select

        'Get station list
        Dim lStnList As New Generic.List(Of String)
        For Each lDataSet As atcTimeseries In pDataGroup
            If Not lStnList.Contains(lDataSet.Attributes.GetValue("STAID")) Then
                lStnList.Add(lDataSet.Attributes.GetValue("STAID"))
            End If
        Next
        'Get Nday list
        Dim lNDayList As New Generic.List(Of String)
        For Each lDataSet As atcTimeseries In pDataGroup
            For Each lAtt As atcData.atcDefinedValue In lDataSet.Attributes
                If lAtt.Definition.Name.ToLower.Contains("daytimeseries") Then
                    If Not lNDayList.Contains(lAtt.Definition.Name) Then
                        lNDayList.Add(lAtt.Definition.Name)
                    End If
                End If
            Next
        Next
        If MultipleNDayPlots() And MultipleStationPlots() Then
            For Each lStaId As String In lStnList
                For Each lNDayTimeseriesName As String In lNDayList
                    Dim lDataGroup As New atcData.atcTimeseriesGroup
                    For Each lDataset As atcTimeseries In pDataGroup
                        If lDataset.Attributes.GetValue("STAID") = lStaId Then
                            Dim lTs As atcTimeseries = lDataset.Attributes.GetValue(lNDayTimeseriesName)
                            If lTs IsNot Nothing Then
                                lDataGroup.Add(lTs)
                            End If
                        End If
                    Next
                    If lDataGroup.Count > 0 Then
                        lGraphForm = lGraphPlugin.Show(lDataGroup, "Frequency")
                        lGraphForm.Icon = Me.Icon
                    End If
                    lDataGroup.Clear()
                    lDataGroup = Nothing
                Next
            Next

            'For Each lDataSet As atcTimeseries In pDataGroup
            '    lGraphForm = lGraphPlugin.Show(New atcTimeseriesGroup(lDataSet), "Frequency")
            '    lGraphForm.Icon = Me.Icon
            'Next
        ElseIf MultipleNDayPlots() Then
            For Each lNDayTimeseriesName As String In lNDayList
                Dim lDataGroup As New atcData.atcTimeseriesGroup
                For Each lDataset As atcTimeseries In pDataGroup
                    Dim lTs As atcTimeseries = lDataset.Attributes.GetValue(lNDayTimeseriesName)
                    If lTs IsNot Nothing Then
                        lDataGroup.Add(lTs)
                    End If
                Next
                If lDataGroup IsNot Nothing AndAlso lDataGroup.Count > 0 Then
                    lGraphForm = lGraphPlugin.Show(lDataGroup, "Frequency")
                    lGraphForm.Icon = Me.Icon
                End If
                lDataGroup.Clear()
                lDataGroup = Nothing
            Next
        ElseIf MultipleStationPlots() Then
            Dim lDataGroup As atcData.atcTimeseriesGroup = Nothing
            For Each lStaId As String In lStnList
                lDataGroup = pDataGroup.FindData("STAID", lStaId)
                If lDataGroup IsNot Nothing Then
                    lGraphForm = lGraphPlugin.Show(lDataGroup, "Frequency")
                    lGraphForm.Icon = Me.Icon
                End If
                lDataGroup.Clear()
                lDataGroup = Nothing
            Next
        Else
            lGraphForm = lGraphPlugin.Show(pDataGroup, "Frequency")
            lGraphForm.Icon = Me.Icon
        End If

        lNDayList.Clear()
        lNDayList = Nothing
        lStnList.Clear()
        lStnList = Nothing
    End Sub

    Private Sub cboYears_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYears.SelectedIndexChanged
        Select Case cboYears.SelectedIndex
            Case 0 'All
                ShowCustomYears(False)
                txtOmitBeforeYear.Text = ""
                txtOmitAfterYear.Text = ""
            Case 1 'Common
                ShowCustomYears(False)
                If cboYears.Text.EndsWith(pNoDatesInCommon) Then
                    cboYears.SelectedIndex = 0
                Else
                    Dim lCurDate(5) As Integer
                    J2Date(pCommonStart, lCurDate)
                    txtOmitBeforeYear.Text = Format(lCurDate(0), "0000")
                    J2Date(pCommonEnd, lCurDate)
                    txtOmitAfterYear.Text = Format(lCurDate(0), "0000")
                End If
            Case 2 'Custom
                ShowCustomYears(True)
        End Select
    End Sub

    Private Sub btnRecurrenceAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceAdd.Click
        If IsNumeric(txtRecurrenceAdd.Text) Then
            Try
                Dim lIndex As Integer = 0
                Dim lNewValue As Double = CDbl(txtRecurrenceAdd.Text)
                While lIndex < lstRecurrence.Items.Count AndAlso CDbl(lstRecurrence.Items(lIndex)) < lNewValue
                    lIndex += 1
                End While
                lstRecurrence.Items.Insert(lIndex, txtRecurrenceAdd.Text)
                lstRecurrence.SetSelected(lIndex, True)
            Catch ex As Exception
                Logger.Dbg("Exception adding Recurrence '" & txtRecurrenceAdd.Text & "': " & ex.Message)
            End Try
        Else
            Logger.Msg("Type a return period to add in the blank, then press the add button again")
        End If
    End Sub

    Private Sub btnRecurrenceRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceRemove.Click
        Dim lRemoveThese As New ArrayList
        Dim lIndex As Integer
        If lstRecurrence.SelectedIndices.Count > 0 Then
            For lIndex = lstRecurrence.SelectedIndices.Count - 1 To 0 Step -1
                lRemoveThese.Add(lstRecurrence.SelectedIndices.Item(lIndex))
            Next
        Else
            For lIndex = lstRecurrence.Items.Count - 1 To 0 Step -1
                If lstRecurrence.Items(lIndex) = txtRecurrenceAdd.Text Then
                    lRemoveThese.Add(lIndex)
                End If
            Next
        End If

        For Each lIndex In lRemoveThese
            lstRecurrence.Items.RemoveAt(lIndex)
        Next

    End Sub

    Private Sub btnRecurrenceDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceDefault.Click
        LoadListDefaults(lstRecurrence)
    End Sub

    Private Sub btnRecurrenceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceAll.Click
        For index As Integer = 0 To lstRecurrence.Items.Count - 1
            lstRecurrence.SetSelected(index, True)
        Next
    End Sub

    Private Sub btnRecurrenceNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceNone.Click
        For index As Integer = 0 To lstRecurrence.Items.Count - 1
            lstRecurrence.SetSelected(index, False)
        Next
    End Sub

End Class
