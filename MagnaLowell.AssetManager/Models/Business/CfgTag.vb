Imports MagnaLowell.AssetManager

Public Class CfgTag
    Implements ICopy(Of CfgTag)

    Public Sub New()

    End Sub
    Public Sub New(tag As CfgTag)
        tag.CopyTo(Me)
    End Sub



    Public Property GroupName As String
    Public Property DeviceName As String

    Public Property TagId As Integer
    Public Property GroupId As Integer
    Public Property TagName As String
    Public Property Description As String
    Public Property HwTagName As String
    Public Property HwTagType As Integer
    Public Property HwDataType As Integer
    Public Property Elements As Integer
    Public Property StringLenth As Integer
    Public Property OptimizeReads As Boolean
    Public Property SimType As Integer
    Public Property TagRole As Integer
    Public Property RateChangeThreshold As Single
    Public Property Folder As String

    Public Sub CopyTo(item As CfgTag) Implements ICopy(Of CfgTag).CopyTo
        item.DeviceName = DeviceName
        item.GroupName = GroupName
        item.TagId = TagId
        item.GroupId = GroupId
        item.TagName = TagName
        item.Description = Description
        item.HwTagName = HwTagName
        item.HwTagType = HwTagType
        item.HwDataType = HwDataType
        item.Elements = Elements
        item.StringLenth = StringLenth
        item.OptimizeReads = OptimizeReads
        item.SimType = SimType
        item.TagRole = TagRole
        item.RateChangeThreshold = RateChangeThreshold
        item.Folder = Folder
    End Sub
End Class
