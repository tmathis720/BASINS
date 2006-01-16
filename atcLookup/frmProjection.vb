Imports atcUtility
Imports MapWinUtility

Public Class frmProjection
  Inherits System.Windows.Forms.Form
  Dim pProjectFileName As String

#Region " Windows Form Designer generated code "

  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

    'Add any initialization after the InitializeComponent() call

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
  Friend WithEvents cmdOK As System.Windows.Forms.Button
  Friend WithEvents tbxProjection As System.Windows.Forms.TextBox
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProjection))
    Me.cmdOK = New System.Windows.Forms.Button
    Me.tbxProjection = New System.Windows.Forms.TextBox
    Me.SuspendLayout()
    '
    'cmdOK
    '
    Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdOK.Location = New System.Drawing.Point(128, 176)
    Me.cmdOK.Name = "cmdOK"
    Me.cmdOK.Size = New System.Drawing.Size(96, 24)
    Me.cmdOK.TabIndex = 0
    Me.cmdOK.Text = "&OK"
    '
    'tbxProjection
    '
    Me.tbxProjection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tbxProjection.Location = New System.Drawing.Point(16, 8)
    Me.tbxProjection.Multiline = True
    Me.tbxProjection.Name = "tbxProjection"
    Me.tbxProjection.ReadOnly = True
    Me.tbxProjection.Size = New System.Drawing.Size(320, 152)
    Me.tbxProjection.TabIndex = 1
    Me.tbxProjection.Text = "tbxProjection"
    '
    'frmProjection
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
    Me.ClientSize = New System.Drawing.Size(354, 210)
    Me.Controls.Add(Me.tbxProjection)
    Me.Controls.Add(Me.cmdOK)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmProjection"
    Me.Text = "Projection Parameters"
    Me.ResumeLayout(False)

  End Sub

#End Region

  Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
    Me.Close()
  End Sub

  Private Sub frmProjection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim ProjectionFile As String
    ProjectionFile = PathNameOnly(pProjectFileName) & "\prj.proj"
    If FileExists(ProjectionFile) Then
      tbxProjection.Text = WholeFileString(ProjectionFile)
    Else
      tbxProjection.Text = "Projection Properties are not available"
    End If
  End Sub

  Public Sub InitializeUI(ByVal projectfilename As String)
    pProjectFileName = projectfilename
  End Sub
End Class
