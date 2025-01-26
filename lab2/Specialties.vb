Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Specialties
    Public Sub New()
        Students = New HashSet(Of Students)()
    End Sub

    <Key>
    Public Property ID_Specialties As Integer

    Public Property Title As String

    Public Property Description As String

    Public Overridable Property Students As ICollection(Of Students)
End Class
