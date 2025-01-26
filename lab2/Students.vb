Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Students
    <Key>
    Public Property ID_Student As Integer

    Public Property FIO As String

    <StringLength(10)>
    Public Property Gender As String

    <Column(TypeName:="date")>
    Public Property Date_Of_Birth As Date?

    Public Property Parents As String

    Public Property Address As String

    Public Property Phone As String

    Public Property Pasport_num As String

    Public Property Credit_Card_Number As Integer?

    <Column(TypeName:="date")>
    Public Property Date_Of_Receipt As Date?

    Public Property Group As String

    Public Property Course As Integer?

    Public Property ID_Specialties As Integer?

    Public Property Full_Time_Education As Boolean?

    Public Overridable Property Evaluations As Evaluations

    Public Overridable Property Specialties As Specialties
End Class
