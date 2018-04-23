Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace WindowsFormsApp13

    Partial Public Class OrderReport
        <Key, Column(Order := 0), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property OrderID() As Integer

        <Key, Column(Order := 1), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property ProductID() As Integer

        <Key, Column(Order := 2), StringLength(40)> _
        Public Property ProductName() As String

        <Key, Column(Order := 3, TypeName := "smallmoney")> _
        Public Property UnitPrice() As Decimal

        <Key, Column(Order := 4), DatabaseGenerated(DatabaseGeneratedOption.None)> _
        Public Property Quantity() As Short

        <Key, Column(Order := 5)> _
        Public Property Discount() As Single

        <Column("Extended Price", TypeName := "money")> _
        Public Property Extended_Price() As Decimal?
    End Class
End Namespace
