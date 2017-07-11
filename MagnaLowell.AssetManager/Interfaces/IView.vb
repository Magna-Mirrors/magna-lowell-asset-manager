Imports DevExpress.XtraEditors

Namespace Interfaces

    Public Interface IView(Of Tvm As Class)
        Inherits IView
        Sub LoadView(data As Tvm)
    End Interface
    Public Interface IView
        Function Save() As Boolean
        ReadOnly Property Title() As String
        ReadOnly Property Control As UserControl
    End Interface
End Namespace