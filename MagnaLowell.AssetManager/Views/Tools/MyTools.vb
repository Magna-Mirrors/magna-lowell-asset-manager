Imports System.Runtime.CompilerServices
Imports DevExpress.XtraGrid.Views.Grid

Namespace Tools
    Public Class MyTools

        Public Shared Function FindNode(t As TreeNodeCollection, obj As Object) As TreeNode
            If t IsNot Nothing AndAlso obj IsNot Nothing Then

                For Each n As TreeNode In t
                    Dim res = FindNode(n, obj)
                    If res IsNot Nothing Then
                        Return res
                    End If
                Next
            End If
            Return Nothing
        End Function
        Public Shared Function FindNode(t As TreeNode, obj As Object) As TreeNode
            If t IsNot Nothing AndAlso obj IsNot Nothing Then

                If t.Tag Is obj Then
                    Return t
                Else
                    For Each n As TreeNode In t.Nodes
                        Dim res = FindNode(n, obj)
                        If res IsNot Nothing Then Return res
                    Next
                End If
            End If
            Return Nothing
        End Function

        ''' <summary>
        ''' This function will take a list of integers and then return the lowest non existing int in the list. If there are no gaps it returns (max value +1)
        ''' </summary>
        Public Shared Function GetLowestUnusedInt(ints As IEnumerable(Of Integer)) As Integer
            If ints.Count = 0 Then
                Return 0
            End If
            Dim states = ints
            Dim seq = Enumerable.Range(1, states.Max).ToList()
            Dim max = states.Max()
            seq.RemoveAll(Function(x) states.Contains(x))
            If seq.Count > 0 Then
                Return seq.Min()
            Else
                Return max + 1
            End If
        End Function

        Public Shared Function GetObjectFromRow(Of T As {Class})(gv As GridView) As T
            Dim row = gv.GetFocusedRow()
            If row IsNot Nothing Then
                Return TryCast(row, T)
            End If
            Return Nothing
        End Function

        Public Shared Function GetObjectFromRow(gv As GridView) As Object
            Dim row = gv.GetFocusedRow()
            If row IsNot Nothing Then
                Return row
            End If
            Return Nothing
        End Function


        'Shared ReadOnly _editBrush As New SolidBrush(Color.PaleGoldenrod)
        'Shared ReadOnly _insertBrush As New SolidBrush(Color.PaleGreen)
        'Shared ReadOnly _deleteBrush As New SolidBrush(Color.PaleVioletRed)
        'Public Shared Sub ColorGridView(Of T As {Class})(gv As GridView, db As IDbInterface, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
        '    Dim row = gv.GetRow(e.RowHandle)
        '    Dim item = TryCast(row, T)
        '    If item IsNot Nothing Then
        '        Dim cbrush As SolidBrush = Nothing
        '        Select Case db.GetItemState(item)
        '            Case ItemState.Update
        '                cbrush = _editBrush
        '            Case ItemState.Insert
        '                cbrush = _insertBrush
        '            Case ItemState.Delete
        '                cbrush = _deleteBrush
        '            Case Else
        '                Exit Sub
        '        End Select
        '        e.Cache.FillRectangle(cbrush, e.Bounds)
        '        e.Cache.DrawString(e.DisplayText, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), e.Bounds, e.Appearance.GetStringFormat())
        '        e.Handled = True
        '    End If
        'End Sub
    End Class

    Public Module MyExtensions
        <Extension()>
        Public Function GetNodeText(ByRef obj As Line) As String
            Return "Asset: " + obj.LineName
        End Function

        '<Extension()>
        'Public Function GetNodeText(obj As Security_UserTable) As String
        '    Return "User: " + obj.UserName
        'End Function

        '<Extension()>
        'Public Function GetNodeText(obj As StationRecord) As String
        '    Return $"Station_{obj.StationName}"
        'End Function

        '<Extension()>
        'Public Function GetNodeText(obj As ProductLine) As String
        '    Return "Product Line: " + obj.Name
        'End Function

        '<Extension()>
        'Public Function GetNodeText(obj As ProductInformation)
        '    return "Info: " +obj.
        'End Function
    End Module



End Namespace