Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1
    'ReadOnly _users As New List(Of User)
    'ReadOnly _lines As New List(Of ProductionLine)
    'ReadOnly _assingments As New List(Of UserLinePermission)

    <TestMethod()> Public Sub TestMethod1()
        'Dim db = New DbInterface( )
        'Dim y As New ProductionLine() With {.Dept = "testdpt", .AssetNumber = "test line 1"}
        'Dim y2 As New ProductionLine() With {.Dept = "testdpt", .AssetNumber = "test line 2"}
        'Dim s1 As New Station() With {.Description = "my descriptor", .StationNumber = "s1"}
        'Dim s2 As New Station() With {.Description = "my descriptor 2", .StationNumber = "s2"}
        'Dim s21 As New Station() With {.Description = "my descriptor", .StationNumber = "s3"}
        'Dim s22 As New Station() With {.Description = "my descriptor 2", .StationNumber = "s4"}

        's21.Statuses.Add(New StationStatus() With {.Description = "asdf1", .State = 1})
        's21.Statuses.Add(New StationStatus() With {.Description = "asdf2", .State = 2})
        's21.Statuses.Add(New StationStatus() With {.Description = "asdf3", .State = 3})


        'Dim u1 As New User() With {.Name = "n1", .Badge = "b1", .BaseLevel = LevelEnum.Engineer, .Clock = "c1"}
        'Dim u2 As New User() With {.Name = "n2", .Badge = "b1", .BaseLevel = LevelEnum.Engineer, .Clock = "c1"}
        'Dim a1 As New UserLinePermission(u1, y)
        '_users.Add(u1)
        '_users.Add(u2)
        'y.Stations.AddRange({s1, s2})
        'y2.Stations.AddRange({s21, s22})

        '_lines.Add(y)
        '_lines.Add(y2)
        '_assingments.Add(a1)
        'db.SaveLines(_lines)
        'For Each l In _lines
        '    Assert.AreNotEqual(l.LineId, 0)
        'Next
    End Sub

End Class