Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace WindowsFormsApp13

    Partial Public Class Product
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")> _
        Public Sub New()
            Order_Details = New HashSet(Of Order_Detail)()
        End Sub

        Public Property ProductID() As Integer

        <Required, StringLength(40)> _
        Public Property ProductName() As String

        Public Property SupplierID() As Integer?

        Public Property CategoryID() As Integer?

        <StringLength(20)> _
        Public Property QuantityPerUnit() As String

        <Column(TypeName := "smallmoney")> _
        Public Property UnitPrice() As Decimal?

        Public Property UnitsInStock() As Short?

        Public Property UnitsOnOrder() As Short?

        Public Property ReorderLevel() As Short?

        Public Property Discontinued() As Boolean

        <Column(TypeName := "text")> _
        Public Property EAN13() As String

        Public Overridable Property Category() As Category

        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")> _
        Public Overridable Property Order_Details() As ICollection(Of Order_Detail)
    End Class
End Namespace
