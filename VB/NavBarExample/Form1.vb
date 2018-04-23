Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace NavBarExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			AddHandler Load, AddressOf Form1_Load
			AddHandler myNavBarControl1.Resize, AddressOf myNavBarControl1_Resize
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			myNavBarControl1.AddBar(New DevExpress.XtraNavBar.NavBarControl())
			myNavBarControl1.AddBar(New DevExpress.XtraNavBar.NavBarControl())
			myNavBarControl1.AddGroup(0, "Sales")
			myNavBarControl1.AddGroup(0, "System")
			myNavBarControl1.AddGroup(1, "Production")
			myNavBarControl1.AddGroup(1, "System Root")
			myNavBarControl1.ArrGroupItem(0, "Sales", "Materials")
			myNavBarControl1.ArrGroupItem(0, "Sales", "Operations")
			myNavBarControl1.ArrGroupItem(0, "Sales", "VAT Setup")
			myNavBarControl1.ArrGroupItem(0, "System", "Auto-Numbers")
			myNavBarControl1.ArrGroupItem(1, "Production", "Shifts")
			myNavBarControl1.ArrGroupItem(1, "Production", "Capacities")
			myNavBarControl1.ArrGroupItem(1, "System Root", "Queue Viewer")
		End Sub

		Private Sub myNavBarControl1_Resize(ByVal sender As Object, ByVal e As EventArgs)
			dockPanel2.Width = myNavBarControl1.Width + 8
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			myNavBarControl1.AddBar(New DevExpress.XtraNavBar.NavBarControl())
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			myNavBarControl1.DeleteBar(CInt(Fix(spinEdit3.Value)))
		End Sub

		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			myNavBarControl1.AddGroup(CInt(Fix(spinEdit1.Value)), textEdit1.Text)
		End Sub

		Private Sub simpleButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton4.Click
			myNavBarControl1.DeleteGroup(CInt(Fix(spinEdit1.Value)), textEdit1.Text)
		End Sub

		Private Sub simpleButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton5.Click
			myNavBarControl1.ArrGroupItem(CInt(Fix(spinEdit2.Value)), textEdit2.Text, textEdit3.Text)
		End Sub

		Private Sub simpleButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton6.Click
			myNavBarControl1.DeleteGroupItem(CInt(Fix(spinEdit2.Value)), textEdit2.Text, textEdit3.Text)
		End Sub

	End Class
End Namespace
