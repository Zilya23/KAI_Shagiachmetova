Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Subjects
    Public Sub New()
        Evaluations = New HashSet(Of Evaluations)()
        Evaluations1 = New HashSet(Of Evaluations)()
    End Sub

    <Key>
    Public Property ID_Subjects As Integer

    Public Property Title As String

    Public Property Description As String

    Public Overridable Property Evaluations As ICollection(Of Evaluations)

    Public Overridable Property Evaluations1 As ICollection(Of Evaluations)
End Class
