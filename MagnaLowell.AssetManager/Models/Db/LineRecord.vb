'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class LineRecord
    Public Property Id As Integer
    Public Property LineName As String
    Public Property MaxConcurrentLogins As Integer
    Public Property Dept As String
    Public Property Description As String
    Public Property CustomerId As Nullable(Of Integer)
    Public Property LineDefinition As String
    Public Property WcfFileName As String
    Public Property SelectCmd As String
    Public Property ScheduleFolder As String
    Public Property SchedulerMethod As Integer
    Public Property WorkBufferMinutes As Decimal
    Public Property ReOrderPercentThreshold As Decimal
    Public Property Workcell As String

    Public Overridable Property Eqp_PartResults As ICollection(Of PartResultRecord) = New HashSet(Of PartResultRecord)
    Public Overridable Property eqp_Stations As ICollection(Of StationRecord) = New HashSet(Of StationRecord)

End Class
