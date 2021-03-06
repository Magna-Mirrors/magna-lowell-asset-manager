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

Partial Public Class eqp_Stations
    Public Property StationId As Integer
    Public Property LineId As Integer
    Public Property Name As String
    Public Property Description As String
    Public Property ErgonomicId As Integer
    Public Property MinTrainingHours As Integer
    Public Property DaysofConsideration As Integer
    Public Property StatusTagId As Nullable(Of Integer)
    Public Property ShopLogixFolderName As String
    Public Property BadgeReaderIdx As Nullable(Of Integer)

    Public Overridable Property Eqp_ErgonomicCategories As Eqp_ErgonomicCategories
    Public Overridable Property Eqp_StateEnum As ICollection(Of Eqp_StateEnum) = New HashSet(Of Eqp_StateEnum)
    Public Overridable Property eqp_Lines As eqp_Lines

End Class
