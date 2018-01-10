Imports System.Threading.Tasks
Imports MagnaLowell.AssetManager

Public Class LineViewModelRepository
    Implements IEditRepository(Of EditLinesViewModel)

    Private ReadOnly _linerepo As LineRepository
    Private ReadOnly _partresRepo As PartResultRepository
    Private ReadOnly _stationRepo As StationRepository
    Private ReadOnly _ergoRepo As ErgonomicRepository
    Private ReadOnly _tagRepo As DisplayTagRepository
    Private ReadOnly _groupRepo As GroupRepository
    Private ReadOnly _deviceRepo As DeviceRepository
    Private ReadOnly _statusrepo As StatusEnumRepository
    Private ReadOnly _customerRepo As CustomerRepository

    Public Sub New(linerepo As LineRepository,
                   partresRepo As PartResultRepository,
                   stationRepo As StationRepository,
                   ergoRepo As ErgonomicRepository,
                   groupRepo As GroupRepository,
                   deviceRepo As DeviceRepository,
                   tagRepo As DisplayTagRepository,
                   statusrepo As StatusEnumRepository,
                   customerRepo As CustomerRepository)
        _linerepo = linerepo
        _partresRepo = partresRepo
        _stationRepo = stationRepo
        _ergoRepo = ergoRepo
        _tagRepo = tagRepo
        _deviceRepo = deviceRepo
        _groupRepo = groupRepo
        _statusrepo = statusrepo
        _customerRepo = customerRepo
    End Sub

    Public Async Function Save(model As EditLinesViewModel) As Task(Of TransactionResult(Of EditLinesViewModel)) Implements IEditRepository(Of EditLinesViewModel).Save
        _linerepo.Save(model.Lines)
        _partresRepo.Save(model.PartResults)
        _stationRepo.Save(model.Stations)
        _statusrepo.Save(model.Statuses)
        _tagRepo.GetAll()
        Return New TransactionResult(Of EditLinesViewModel)(Await GetAllAsync())
    End Function

    Public Function GetAll() As EditLinesViewModel Implements IEditRepository(Of EditLinesViewModel).GetAll
        Dim lineT = _linerepo.GetAll()
        Dim partResT = _partresRepo.GetAll()
        Dim stationsT = _stationRepo.GetAll()
        Dim ergoT = _ergoRepo.GetAll()
        Dim tags = _tagRepo.GetAll()
        Dim statuses = _statusrepo.GetAll()
        Dim customers = _customerRepo.GetAll()

        If tags.Any(Function(x) x.GroupId = 0) Then
            Throw New Exception()
        End If
        Return New EditLinesViewModel(lineT, partResT, stationsT, ergoT, tags, statuses, customers)
    End Function

    Public Async Function GetAllAsync() As Task(Of EditLinesViewModel) Implements IEditRepository(Of EditLinesViewModel).GetAllAsync
        Dim lineT = _linerepo.GetAllAsync()
        Dim partResT = _partresRepo.GetAllAsync()
        Dim stationsT = _stationRepo.GetAllAsync()
        Dim ergoT = _ergoRepo.GetAllAsync()
        Dim tagsT = _tagRepo.GetAllAsync()
        Dim statusesT = _statusrepo.GetAllAsync()
        Dim customersT = _customerRepo.GetAllAsync()

        Dim tags = Await tagsT
        If tags.Any(Function(x) x.GroupId = 0) Then
            Throw New Exception()
        End If

        Return New EditLinesViewModel(Await lineT, Await partResT, Await stationsT, Await ergoT, tags, Await statusesT, Await customersT)
    End Function
End Class


