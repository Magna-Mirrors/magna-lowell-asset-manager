Public Class CustomerRepository
    Inherits ReadonlyRepository(Of Customer, Part_Customers)

    Public Sub New(dbFactory As DbFactory)
        MyBase.New(dbFactory)
    End Sub


    Protected Overrides Function MapOutModel(inRecord As Part_Customers, outModel As Customer) As Customer


    End Function
End Class
