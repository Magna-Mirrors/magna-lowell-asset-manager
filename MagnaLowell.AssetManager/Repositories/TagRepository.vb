Imports System.Data.Entity
Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager

Public Class TagRepository
    Inherits ReadonlyRepository(Of CfgTag, CfgTagRecord)

    Private Const OnChangeTagType As Integer = 6
    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overrides Function MapOutModel(inRecord As CfgTagRecord, outModel As CfgTag) As CfgTag
        outModel.TagId = inRecord.TagId
        If inRecord.GroupId = 0 Then
            Throw New Exception()
        End If
        outModel.GroupId = inRecord.GroupId
        outModel.TagName = inRecord.TagName
        outModel.Description = inRecord.Description
        outModel.HwTagName = inRecord.HwTagName
        outModel.HwTagType = inRecord.HwTagType
        outModel.HwDataType = inRecord.HwDataType
        outModel.Elements = inRecord.Elements
        outModel.StringLenth = inRecord.StringLenth
        outModel.OptimizeReads = inRecord.OptimizeReads
        outModel.SimType = inRecord.SimType
        outModel.TagRole = inRecord.TagRole
        outModel.RateChangeThreshold = inRecord.RateChangeThreshold
        outModel.Folder = inRecord.Folder
        Return outModel
    End Function



    Public Overrides Function GetAll() As IEnumerable(Of CfgTag)
        Dim results = Retrieve(Function(x) x.TagRole = OnChangeTagType).ToList()
        SetExtraProperties(results)
        Return results
    End Function

    Public Overrides Async Function GetAllAsync() As Task(Of IEnumerable(Of CfgTag))
        Dim results = (Await RetrieveAsync(Function(x) x.TagRole = OnChangeTagType)).ToList()
        Await SetExtraPropertiesAsync(results)
        Return results
    End Function

    Private Async Function SetExtraPropertiesAsync(tags As List(Of CfgTag)) As Task
        Using ctx = DbFactory.GetDbInstance
            Dim groups = Await ctx.GroupRecords.ToListAsync()
            Dim devices = Await ctx.DeviceRecords.ToListAsync()
            Dim tagstoRemove As New List(Of CfgTag)

            For Each tag In tags
                Dim group = groups.SingleOrDefault(Function(x) x.GroupId = tag.GroupId)
                If group IsNot Nothing Then
                    Dim device = devices.SingleOrDefault(Function(x) x.DeviceId = group.DeviceId)
                    If device IsNot Nothing Then
                        tag.DeviceName = device.DeviceName
                        tag.GroupName = group.GroupName
                    Else
                        'device not found
                        tagstoRemove.Add(tag)
                    End If
                Else
                    'group not found
                    tagstoRemove.Add(tag)
                End If
            Next
        End Using
    End Function
    Private Sub SetExtraProperties(tags As List(Of CfgTag))
        Using ctx = DbFactory.GetDbInstance
            Dim groups = ctx.GroupRecords.ToList()
            Dim devices = ctx.DeviceRecords.ToList()

            Dim tagstoRemove As New List(Of CfgTag)

            For Each tag In tags
                Dim group = groups.SingleOrDefault(Function(x) x.GroupId = tag.GroupId)
                If group IsNot Nothing Then
                    Dim device = devices.SingleOrDefault(Function(x) x.DeviceId = group.DeviceId)
                    If device IsNot Nothing Then
                        tag.DeviceName = device.DeviceName
                        tag.GroupName = group.GroupName
                    Else
                        'device not found
                        tagstoRemove.Add(tag)
                    End If
                Else
                    'group not found
                    tagstoRemove.Add(tag)
                End If
            Next
        End Using
    End Sub
End Class

