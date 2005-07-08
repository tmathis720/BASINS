Public Class atcDataSet

  Private Shared pNextSerial As Integer = 0 'Next serial number to be assigned

  Private pSerial As Integer 'Serial number of this object

  Private pAttributes As atcDataAttributes

  'Attributes associated with the whole Data (location, constituent, etc.)
  Public ReadOnly Property Attributes() As atcDataAttributes
    Get
      Return pAttributes
    End Get
  End Property

  Public Overridable Sub Clear()
    pAttributes = New atcDataAttributes(Me)
  End Sub

  Public Sub New()
    pSerial = System.Threading.Interlocked.Increment(pNextSerial) 'Safely increment pNextSerial
    Clear()
  End Sub

  'Unique serial number assigned when object is created
  Public ReadOnly Property Serial() As Integer
    Get
      Return pSerial
    End Get
  End Property

End Class
