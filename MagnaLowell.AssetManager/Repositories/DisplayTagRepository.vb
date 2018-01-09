Imports System.Data.Entity
Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager

Public Class DisplayTagRepository
    Inherits ReadonlyRepository(Of DisplayCfgTag, CfgTagRecord)

    Private ReadOnly _tagRepo As TagRepository
    Private ReadOnly _stationRepo As StationRepository
    Private ReadOnly _dbfactory As DbFactory

    Public Sub New(tagRepo As TagRepository, dbfactory As DbFactory, groupRepo As GroupRepository, deviceRepo As DeviceRepository, stationRepo As StationRepository)
        MyBase.New(dbfactory)
        _tagRepo = tagRepo
        _stationRepo = stationRepo
    End Sub

    Public Overrides Function GetAll() As IEnumerable(Of DisplayCfgTag)
        Dim tags = _tagRepo.GetAll()
        Dim stations = _stationRepo.GetStationsWithTags()
        Return tags.Select(Function(x) New DisplayCfgTag(x, stations.Where(Function(y) y.StatusTagId.Value = x.TagId)))
    End Function

    Public Overrides Async Function GetAllAsync() As Task(Of IEnumerable(Of DisplayCfgTag))
        Dim tags = _tagRepo.GetAllAsync()
        Dim stations = _stationRepo.GetStationsWithTags()
        Return (Await tags).Select(Function(x) New DisplayCfgTag(x, stations.Where(Function(y) y.StatusTagId.Value = x.TagId)))
    End Function
End Class
