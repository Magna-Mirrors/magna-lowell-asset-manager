Imports DevExpress.XtraEditors

Namespace Interfaces

    Public Interface IDilg
        Property IsReadonly As Boolean
        ReadOnly Property View As XtraUserControl
        Sub Save()
    End Interface
End Namespace