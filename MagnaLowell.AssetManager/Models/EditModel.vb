Public Interface IEditModel
    Property EditState As EditState
End Interface
Public Interface ICopy(Of T As Class)
    Sub CopyTo(item As T)
End Interface
Public Enum EditState
    None
    Create
    Edit
    Delete
End Enum

Public Enum SchedulerMode
    None = 0
    Wcf = 1
    Sql = 2
End Enum