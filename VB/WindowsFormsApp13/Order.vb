Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace WindowsFormsApp13

    Partial Public Class Order
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")> _
        Public Sub New()
            Order_Details = New HashSet(Of Order_Detail)()
        End Sub

        Public Property OrderID() As Integer

        <StringLength(5)> _
        Public Property CustomerID() As String

        Public Property EmployeeID() As Integer?

        Public Property OrderDate() As Date?

        Public Property RequiredDate() As Date?

        Public Property ShippedDate() As Date?

        Public Property ShipVia() As Integer?

        <Column(TypeName := "smallmoney")> _
        Public Property Freight() As Decimal?

        <StringLength(40)> _
        Public Property ShipName() As String

        <StringLength(60)> _
        Public Property ShipAddress() As String

        <StringLength(15)> _
        Public Property ShipCity() As String

        <StringLength(15)> _
        Public Property ShipRegion() As String

        <StringLength(10)> _
        Public Property ShipPostalCode() As String

        <StringLength(15)> _
        Public Property ShipCountry() As String

        Public Overridable Property Employee() As Employee

        Public Overridable Property Employee1() As Employee

        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")> _
        Public Overridable Property Order_Details() As ICollection(Of Order_Detail)
    End Class
End Namespace
