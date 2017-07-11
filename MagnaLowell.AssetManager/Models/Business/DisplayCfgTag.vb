Imports MagnaLowell.AssetManager

Public Class DisplayCfgTag
    Inherits CfgTag
    Implements ICopy(Of DisplayCfgTag)


    Public Sub New(tag As CfgTag, usingStation As Station)
        MyBase.New(tag)
        UsedByStation = usingStation
    End Sub
    Public ReadOnly Property DisplayName As String
        Get
            Return $"{Me.TagId}: {DeviceName}/{GroupName}/{Me.TagName}"
        End Get
    End Property


    Public ReadOnly Property InUse As Boolean
        Get
            Return UsedByStation IsNot Nothing
        End Get
    End Property
    Public ReadOnly Property DisplayUsedByStation As String
        Get
            Return If(Not InUse, String.Empty, $"{UsedByStation.Id}: {UsedByStation.Name}")
        End Get
    End Property
    Public ReadOnly Property UsedByStation As Station


    Public Overloads Sub CopyTo(item As DisplayCfgTag) Implements ICopy(Of DisplayCfgTag).CopyTo
        MyBase.CopyTo(item)
    End Sub
End Class
