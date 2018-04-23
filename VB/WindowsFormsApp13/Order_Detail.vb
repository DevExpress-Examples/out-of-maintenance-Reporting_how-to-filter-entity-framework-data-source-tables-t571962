Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace WindowsFormsApp13

    <Table("Order Details")> _
    Partial Public Class Order_Detail
        <Key, Column(Order := 0), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property OrderID() As Integer

        <Key, Column(Order := 1), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property ProductID() As Integer

        <Key, Column(Order := 2, TypeName := "smallmoney")> _
        Public Property UnitPrice() As Decimal

        <Key, Column(Order := 3), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property Quantity() As Short

        <Key, Column(Order := 4)> _
        Public Property Discount() As Single

        Public Overridable Property Order() As Order

        Public Overridable Property Product() As Product
    End Class
End Namespace
