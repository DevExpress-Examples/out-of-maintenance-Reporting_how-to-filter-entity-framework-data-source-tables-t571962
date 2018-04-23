Imports DevExpress.XtraEditors
Imports System

Namespace WindowsFormsApp13
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Me.reportDesigner1.OpenReport("CityOrders.repx")
        End Sub
    End Class
End Namespace
