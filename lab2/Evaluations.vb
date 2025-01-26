Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Evaluations
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property ID_Student As Integer

    <Column(TypeName:="date")>
    Public Property Date_Exam1 As Date?

    Public Property ID_Subjects1 As Integer?

    Public Property Evaluations1 As Integer?

    <Column(TypeName:="date")>
    Public Property Date_Exam2 As Date?

    Public Property ID_Subjects2 As Integer?

    Public Property Evaluations2 As Integer?

    Public Property Average_Score As Double?

    Public Overridable Property Students As Students

    Public Overridable Property Subjects As Subjects

    Public Overridable Property Subjects1 As Subjects
End Class
