Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace WindowsFormsApp13

    Partial Public Class Category
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")> _
        Public Sub New()
            Products = New HashSet(Of Product)()
        End Sub

        Public Property CategoryID() As Integer

        <Required, StringLength(15)> _
        Public Property CategoryName() As String

        <Column(TypeName := "ntext")> _
        Public Property Description() As String

        <Column(TypeName := "image")> _
        Public Property Picture() As Byte()

        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")> _
        Public Overridable Property Products() As ICollection(Of Product)
    End Class
End Namespace
