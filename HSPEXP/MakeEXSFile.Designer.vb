﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MakeEXSFile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUCIFilename = New System.Windows.Forms.TextBox
        Me.lblLatLeft = New System.Windows.Forms.Label
        Me.txtLat1 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblLat = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.lblLong1 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.lblLong2 = New System.Windows.Forms.Label
        Me.lblSimulationPeriod = New System.Windows.Forms.Label
        Me.lblStartDate = New System.Windows.Forms.Label
        Me.lblEndDate = New System.Windows.Forms.Label
        Me.lblNoOfSites = New System.Windows.Forms.Label
        Me.cmbNumberOfSites = New System.Windows.Forms.ComboBox
        Me.DTStartDate = New System.Windows.Forms.DateTimePicker
        Me.DTEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblReachNumber = New System.Windows.Forms.Label
        Me.txtReachNumber = New System.Windows.Forms.TextBox
        Me.txtSIMQ = New System.Windows.Forms.TextBox
        Me.lblSIMQ = New System.Windows.Forms.Label
        Me.lblLZSX = New System.Windows.Forms.Label
        Me.txtLZSX = New System.Windows.Forms.TextBox
        Me.lblUZSX = New System.Windows.Forms.Label
        Me.txtUZSX = New System.Windows.Forms.TextBox
        Me.lblSAET = New System.Windows.Forms.Label
        Me.txtSAET = New System.Windows.Forms.TextBox
        Me.lblPETX = New System.Windows.Forms.Label
        Me.txtPET = New System.Windows.Forms.TextBox
        Me.lblSUPY = New System.Windows.Forms.Label
        Me.txtSUPY = New System.Windows.Forms.TextBox
        Me.lblAGWO = New System.Windows.Forms.Label
        Me.txtAGWO = New System.Windows.Forms.TextBox
        Me.lblIFWO = New System.Windows.Forms.Label
        Me.txtIFWO = New System.Windows.Forms.TextBox
        Me.lblSURO = New System.Windows.Forms.Label
        Me.txtSURO = New System.Windows.Forms.TextBox
        Me.lblObsFlow = New System.Windows.Forms.Label
        Me.txtObsFlow = New System.Windows.Forms.TextBox
        Me.pLocations = New System.Windows.Forms.Panel
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblObsFlow2 = New System.Windows.Forms.Label
        Me.lblReachNumber2 = New System.Windows.Forms.Label
        Me.txtObsFlow2 = New System.Windows.Forms.TextBox
        Me.txtReachNumber2 = New System.Windows.Forms.TextBox
        Me.lblSURO2 = New System.Windows.Forms.Label
        Me.txtSIMQ2 = New System.Windows.Forms.TextBox
        Me.txtSURO2 = New System.Windows.Forms.TextBox
        Me.lblSIMQ2 = New System.Windows.Forms.Label
        Me.lblIFWO2 = New System.Windows.Forms.Label
        Me.txtLZSX2 = New System.Windows.Forms.TextBox
        Me.txtIFWO2 = New System.Windows.Forms.TextBox
        Me.lblLZSX2 = New System.Windows.Forms.Label
        Me.lblAGWO2 = New System.Windows.Forms.Label
        Me.txtUZSX2 = New System.Windows.Forms.TextBox
        Me.txtAGWO2 = New System.Windows.Forms.TextBox
        Me.lblUZSX2 = New System.Windows.Forms.Label
        Me.lblSUPY2 = New System.Windows.Forms.Label
        Me.txtSAET2 = New System.Windows.Forms.TextBox
        Me.txtSUPY2 = New System.Windows.Forms.TextBox
        Me.lblSAET2 = New System.Windows.Forms.Label
        Me.lblPETX2 = New System.Windows.Forms.Label
        Me.txtPETX2 = New System.Windows.Forms.TextBox
        Me.lblStormNumber = New System.Windows.Forms.Label
        Me.txtNumberOfStorms = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblStorm1 = New System.Windows.Forms.Label
        Me.lblStartDateStorm = New System.Windows.Forms.Label
        Me.DTPickerStartStorm1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTPickerStorm2 = New System.Windows.Forms.DateTimePicker
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar
        Me.lblArea1 = New System.Windows.Forms.Label
        Me.txtArea1 = New System.Windows.Forms.TextBox
        Me.lblAboutLatAndLong = New System.Windows.Forms.Label
        Me.lblSaveEXSAs = New System.Windows.Forms.Label
        Me.txtEXSFileName = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.pLocations.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prefix of the UCI File"
        '
        'txtUCIFilename
        '
        Me.txtUCIFilename.Location = New System.Drawing.Point(125, 18)
        Me.txtUCIFilename.MaxLength = 8
        Me.txtUCIFilename.Name = "txtUCIFilename"
        Me.txtUCIFilename.Size = New System.Drawing.Size(79, 20)
        Me.txtUCIFilename.TabIndex = 1
        '
        'lblLatLeft
        '
        Me.lblLatLeft.AutoSize = True
        Me.lblLatLeft.Location = New System.Drawing.Point(16, 97)
        Me.lblLatLeft.Name = "lblLatLeft"
        Me.lblLatLeft.Size = New System.Drawing.Size(51, 13)
        Me.lblLatLeft.TabIndex = 2
        Me.lblLatLeft.Text = "Latitude1"
        '
        'txtLat1
        '
        Me.txtLat1.Location = New System.Drawing.Point(78, 94)
        Me.txtLat1.Name = "txtLat1"
        Me.txtLat1.Size = New System.Drawing.Size(66, 20)
        Me.txtLat1.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(207, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 20)
        Me.TextBox1.TabIndex = 5
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.Location = New System.Drawing.Point(150, 94)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(51, 13)
        Me.lblLat.TabIndex = 4
        Me.lblLat.Text = "Latitude2"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(335, 91)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(65, 20)
        Me.TextBox2.TabIndex = 7
        '
        'lblLong1
        '
        Me.lblLong1.AutoSize = True
        Me.lblLong1.Location = New System.Drawing.Point(278, 94)
        Me.lblLong1.Name = "lblLong1"
        Me.lblLong1.Size = New System.Drawing.Size(60, 13)
        Me.lblLong1.TabIndex = 6
        Me.lblLong1.Text = "Longitude1"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(469, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(65, 20)
        Me.TextBox3.TabIndex = 9
        '
        'lblLong2
        '
        Me.lblLong2.AutoSize = True
        Me.lblLong2.Location = New System.Drawing.Point(406, 94)
        Me.lblLong2.Name = "lblLong2"
        Me.lblLong2.Size = New System.Drawing.Size(60, 13)
        Me.lblLong2.TabIndex = 8
        Me.lblLong2.Text = "Longitude2"
        '
        'lblSimulationPeriod
        '
        Me.lblSimulationPeriod.AutoSize = True
        Me.lblSimulationPeriod.Location = New System.Drawing.Point(16, 135)
        Me.lblSimulationPeriod.Name = "lblSimulationPeriod"
        Me.lblSimulationPeriod.Size = New System.Drawing.Size(393, 13)
        Me.lblSimulationPeriod.TabIndex = 10
        Me.lblSimulationPeriod.Text = "You may specify a different period of analysis than the simulation period of UCI " & _
            "file."
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(16, 167)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(55, 13)
        Me.lblStartDate.TabIndex = 11
        Me.lblStartDate.Text = "Start Date"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(316, 167)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(52, 13)
        Me.lblEndDate.TabIndex = 13
        Me.lblEndDate.Text = "End Date"
        '
        'lblNoOfSites
        '
        Me.lblNoOfSites.AutoSize = True
        Me.lblNoOfSites.Location = New System.Drawing.Point(16, 200)
        Me.lblNoOfSites.Name = "lblNoOfSites"
        Me.lblNoOfSites.Size = New System.Drawing.Size(62, 13)
        Me.lblNoOfSites.TabIndex = 15
        Me.lblNoOfSites.Text = "No. of Sites"
        '
        'cmbNumberOfSites
        '
        Me.cmbNumberOfSites.AllowDrop = True
        Me.cmbNumberOfSites.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5"})
        Me.cmbNumberOfSites.FormatString = "N0"
        Me.cmbNumberOfSites.FormattingEnabled = True
        Me.cmbNumberOfSites.Location = New System.Drawing.Point(88, 200)
        Me.cmbNumberOfSites.Name = "cmbNumberOfSites"
        Me.cmbNumberOfSites.Size = New System.Drawing.Size(121, 21)
        Me.cmbNumberOfSites.TabIndex = 16
        '
        'DTStartDate
        '
        Me.DTStartDate.Location = New System.Drawing.Point(88, 164)
        Me.DTStartDate.Name = "DTStartDate"
        Me.DTStartDate.Size = New System.Drawing.Size(200, 20)
        Me.DTStartDate.TabIndex = 23
        '
        'DTEndDate
        '
        Me.DTEndDate.Location = New System.Drawing.Point(375, 164)
        Me.DTEndDate.Name = "DTEndDate"
        Me.DTEndDate.Size = New System.Drawing.Size(200, 20)
        Me.DTEndDate.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Provide the DSN of following Constituents for each Location."
        '
        'lblReachNumber
        '
        Me.lblReachNumber.AutoSize = True
        Me.lblReachNumber.Location = New System.Drawing.Point(108, 9)
        Me.lblReachNumber.Name = "lblReachNumber"
        Me.lblReachNumber.Size = New System.Drawing.Size(130, 13)
        Me.lblReachNumber.TabIndex = 26
        Me.lblReachNumber.Text = "Reach Number in UCI File"
        '
        'txtReachNumber
        '
        Me.txtReachNumber.Location = New System.Drawing.Point(120, 25)
        Me.txtReachNumber.MaxLength = 4
        Me.txtReachNumber.Name = "txtReachNumber"
        Me.txtReachNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtReachNumber.TabIndex = 27
        '
        'txtSIMQ
        '
        Me.txtSIMQ.Location = New System.Drawing.Point(243, 25)
        Me.txtSIMQ.MaxLength = 4
        Me.txtSIMQ.Name = "txtSIMQ"
        Me.txtSIMQ.Size = New System.Drawing.Size(49, 20)
        Me.txtSIMQ.TabIndex = 28
        '
        'lblSIMQ
        '
        Me.lblSIMQ.AutoSize = True
        Me.lblSIMQ.Location = New System.Drawing.Point(251, 9)
        Me.lblSIMQ.Name = "lblSIMQ"
        Me.lblSIMQ.Size = New System.Drawing.Size(34, 13)
        Me.lblSIMQ.TabIndex = 29
        Me.lblSIMQ.Text = "SIMQ"
        '
        'lblLZSX
        '
        Me.lblLZSX.AutoSize = True
        Me.lblLZSX.Location = New System.Drawing.Point(788, 9)
        Me.lblLZSX.Name = "lblLZSX"
        Me.lblLZSX.Size = New System.Drawing.Size(34, 13)
        Me.lblLZSX.TabIndex = 31
        Me.lblLZSX.Text = "LZSX"
        '
        'txtLZSX
        '
        Me.txtLZSX.Location = New System.Drawing.Point(782, 25)
        Me.txtLZSX.MaxLength = 4
        Me.txtLZSX.Name = "txtLZSX"
        Me.txtLZSX.Size = New System.Drawing.Size(49, 20)
        Me.txtLZSX.TabIndex = 30
        '
        'lblUZSX
        '
        Me.lblUZSX.AutoSize = True
        Me.lblUZSX.Location = New System.Drawing.Point(735, 9)
        Me.lblUZSX.Name = "lblUZSX"
        Me.lblUZSX.Size = New System.Drawing.Size(36, 13)
        Me.lblUZSX.TabIndex = 33
        Me.lblUZSX.Text = "UZSX"
        '
        'txtUZSX
        '
        Me.txtUZSX.Location = New System.Drawing.Point(727, 25)
        Me.txtUZSX.MaxLength = 4
        Me.txtUZSX.Name = "txtUZSX"
        Me.txtUZSX.Size = New System.Drawing.Size(49, 20)
        Me.txtUZSX.TabIndex = 32
        '
        'lblSAET
        '
        Me.lblSAET.AutoSize = True
        Me.lblSAET.Location = New System.Drawing.Point(679, 9)
        Me.lblSAET.Name = "lblSAET"
        Me.lblSAET.Size = New System.Drawing.Size(35, 13)
        Me.lblSAET.TabIndex = 35
        Me.lblSAET.Text = "SAET"
        '
        'txtSAET
        '
        Me.txtSAET.Location = New System.Drawing.Point(672, 25)
        Me.txtSAET.MaxLength = 4
        Me.txtSAET.Name = "txtSAET"
        Me.txtSAET.Size = New System.Drawing.Size(49, 20)
        Me.txtSAET.TabIndex = 34
        '
        'lblPETX
        '
        Me.lblPETX.AutoSize = True
        Me.lblPETX.Location = New System.Drawing.Point(623, 9)
        Me.lblPETX.Name = "lblPETX"
        Me.lblPETX.Size = New System.Drawing.Size(35, 13)
        Me.lblPETX.TabIndex = 37
        Me.lblPETX.Text = "PETX"
        '
        'txtPET
        '
        Me.txtPET.Location = New System.Drawing.Point(617, 25)
        Me.txtPET.MaxLength = 4
        Me.txtPET.Name = "txtPET"
        Me.txtPET.Size = New System.Drawing.Size(49, 20)
        Me.txtPET.TabIndex = 36
        '
        'lblSUPY
        '
        Me.lblSUPY.AutoSize = True
        Me.lblSUPY.Location = New System.Drawing.Point(569, 9)
        Me.lblSUPY.Name = "lblSUPY"
        Me.lblSUPY.Size = New System.Drawing.Size(36, 13)
        Me.lblSUPY.TabIndex = 39
        Me.lblSUPY.Text = "SUPY"
        '
        'txtSUPY
        '
        Me.txtSUPY.Location = New System.Drawing.Point(562, 25)
        Me.txtSUPY.MaxLength = 4
        Me.txtSUPY.Name = "txtSUPY"
        Me.txtSUPY.Size = New System.Drawing.Size(49, 20)
        Me.txtSUPY.TabIndex = 38
        '
        'lblAGWO
        '
        Me.lblAGWO.AutoSize = True
        Me.lblAGWO.Location = New System.Drawing.Point(514, 9)
        Me.lblAGWO.Name = "lblAGWO"
        Me.lblAGWO.Size = New System.Drawing.Size(41, 13)
        Me.lblAGWO.TabIndex = 41
        Me.lblAGWO.Text = "AGWO"
        '
        'txtAGWO
        '
        Me.txtAGWO.Location = New System.Drawing.Point(507, 25)
        Me.txtAGWO.MaxLength = 4
        Me.txtAGWO.Name = "txtAGWO"
        Me.txtAGWO.Size = New System.Drawing.Size(49, 20)
        Me.txtAGWO.TabIndex = 40
        '
        'lblIFWO
        '
        Me.lblIFWO.AutoSize = True
        Me.lblIFWO.Location = New System.Drawing.Point(460, 9)
        Me.lblIFWO.Name = "lblIFWO"
        Me.lblIFWO.Size = New System.Drawing.Size(35, 13)
        Me.lblIFWO.TabIndex = 43
        Me.lblIFWO.Text = "IFWO"
        '
        'txtIFWO
        '
        Me.txtIFWO.Location = New System.Drawing.Point(453, 25)
        Me.txtIFWO.MaxLength = 4
        Me.txtIFWO.Name = "txtIFWO"
        Me.txtIFWO.Size = New System.Drawing.Size(49, 20)
        Me.txtIFWO.TabIndex = 42
        '
        'lblSURO
        '
        Me.lblSURO.AutoSize = True
        Me.lblSURO.Location = New System.Drawing.Point(405, 9)
        Me.lblSURO.Name = "lblSURO"
        Me.lblSURO.Size = New System.Drawing.Size(38, 13)
        Me.lblSURO.TabIndex = 45
        Me.lblSURO.Text = "SURO"
        '
        'txtSURO
        '
        Me.txtSURO.Location = New System.Drawing.Point(398, 25)
        Me.txtSURO.MaxLength = 4
        Me.txtSURO.Name = "txtSURO"
        Me.txtSURO.Size = New System.Drawing.Size(49, 20)
        Me.txtSURO.TabIndex = 44
        '
        'lblObsFlow
        '
        Me.lblObsFlow.AutoSize = True
        Me.lblObsFlow.Location = New System.Drawing.Point(298, 9)
        Me.lblObsFlow.Name = "lblObsFlow"
        Me.lblObsFlow.Size = New System.Drawing.Size(101, 13)
        Me.lblObsFlow.TabIndex = 47
        Me.lblObsFlow.Text = "Observed Flow (cfs)"
        '
        'txtObsFlow
        '
        Me.txtObsFlow.Location = New System.Drawing.Point(320, 25)
        Me.txtObsFlow.MaxLength = 4
        Me.txtObsFlow.Name = "txtObsFlow"
        Me.txtObsFlow.Size = New System.Drawing.Size(49, 20)
        Me.txtObsFlow.TabIndex = 46
        '
        'pLocations
        '
        Me.pLocations.Controls.Add(Me.Label16)
        Me.pLocations.Controls.Add(Me.lblObsFlow2)
        Me.pLocations.Controls.Add(Me.lblReachNumber2)
        Me.pLocations.Controls.Add(Me.txtObsFlow2)
        Me.pLocations.Controls.Add(Me.txtReachNumber2)
        Me.pLocations.Controls.Add(Me.lblSURO2)
        Me.pLocations.Controls.Add(Me.txtSIMQ2)
        Me.pLocations.Controls.Add(Me.txtSURO2)
        Me.pLocations.Controls.Add(Me.lblSIMQ2)
        Me.pLocations.Controls.Add(Me.lblIFWO2)
        Me.pLocations.Controls.Add(Me.txtLZSX2)
        Me.pLocations.Controls.Add(Me.txtIFWO2)
        Me.pLocations.Controls.Add(Me.lblLZSX2)
        Me.pLocations.Controls.Add(Me.lblAGWO2)
        Me.pLocations.Controls.Add(Me.txtUZSX2)
        Me.pLocations.Controls.Add(Me.txtAGWO2)
        Me.pLocations.Controls.Add(Me.lblUZSX2)
        Me.pLocations.Controls.Add(Me.lblSUPY2)
        Me.pLocations.Controls.Add(Me.txtSAET2)
        Me.pLocations.Controls.Add(Me.txtSUPY2)
        Me.pLocations.Controls.Add(Me.lblSAET2)
        Me.pLocations.Controls.Add(Me.lblPETX2)
        Me.pLocations.Controls.Add(Me.txtPETX2)
        Me.pLocations.Controls.Add(Me.Label15)
        Me.pLocations.Controls.Add(Me.VScrollBar1)
        Me.pLocations.Controls.Add(Me.lblObsFlow)
        Me.pLocations.Controls.Add(Me.lblReachNumber)
        Me.pLocations.Controls.Add(Me.txtObsFlow)
        Me.pLocations.Controls.Add(Me.txtReachNumber)
        Me.pLocations.Controls.Add(Me.lblSURO)
        Me.pLocations.Controls.Add(Me.txtSIMQ)
        Me.pLocations.Controls.Add(Me.txtSURO)
        Me.pLocations.Controls.Add(Me.lblSIMQ)
        Me.pLocations.Controls.Add(Me.lblIFWO)
        Me.pLocations.Controls.Add(Me.txtLZSX)
        Me.pLocations.Controls.Add(Me.txtIFWO)
        Me.pLocations.Controls.Add(Me.lblLZSX)
        Me.pLocations.Controls.Add(Me.lblAGWO)
        Me.pLocations.Controls.Add(Me.txtUZSX)
        Me.pLocations.Controls.Add(Me.txtAGWO)
        Me.pLocations.Controls.Add(Me.lblUZSX)
        Me.pLocations.Controls.Add(Me.lblSUPY)
        Me.pLocations.Controls.Add(Me.txtSAET)
        Me.pLocations.Controls.Add(Me.txtSUPY)
        Me.pLocations.Controls.Add(Me.lblSAET)
        Me.pLocations.Controls.Add(Me.lblPETX)
        Me.pLocations.Controls.Add(Me.txtPET)
        Me.pLocations.Location = New System.Drawing.Point(19, 264)
        Me.pLocations.Name = "pLocations"
        Me.pLocations.Size = New System.Drawing.Size(858, 122)
        Me.pLocations.TabIndex = 48
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(841, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 122)
        Me.VScrollBar1.TabIndex = 48
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "First Location"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Second Location"
        Me.Label16.Visible = False
        '
        'lblObsFlow2
        '
        Me.lblObsFlow2.AutoSize = True
        Me.lblObsFlow2.Location = New System.Drawing.Point(298, 61)
        Me.lblObsFlow2.Name = "lblObsFlow2"
        Me.lblObsFlow2.Size = New System.Drawing.Size(101, 13)
        Me.lblObsFlow2.TabIndex = 71
        Me.lblObsFlow2.Text = "Observed Flow (cfs)"
        Me.lblObsFlow2.Visible = False
        '
        'lblReachNumber2
        '
        Me.lblReachNumber2.AutoSize = True
        Me.lblReachNumber2.Location = New System.Drawing.Point(108, 61)
        Me.lblReachNumber2.Name = "lblReachNumber2"
        Me.lblReachNumber2.Size = New System.Drawing.Size(130, 13)
        Me.lblReachNumber2.TabIndex = 50
        Me.lblReachNumber2.Text = "Reach Number in UCI File"
        Me.lblReachNumber2.Visible = False
        '
        'txtObsFlow2
        '
        Me.txtObsFlow2.Location = New System.Drawing.Point(320, 77)
        Me.txtObsFlow2.MaxLength = 4
        Me.txtObsFlow2.Name = "txtObsFlow2"
        Me.txtObsFlow2.Size = New System.Drawing.Size(49, 20)
        Me.txtObsFlow2.TabIndex = 70
        Me.txtObsFlow2.Visible = False
        '
        'txtReachNumber2
        '
        Me.txtReachNumber2.Location = New System.Drawing.Point(120, 77)
        Me.txtReachNumber2.MaxLength = 4
        Me.txtReachNumber2.Name = "txtReachNumber2"
        Me.txtReachNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtReachNumber2.TabIndex = 51
        Me.txtReachNumber2.Visible = False
        '
        'lblSURO2
        '
        Me.lblSURO2.AutoSize = True
        Me.lblSURO2.Location = New System.Drawing.Point(405, 61)
        Me.lblSURO2.Name = "lblSURO2"
        Me.lblSURO2.Size = New System.Drawing.Size(38, 13)
        Me.lblSURO2.TabIndex = 69
        Me.lblSURO2.Text = "SURO"
        Me.lblSURO2.Visible = False
        '
        'txtSIMQ2
        '
        Me.txtSIMQ2.Location = New System.Drawing.Point(243, 77)
        Me.txtSIMQ2.MaxLength = 4
        Me.txtSIMQ2.Name = "txtSIMQ2"
        Me.txtSIMQ2.Size = New System.Drawing.Size(49, 20)
        Me.txtSIMQ2.TabIndex = 52
        Me.txtSIMQ2.Visible = False
        '
        'txtSURO2
        '
        Me.txtSURO2.Location = New System.Drawing.Point(398, 77)
        Me.txtSURO2.MaxLength = 4
        Me.txtSURO2.Name = "txtSURO2"
        Me.txtSURO2.Size = New System.Drawing.Size(49, 20)
        Me.txtSURO2.TabIndex = 68
        '
        'lblSIMQ2
        '
        Me.lblSIMQ2.AutoSize = True
        Me.lblSIMQ2.Location = New System.Drawing.Point(251, 61)
        Me.lblSIMQ2.Name = "lblSIMQ2"
        Me.lblSIMQ2.Size = New System.Drawing.Size(34, 13)
        Me.lblSIMQ2.TabIndex = 53
        Me.lblSIMQ2.Text = "SIMQ"
        Me.lblSIMQ2.Visible = False
        '
        'lblIFWO2
        '
        Me.lblIFWO2.AutoSize = True
        Me.lblIFWO2.Location = New System.Drawing.Point(460, 61)
        Me.lblIFWO2.Name = "lblIFWO2"
        Me.lblIFWO2.Size = New System.Drawing.Size(35, 13)
        Me.lblIFWO2.TabIndex = 67
        Me.lblIFWO2.Text = "IFWO"
        '
        'txtLZSX2
        '
        Me.txtLZSX2.Location = New System.Drawing.Point(782, 77)
        Me.txtLZSX2.MaxLength = 4
        Me.txtLZSX2.Name = "txtLZSX2"
        Me.txtLZSX2.Size = New System.Drawing.Size(49, 20)
        Me.txtLZSX2.TabIndex = 54
        '
        'txtIFWO2
        '
        Me.txtIFWO2.Location = New System.Drawing.Point(453, 77)
        Me.txtIFWO2.MaxLength = 4
        Me.txtIFWO2.Name = "txtIFWO2"
        Me.txtIFWO2.Size = New System.Drawing.Size(49, 20)
        Me.txtIFWO2.TabIndex = 66
        '
        'lblLZSX2
        '
        Me.lblLZSX2.AutoSize = True
        Me.lblLZSX2.Location = New System.Drawing.Point(788, 61)
        Me.lblLZSX2.Name = "lblLZSX2"
        Me.lblLZSX2.Size = New System.Drawing.Size(34, 13)
        Me.lblLZSX2.TabIndex = 55
        Me.lblLZSX2.Text = "LZSX"
        '
        'lblAGWO2
        '
        Me.lblAGWO2.AutoSize = True
        Me.lblAGWO2.Location = New System.Drawing.Point(514, 61)
        Me.lblAGWO2.Name = "lblAGWO2"
        Me.lblAGWO2.Size = New System.Drawing.Size(41, 13)
        Me.lblAGWO2.TabIndex = 65
        Me.lblAGWO2.Text = "AGWO"
        '
        'txtUZSX2
        '
        Me.txtUZSX2.Location = New System.Drawing.Point(727, 77)
        Me.txtUZSX2.MaxLength = 4
        Me.txtUZSX2.Name = "txtUZSX2"
        Me.txtUZSX2.Size = New System.Drawing.Size(49, 20)
        Me.txtUZSX2.TabIndex = 56
        '
        'txtAGWO2
        '
        Me.txtAGWO2.Location = New System.Drawing.Point(507, 77)
        Me.txtAGWO2.MaxLength = 4
        Me.txtAGWO2.Name = "txtAGWO2"
        Me.txtAGWO2.Size = New System.Drawing.Size(49, 20)
        Me.txtAGWO2.TabIndex = 64
        '
        'lblUZSX2
        '
        Me.lblUZSX2.AutoSize = True
        Me.lblUZSX2.Location = New System.Drawing.Point(735, 61)
        Me.lblUZSX2.Name = "lblUZSX2"
        Me.lblUZSX2.Size = New System.Drawing.Size(36, 13)
        Me.lblUZSX2.TabIndex = 57
        Me.lblUZSX2.Text = "UZSX"
        '
        'lblSUPY2
        '
        Me.lblSUPY2.AutoSize = True
        Me.lblSUPY2.Location = New System.Drawing.Point(569, 61)
        Me.lblSUPY2.Name = "lblSUPY2"
        Me.lblSUPY2.Size = New System.Drawing.Size(36, 13)
        Me.lblSUPY2.TabIndex = 63
        Me.lblSUPY2.Text = "SUPY"
        '
        'txtSAET2
        '
        Me.txtSAET2.Location = New System.Drawing.Point(672, 77)
        Me.txtSAET2.MaxLength = 4
        Me.txtSAET2.Name = "txtSAET2"
        Me.txtSAET2.Size = New System.Drawing.Size(49, 20)
        Me.txtSAET2.TabIndex = 58
        '
        'txtSUPY2
        '
        Me.txtSUPY2.Location = New System.Drawing.Point(562, 77)
        Me.txtSUPY2.MaxLength = 4
        Me.txtSUPY2.Name = "txtSUPY2"
        Me.txtSUPY2.Size = New System.Drawing.Size(49, 20)
        Me.txtSUPY2.TabIndex = 62
        '
        'lblSAET2
        '
        Me.lblSAET2.AutoSize = True
        Me.lblSAET2.Location = New System.Drawing.Point(679, 61)
        Me.lblSAET2.Name = "lblSAET2"
        Me.lblSAET2.Size = New System.Drawing.Size(35, 13)
        Me.lblSAET2.TabIndex = 59
        Me.lblSAET2.Text = "SAET"
        '
        'lblPETX2
        '
        Me.lblPETX2.AutoSize = True
        Me.lblPETX2.Location = New System.Drawing.Point(623, 61)
        Me.lblPETX2.Name = "lblPETX2"
        Me.lblPETX2.Size = New System.Drawing.Size(35, 13)
        Me.lblPETX2.TabIndex = 61
        Me.lblPETX2.Text = "PETX"
        '
        'txtPETX2
        '
        Me.txtPETX2.Location = New System.Drawing.Point(617, 77)
        Me.txtPETX2.MaxLength = 4
        Me.txtPETX2.Name = "txtPETX2"
        Me.txtPETX2.Size = New System.Drawing.Size(49, 20)
        Me.txtPETX2.TabIndex = 60
        '
        'lblStormNumber
        '
        Me.lblStormNumber.AutoSize = True
        Me.lblStormNumber.Location = New System.Drawing.Point(16, 407)
        Me.lblStormNumber.Name = "lblStormNumber"
        Me.lblStormNumber.Size = New System.Drawing.Size(71, 13)
        Me.lblStormNumber.TabIndex = 49
        Me.lblStormNumber.Text = "No. of Storms"
        '
        'txtNumberOfStorms
        '
        Me.txtNumberOfStorms.Location = New System.Drawing.Point(94, 407)
        Me.txtNumberOfStorms.Name = "txtNumberOfStorms"
        Me.txtNumberOfStorms.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfStorms.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VScrollBar2)
        Me.Panel1.Controls.Add(Me.DTPickerStorm2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DTPickerStartStorm1)
        Me.Panel1.Controls.Add(Me.lblStartDateStorm)
        Me.Panel1.Controls.Add(Me.lblStorm1)
        Me.Panel1.Location = New System.Drawing.Point(19, 446)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 100)
        Me.Panel1.TabIndex = 51
        '
        'lblStorm1
        '
        Me.lblStorm1.AutoSize = True
        Me.lblStorm1.Location = New System.Drawing.Point(3, 39)
        Me.lblStorm1.Name = "lblStorm1"
        Me.lblStorm1.Size = New System.Drawing.Size(43, 13)
        Me.lblStorm1.TabIndex = 0
        Me.lblStorm1.Text = "Storm 1"
        '
        'lblStartDateStorm
        '
        Me.lblStartDateStorm.AutoSize = True
        Me.lblStartDateStorm.Location = New System.Drawing.Point(108, 13)
        Me.lblStartDateStorm.Name = "lblStartDateStorm"
        Me.lblStartDateStorm.Size = New System.Drawing.Size(55, 13)
        Me.lblStartDateStorm.TabIndex = 12
        Me.lblStartDateStorm.Text = "Start Date"
        '
        'DTPickerStartStorm1
        '
        Me.DTPickerStartStorm1.Location = New System.Drawing.Point(69, 33)
        Me.DTPickerStartStorm1.Name = "DTPickerStartStorm1"
        Me.DTPickerStartStorm1.Size = New System.Drawing.Size(200, 20)
        Me.DTPickerStartStorm1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(405, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "End Date"
        '
        'DTPickerStorm2
        '
        Me.DTPickerStorm2.Location = New System.Drawing.Point(355, 33)
        Me.DTPickerStorm2.Name = "DTPickerStorm2"
        Me.DTPickerStorm2.Size = New System.Drawing.Size(200, 20)
        Me.DTPickerStorm2.TabIndex = 15
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Location = New System.Drawing.Point(591, 0)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(20, 100)
        Me.VScrollBar2.TabIndex = 16
        '
        'lblArea1
        '
        Me.lblArea1.AutoSize = True
        Me.lblArea1.Location = New System.Drawing.Point(19, 566)
        Me.lblArea1.Name = "lblArea1"
        Me.lblArea1.Size = New System.Drawing.Size(236, 13)
        Me.lblArea1.TabIndex = 52
        Me.lblArea1.Text = "Drainage Area to the calibration location in acres"
        '
        'txtArea1
        '
        Me.txtArea1.Location = New System.Drawing.Point(19, 588)
        Me.txtArea1.Name = "txtArea1"
        Me.txtArea1.Size = New System.Drawing.Size(100, 20)
        Me.txtArea1.TabIndex = 53
        '
        'lblAboutLatAndLong
        '
        Me.lblAboutLatAndLong.AutoSize = True
        Me.lblAboutLatAndLong.Location = New System.Drawing.Point(16, 65)
        Me.lblAboutLatAndLong.Name = "lblAboutLatAndLong"
        Me.lblAboutLatAndLong.Size = New System.Drawing.Size(306, 13)
        Me.lblAboutLatAndLong.TabIndex = 54
        Me.lblAboutLatAndLong.Text = "Specify the Latitudes and Longitudes of the Project Watershed."
        '
        'lblSaveEXSAs
        '
        Me.lblSaveEXSAs.AutoSize = True
        Me.lblSaveEXSAs.Location = New System.Drawing.Point(234, 21)
        Me.lblSaveEXSAs.Name = "lblSaveEXSAs"
        Me.lblSaveEXSAs.Size = New System.Drawing.Size(92, 13)
        Me.lblSaveEXSAs.TabIndex = 55
        Me.lblSaveEXSAs.Text = "Save EXS File as "
        '
        'txtEXSFileName
        '
        Me.txtEXSFileName.Location = New System.Drawing.Point(339, 18)
        Me.txtEXSFileName.Name = "txtEXSFileName"
        Me.txtEXSFileName.Size = New System.Drawing.Size(100, 20)
        Me.txtEXSFileName.TabIndex = 56
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(789, 625)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 57
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'MakeEXSFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 676)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtEXSFileName)
        Me.Controls.Add(Me.lblSaveEXSAs)
        Me.Controls.Add(Me.lblAboutLatAndLong)
        Me.Controls.Add(Me.txtArea1)
        Me.Controls.Add(Me.lblArea1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNumberOfStorms)
        Me.Controls.Add(Me.lblStormNumber)
        Me.Controls.Add(Me.pLocations)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTEndDate)
        Me.Controls.Add(Me.DTStartDate)
        Me.Controls.Add(Me.cmbNumberOfSites)
        Me.Controls.Add(Me.lblNoOfSites)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblSimulationPeriod)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblLong2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblLong1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblLat)
        Me.Controls.Add(Me.txtLat1)
        Me.Controls.Add(Me.lblLatLeft)
        Me.Controls.Add(Me.txtUCIFilename)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MakeEXSFile"
        Me.Text = "Form to make an Basins Specifications (EXS) file for the HSPF project."
        Me.pLocations.ResumeLayout(False)
        Me.pLocations.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUCIFilename As System.Windows.Forms.TextBox
    Friend WithEvents lblLatLeft As System.Windows.Forms.Label
    Friend WithEvents txtLat1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblLat As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblLong1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblLong2 As System.Windows.Forms.Label
    Friend WithEvents lblSimulationPeriod As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblNoOfSites As System.Windows.Forms.Label
    Friend WithEvents cmbNumberOfSites As System.Windows.Forms.ComboBox
    Friend WithEvents DTStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblReachNumber As System.Windows.Forms.Label
    Friend WithEvents txtReachNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtSIMQ As System.Windows.Forms.TextBox
    Friend WithEvents lblSIMQ As System.Windows.Forms.Label
    Friend WithEvents lblLZSX As System.Windows.Forms.Label
    Friend WithEvents txtLZSX As System.Windows.Forms.TextBox
    Friend WithEvents lblUZSX As System.Windows.Forms.Label
    Friend WithEvents txtUZSX As System.Windows.Forms.TextBox
    Friend WithEvents lblSAET As System.Windows.Forms.Label
    Friend WithEvents txtSAET As System.Windows.Forms.TextBox
    Friend WithEvents lblPETX As System.Windows.Forms.Label
    Friend WithEvents txtPET As System.Windows.Forms.TextBox
    Friend WithEvents lblSUPY As System.Windows.Forms.Label
    Friend WithEvents txtSUPY As System.Windows.Forms.TextBox
    Friend WithEvents lblAGWO As System.Windows.Forms.Label
    Friend WithEvents txtAGWO As System.Windows.Forms.TextBox
    Friend WithEvents lblIFWO As System.Windows.Forms.Label
    Friend WithEvents txtIFWO As System.Windows.Forms.TextBox
    Friend WithEvents lblSURO As System.Windows.Forms.Label
    Friend WithEvents txtSURO As System.Windows.Forms.TextBox
    Friend WithEvents lblObsFlow As System.Windows.Forms.Label
    Friend WithEvents txtObsFlow As System.Windows.Forms.TextBox
    Friend WithEvents pLocations As System.Windows.Forms.Panel
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblObsFlow2 As System.Windows.Forms.Label
    Friend WithEvents lblReachNumber2 As System.Windows.Forms.Label
    Friend WithEvents txtObsFlow2 As System.Windows.Forms.TextBox
    Friend WithEvents txtReachNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents lblSURO2 As System.Windows.Forms.Label
    Friend WithEvents txtSIMQ2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSURO2 As System.Windows.Forms.TextBox
    Friend WithEvents lblSIMQ2 As System.Windows.Forms.Label
    Friend WithEvents lblIFWO2 As System.Windows.Forms.Label
    Friend WithEvents txtLZSX2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIFWO2 As System.Windows.Forms.TextBox
    Friend WithEvents lblLZSX2 As System.Windows.Forms.Label
    Friend WithEvents lblAGWO2 As System.Windows.Forms.Label
    Friend WithEvents txtUZSX2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAGWO2 As System.Windows.Forms.TextBox
    Friend WithEvents lblUZSX2 As System.Windows.Forms.Label
    Friend WithEvents lblSUPY2 As System.Windows.Forms.Label
    Friend WithEvents txtSAET2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSUPY2 As System.Windows.Forms.TextBox
    Friend WithEvents lblSAET2 As System.Windows.Forms.Label
    Friend WithEvents lblPETX2 As System.Windows.Forms.Label
    Friend WithEvents txtPETX2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblStormNumber As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfStorms As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblStorm1 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar2 As System.Windows.Forms.VScrollBar
    Friend WithEvents DTPickerStorm2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPickerStartStorm1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStartDateStorm As System.Windows.Forms.Label
    Friend WithEvents lblArea1 As System.Windows.Forms.Label
    Friend WithEvents txtArea1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAboutLatAndLong As System.Windows.Forms.Label
    Friend WithEvents lblSaveEXSAs As System.Windows.Forms.Label
    Friend WithEvents txtEXSFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class