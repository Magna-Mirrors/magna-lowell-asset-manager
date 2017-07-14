Imports MagnaLowell.AssetManager.Interfaces

Public Interface IEditControl(Of TIn As {Class})
    Function DataValidated() As Boolean
    Sub LoadView(data As TIn)
    Function Save() As Boolean
End Interface
