Imports System.Linq
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System

Namespace WindowsFormsApp13

    Partial Public Class Model1
        Inherits DbContext

        Public Sub New()
            MyBase.New("name=NorthwindModel")
        End Sub

        Public Overridable Property Categories() As DbSet(Of Category)
        Public Overridable Property Customers() As DbSet(Of Customer)
        Public Overridable Property Employees() As DbSet(Of Employee)
        Public Overridable Property Orders() As DbSet(Of Order)
        Public Overridable Property Products() As DbSet(Of Product)
        Public Overridable Property Order_Details() As DbSet(Of Order_Detail)
        Public Overridable Property Invoices() As DbSet(Of Invoice)
        Public Overridable Property OrderReports() As DbSet(Of OrderReport)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            modelBuilder.Entity(Of Customer)().Property(Function(e) e.CustomerID).IsFixedLength()

            modelBuilder.Entity(Of Employee)().HasMany(Function(e) e.Orders).WithOptional(Function(e) e.Employee).HasForeignKey(Function(e) e.EmployeeID)

            modelBuilder.Entity(Of Employee)().HasMany(Function(e) e.Orders1).WithOptional(Function(e) e.Employee1).HasForeignKey(Function(e) e.EmployeeID)

            modelBuilder.Entity(Of Order)().Property(Function(e) e.CustomerID).IsFixedLength()

            modelBuilder.Entity(Of Order)().Property(Function(e) e.Freight).HasPrecision(10, 4)

            modelBuilder.Entity(Of Order)().HasMany(Function(e) e.Order_Details).WithRequired(Function(e) e.Order).WillCascadeOnDelete(False)

            modelBuilder.Entity(Of Product)().Property(Function(e) e.UnitPrice).HasPrecision(10, 4)

            modelBuilder.Entity(Of Product)().Property(Function(e) e.EAN13).IsUnicode(False)

            modelBuilder.Entity(Of Product)().HasMany(Function(e) e.Order_Details).WithRequired(Function(e) e.Product).WillCascadeOnDelete(False)

            modelBuilder.Entity(Of Order_Detail)().Property(Function(e) e.UnitPrice).HasPrecision(10, 4)

            modelBuilder.Entity(Of Invoice)().Property(Function(e) e.CustomerID).IsFixedLength()

            modelBuilder.Entity(Of Invoice)().Property(Function(e) e.UnitPrice).HasPrecision(10, 4)

            modelBuilder.Entity(Of Invoice)().Property(Function(e) e.ExtendedPrice).HasPrecision(19, 4)

            modelBuilder.Entity(Of Invoice)().Property(Function(e) e.Freight).HasPrecision(10, 4)

            modelBuilder.Entity(Of OrderReport)().Property(Function(e) e.UnitPrice).HasPrecision(10, 4)

            modelBuilder.Entity(Of OrderReport)().Property(Function(e) e.Extended_Price).HasPrecision(19, 4)
        End Sub
    End Class
End Namespace
