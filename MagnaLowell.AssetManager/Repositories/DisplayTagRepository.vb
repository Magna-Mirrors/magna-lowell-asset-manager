Imports System.Data.Entity
Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager

Public Class DisplayTagRepository
    Implements IReadonlyRepository(Of DisplayCfgTag)

    Private ReadOnly _tagRepo As TagRepository
    Private ReadOnly _stationRepo As StationRepository
    Private ReadOnly _deviceRepo As DeviceRepository
    Private ReadOnly _groupRepo As GroupRepository
    Private ReadOnly _dbfactory As DbFactory
    Public Sub New(tagRepo As TagRepository, dbfactory As DbFactory, groupRepo As GroupRepository, deviceRepo As DeviceRepository, stationRepo As StationRepository)
        _tagRepo = tagRepo
        _dbfactory = dbfactory
        _deviceRepo = deviceRepo
        _groupRepo = groupRepo
        _stationRepo = stationRepo
    End Sub
    Public Function GetAll() As IEnumerable(Of DisplayCfgTag) Implements IReadonlyRepository(Of DisplayCfgTag).GetAll
        Dim tags = _tagRepo.GetAll()
        Dim stations = _stationRepo.GetAll()
        Dim groups = _groupRepo.GetAll()
        Dim devices = _deviceRepo.GetAll()
        Return SetExtraProperties(tags, stations, groups, devices)
    End Function

    Public Async Function GetAllAsync() As Task(Of IEnumerable(Of DisplayCfgTag)) Implements IReadonlyRepository(Of DisplayCfgTag).GetAllAsync
        Dim tagsT = _tagRepo.GetAllAsync()
        Dim stationsT = _stationRepo.GetAllAsync()
        Dim groupsT = _groupRepo.GetAllAsync()
        Dim devicesT = _deviceRepo.GetAllAsync()
        Dim result = SetExtraProperties(Await tagsT, Await stationsT, Await groupsT, Await devicesT)
        Return result
    End Function

    Private Function SetExtraProperties(tags As IEnumerable(Of CfgTag), stations As IEnumerable(Of Station), groups As IEnumerable(Of SeDataProGroup), devices As IEnumerable(Of SeDataProDevice)) As List(Of DisplayCfgTag)
        Dim tagResults As New List(Of DisplayCfgTag)
        For Each tag In tags
            Dim sta = stations.FirstOrDefault(Function(x) x.StatusTagId IsNot Nothing AndAlso CInt(x.StatusTagId) = tag.TagId)
            Dim grp = groups.SingleOrDefault(Function(x) x.Id = tag.GroupId)
            If grp IsNot Nothing Then
                Dim device = devices.SingleOrDefault(Function(x) x.Id = grp.DeviceId)
                If device IsNot Nothing Then
                    tagResults.Add(New DisplayCfgTag(tag, sta) With {.DeviceName = device.DeviceName, .GroupName = grp.GroupName})
                End If
            End If
        Next
        Return tagResults
    End Function
End Class
