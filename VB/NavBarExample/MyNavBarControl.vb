Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraBars.Docking

Namespace NavBarExample
	Partial Public Class MyNavBarControl
		Inherits DevExpress.XtraEditors.XtraUserControl
		Private Const _margin As Integer = 3
		Private images As ImageList
		Private imageIndexer As Integer = 0
		Public Sub New()
			InitializeComponent()
			AddHandler ControlAdded, AddressOf MyNavBarControl_ControlAdded
			AddHandler ControlRemoved, AddressOf MyNavBarControl_ControlRemoved
			AddHandler Resize, AddressOf MyNavBarControl_Resize
			images = New ImageList()
			images.Images.Add(My.Resources._1)
			images.Images.Add(My.Resources._2)
			images.Images.Add(My.Resources._3)
			images.Images.Add(My.Resources._4)
			images.Images.Add(My.Resources._5)
			images.Images.Add(My.Resources._6)
			images.Images.Add(My.Resources._7)
			images.Images.Add(My.Resources._8)
			images.Images.Add(My.Resources._9)
			images.Images.Add(My.Resources._10)
		End Sub

		Private Sub MyNavBarControl_Resize(ByVal sender As Object, ByVal e As EventArgs)
			For Each item As NavBarControl In Controls
				item.Height = Me.Height - (_margin * 2)
			Next item
		End Sub

		Private Sub MyNavBarControl_ControlRemoved(ByVal sender As Object, ByVal e As ControlEventArgs)
			If Controls.Count = 0 Then
				Return
			End If
			CalculateBestFit()
		End Sub

		Private Sub MyNavBarControl_ControlAdded(ByVal sender As Object, ByVal e As ControlEventArgs)
			CalculateBestFit()
		End Sub

		Public Sub CalculateBestFit()
			Dim locations As New List(Of Point)()
			Dim shift As Integer = _margin
			For i As Integer = 0 To Controls.Count - 1
				Dim newLocation As New Point()
				newLocation.X = (i * _margin) + shift
				shift += Controls(i).Width
				newLocation.Y = _margin
				locations.Add(newLocation)
			Next i
			For i As Integer = 0 To Controls.Count - 1
				Controls(i).Location = locations(i)
			Next i
			Me.Size = New Size((Controls.Count * _margin) + shift, Controls(0).Height + _margin * 2)
			OnResize(New EventArgs())
		End Sub

		Public Sub AddBar(ByVal navBar As NavBarControl)
			navBar.SmallImages = images
			Me.Controls.Add(navBar)
		End Sub

		Public Sub DeleteBar(ByVal index As Integer)
			If Controls.Count < index Then
				Return
			End If
			Controls.RemoveAt(index)
		End Sub

		Public Sub AddGroup(ByVal barIndex As Integer, ByVal groupName As String)
			If (Not IsCorrectIndex(barIndex)) Then
				Return
			End If
			Dim group As New NavBarGroup(groupName)
			group.Name = groupName
			TryCast(Controls(barIndex), NavBarControl).Groups.Add(group)
		End Sub

		Public Sub DeleteGroup(ByVal barIndex As Integer, ByVal groupName As String)
			If (Not IsCorrectIndex(barIndex)) Then
				Return
			End If
			Dim bar As NavBarControl = GetNavBarByIndex(barIndex)
			Dim group As NavBarGroup = GetNavBarGroupByName(bar, groupName)
			If group IsNot Nothing Then
				TryCast(Controls(barIndex), NavBarControl).Groups.Remove(group)
			End If
		End Sub

		Public Sub ArrGroupItem(ByVal barIndex As Integer, ByVal groupName As String, ByVal itemName As String)
			If (Not IsCorrectIndex(barIndex)) Then
				Return
			End If
			Dim bar As NavBarControl = GetNavBarByIndex(barIndex)
			Dim group As NavBarGroup = GetNavBarGroupByName(bar, groupName)
			If group Is Nothing Then
				Return
			End If
			If (Not group.Expanded) Then
				group.Expanded = True
			End If
            Dim item As New NavBarItem(itemName)
            If imageIndexer > images.Images.Count - 1 Then
                imageIndexer = 0
            End If
            item.SmallImageIndex = imageIndexer
			imageIndexer += 1
			group.ItemLinks.Add(item)
		End Sub

		Public Sub DeleteGroupItem(ByVal barIndex As Integer, ByVal groupName As String, ByVal itemName As String)
			If (Not IsCorrectIndex(barIndex)) Then
				Return
			End If
			Dim bar As NavBarControl = GetNavBarByIndex(barIndex)
			Dim group As NavBarGroup = GetNavBarGroupByName(bar, groupName)
			If group Is Nothing Then
				Return
			End If
			Dim item As NavBarItemLink = GetItemLinkByName(group, itemName)
			If item Is Nothing Then
				Return
			End If
			group.ItemLinks.Remove(item)
		End Sub

		Private Function GetItemLinkByName(ByVal group As NavBarGroup, ByVal itemName As String) As NavBarItemLink
			For Each item As NavBarItemLink In group.ItemLinks
				If item.Caption = itemName Then
					Return item
				End If
			Next item
			Return Nothing
		End Function

		Private Function IsCorrectIndex(ByVal index As Integer) As Boolean
			Return index > -1 AndAlso index < Controls.Count
		End Function

		Private Function GetNavBarGroupByName(ByVal bar As NavBarControl, ByVal groupName As String) As NavBarGroup
			Return bar.Groups(groupName)
		End Function

		Private Function GetNavBarByIndex(ByVal index As Integer) As NavBarControl
			Return TryCast(Controls(index), NavBarControl)
		End Function
	End Class
End Namespace
