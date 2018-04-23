Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace WindowsFormsApp13

    Partial Public Class Customer
        <StringLength(5)> _
        Public Property CustomerID() As String

        <Required, StringLength(40)> _
        Public Property CompanyName() As String

        <StringLength(30)> _
        Public Property ContactName() As String

        <StringLength(30)> _
        Public Property ContactTitle() As String

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

        <StringLength(24)> _
        Public Property Phone() As String

        <StringLength(24)> _
        Public Property Fax() As String
    End Class
End Namespace
