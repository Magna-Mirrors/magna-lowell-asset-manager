Imports MagnaLowell.AssetManager

Public Class DeviceRepository
    Inherits ReadonlyRepository(Of SeDataProDevice, DeviceRecord)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overrides Function MapOutModel(inRecord As DeviceRecord, outModel As SeDataProDevice) As SeDataProDevice
        outModel.Description = inRecord.Description
        outModel.DeviceName = inRecord.DeviceName
        outModel.Id = inRecord.DeviceId
        Return outModel
    End Function
End Class

Public Class GroupRepository
    Inherits ReadonlyRepository(Of SeDataProGroup, GroupRecord)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub

    Protected Overrides Function MapOutModel(inRecord As GroupRecord, outModel As SeDataProGroup) As SeDataProGroup
        outModel.Id = inRecord.GroupId
        outModel.DeviceId = inRecord.DeviceId
        outModel.GroupName = inRecord.GroupName
        outModel.Description = inRecord.Description
        outModel.Active = inRecord.Active
        Return outModel
    End Function
End Class
