Imports atcData

Public Class atcDebugTimserPlugin
  Inherits atcDataDisplay

  Public Overrides ReadOnly Property Name() As String
    Get
      Return "Tools::DebugTimser"
    End Get
  End Property

  Public Overrides Function Show(ByVal aDataManager As atcDataManager, _
                   Optional ByVal aDataGroup As atcDataGroup = Nothing) As Object 'System.Windows.Forms.Form
    Dim lDataGroup As atcDataGroup = aDataGroup
    If lDataGroup Is Nothing Then lDataGroup = New atcDataGroup

    Dim lForm As New atcDebugTimserForm(aDataManager, lDataGroup)
    If Not (lDataGroup Is Nothing) AndAlso lDataGroup.Count > 0 Then
      lForm.Show()
      Return lForm
    Else 'No data to display, don't show or return the form
      lForm.Dispose()
      Return Nothing
    End If
  End Function

  Public Overrides Sub Initialize(ByVal aMapWin As MapWindow.Interfaces.IMapWin, _
                                  ByVal aParentHandle As Integer)
    aMapWin.Plugins.BroadcastMessage("atcDataPlugin loading atcDebugTimserPlugin")
  End Sub

  Public Overrides Sub Save(ByVal aDataManager As atcDataManager, _
                  ByVal aDataGroup As atcDataGroup, _
                  ByVal aFileName As String, _
                  ByVal ParamArray aOption() As String)
    Dim lForm As New atcDebugTimserForm(aDataManager, aDataGroup)
    With lForm
      .TreeAction(aOption)
      .Save(aFileName)
    End With
  End Sub

End Class
