Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace WindowsFormsApp13

    Partial Public Class Employee
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")> _
        Public Sub New()
            Orders = New HashSet(Of Order)()
            Orders1 = New HashSet(Of Order)()
        End Sub

        Public Property EmployeeID() As Integer

        <Required, StringLength(20)> _
        Public Property LastName() As String

        <Required, StringLength(10)> _
        Public Property FirstName() As String

        <StringLength(30)> _
        Public Property Title() As String

        <StringLength(25)> _
        Public Property TitleOfCourtesy() As String

        Public Property BirthDate() As Date?

        Public Property HireDate() As Date?

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
        Public Property HomePhone() As String

        <StringLength(4)> _
        Public Property Extension() As String

        <Column(TypeName := "image")> _
        Public Property Photo() As Byte()

        <Column(TypeName := "ntext")> _
        Public Property Notes() As String

        Public Property ReportsTo() As Integer?

        <StringLength(255)> _
        Public Property PhotoPath() As String

        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")> _
        Public Overridable Property Orders() As ICollection(Of Order)

        <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")> _
        Public Overridable Property Orders1() As ICollection(Of Order)
    End Class
End Namespace
