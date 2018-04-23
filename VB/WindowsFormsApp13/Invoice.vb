Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace WindowsFormsApp13

    Partial Public Class Invoice
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

        <StringLength(5)> _
        Public Property CustomerID() As String

        <Key, Column(Order := 0), StringLength(40)> _
        Public Property CustomerName() As String

        <StringLength(60)> _
        Public Property Address() As String

        <StringLength(15)> _
        Public Property City() As String

        <StringLength(15)> _
        Public Property Region() As String

        <StringLength(10)> _
        Public Property PostalCode() As String

        <StringLength(15)> _
        Public Property Country() As String

        <Key, Column(Order := 1), StringLength(31)> _
        Public Property Salesperson() As String

        <Key, Column(Order := 2), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property OrderID() As Integer

        Public Property OrderDate() As Date?

        Public Property RequiredDate() As Date?

        Public Property ShippedDate() As Date?

        <Key, Column(Order := 3), StringLength(40)> _
        Public Property ShipperName() As String

        <Key, Column(Order := 4), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property ProductID() As Integer

        <Key, Column(Order := 5), StringLength(40)> _
        Public Property ProductName() As String

        <Key, Column(Order := 6, TypeName := "smallmoney")> _
        Public Property UnitPrice() As Decimal

        <Key, Column(Order := 7), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property Quantity() As Short

        <Key, Column(Order := 8)> _
        Public Property Discount() As Single

        <Column(TypeName := "money")> _
        Public Property ExtendedPrice() As Decimal?

        <Column(TypeName := "smallmoney")> _
        Public Property Freight() As Decimal?
    End Class
End Namespace
