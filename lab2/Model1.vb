Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class Model1
	Inherits DbContext

	Public Sub New()
		MyBase.New("name=Model1")
	End Sub

	Public Overridable Property Evaluations As DbSet(Of Evaluations)
	Public Overridable Property Specialties As DbSet(Of Specialties)
	Public Overridable Property Students As DbSet(Of Students)
	Public Overridable Property Subjects As DbSet(Of Subjects)
	Public Overridable Property sysdiagrams As DbSet(Of sysdiagrams)

	Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
		modelBuilder.Entity(Of Specialties)() _
			.HasMany(Function(e) e.Students) _
			.WithOptional(Function(e) e.Specialties) _
			.WillCascadeOnDelete()

		modelBuilder.Entity(Of Students)() _
			.HasOptional(Function(e) e.Evaluations) _
			.WithRequired(Function(e) e.Students) _
			.WillCascadeOnDelete()

		modelBuilder.Entity(Of Subjects)() _
			.HasMany(Function(e) e.Evaluations) _
			.WithOptional(Function(e) e.Subjects) _
			.HasForeignKey(Function(e) e.ID_Subjects1)

		modelBuilder.Entity(Of Subjects)() _
			.HasMany(Function(e) e.Evaluations1) _
			.WithOptional(Function(e) e.Subjects1) _
			.HasForeignKey(Function(e) e.ID_Subjects2) _
			.WillCascadeOnDelete()
	End Sub
End Class
