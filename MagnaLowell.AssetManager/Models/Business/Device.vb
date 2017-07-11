Public Class SeDataProDevice
    Public Property Id As Integer
    Public Property Description As String
    Public Property DeviceName As String
End Class
Public Class SeDataProGroup
    Public Property Id As Integer
    Public Property DeviceId As Integer
    Public Property GroupName As String
    Public Property Description As String
    Public Property Active As Boolean
End Class