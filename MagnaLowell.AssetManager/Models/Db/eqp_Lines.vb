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

Partial Public Class eqp_Lines
    Public Property Id As Integer
    Public Property LineName As String
    Public Property Dept As String
    Public Property LineDefinition As String
    Public Property MaxConcurrentLogins As Integer
    Public Property WcfFileName As String
    Public Property SelectCmd As String
    Public Property ScheduleFolder As String
    Public Property SchedulerMethod As Integer
    Public Property WorkBufferMinutes As Decimal
    Public Property ReOrderPercentThreshold As Decimal
    Public Property Workcell As String
    Public Property CustomerId As Nullable(Of Integer)

    Public Overridable Property Eqp_PartResults As ICollection(Of Eqp_PartResults) = New HashSet(Of Eqp_PartResults)
    Public Overridable Property eqp_Stations As ICollection(Of eqp_Stations) = New HashSet(Of eqp_Stations)
    Public Overridable Property Part_Customers As Part_Customers

End Class
