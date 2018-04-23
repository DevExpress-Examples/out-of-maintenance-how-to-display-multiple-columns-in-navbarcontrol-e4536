Imports Microsoft.VisualBasic
Imports System
Namespace NavBarExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.simpleButton5 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton6 = New DevExpress.XtraEditors.SimpleButton()
			Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.spinEdit3 = New DevExpress.XtraEditors.SpinEdit()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.myNavBarControl1 = New NavBarExample.MyNavBarControl()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.spinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dockPanel2.SuspendLayout()
			Me.dockPanel2_Container.SuspendLayout()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel1_Container.SuspendLayout()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(5, 24)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(91, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "AddBar"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(5, 53)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(91, 23)
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "RemoveBar"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(5, 24)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(91, 23)
			Me.simpleButton3.TabIndex = 3
			Me.simpleButton3.Text = "AddGroup"
'			Me.simpleButton3.Click += New System.EventHandler(Me.simpleButton3_Click);
			' 
			' simpleButton4
			' 
			Me.simpleButton4.Location = New System.Drawing.Point(5, 53)
			Me.simpleButton4.Name = "simpleButton4"
			Me.simpleButton4.Size = New System.Drawing.Size(91, 23)
			Me.simpleButton4.TabIndex = 3
			Me.simpleButton4.Text = "DeleteGroup"
'			Me.simpleButton4.Click += New System.EventHandler(Me.simpleButton4_Click);
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(5, 101)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Size = New System.Drawing.Size(91, 20)
			Me.spinEdit1.TabIndex = 4
			' 
			' textEdit1
			' 
			Me.textEdit1.EditValue = "Group1"
			Me.textEdit1.Location = New System.Drawing.Point(5, 146)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(91, 20)
			Me.textEdit1.TabIndex = 5
			' 
			' simpleButton5
			' 
			Me.simpleButton5.Location = New System.Drawing.Point(5, 24)
			Me.simpleButton5.Name = "simpleButton5"
			Me.simpleButton5.Size = New System.Drawing.Size(91, 23)
			Me.simpleButton5.TabIndex = 6
			Me.simpleButton5.Text = "AddItem"
'			Me.simpleButton5.Click += New System.EventHandler(Me.simpleButton5_Click);
			' 
			' simpleButton6
			' 
			Me.simpleButton6.Location = New System.Drawing.Point(5, 53)
			Me.simpleButton6.Name = "simpleButton6"
			Me.simpleButton6.Size = New System.Drawing.Size(91, 23)
			Me.simpleButton6.TabIndex = 6
			Me.simpleButton6.Text = "RemoveItem"
'			Me.simpleButton6.Click += New System.EventHandler(Me.simpleButton6_Click);
			' 
			' spinEdit2
			' 
			Me.spinEdit2.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit2.Location = New System.Drawing.Point(5, 103)
			Me.spinEdit2.Name = "spinEdit2"
			Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit2.Size = New System.Drawing.Size(91, 20)
			Me.spinEdit2.TabIndex = 4
			' 
			' textEdit2
			' 
			Me.textEdit2.EditValue = "Group1"
			Me.textEdit2.Location = New System.Drawing.Point(5, 148)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Size = New System.Drawing.Size(91, 20)
			Me.textEdit2.TabIndex = 5
			' 
			' textEdit3
			' 
			Me.textEdit3.EditValue = "Item1"
			Me.textEdit3.Location = New System.Drawing.Point(5, 192)
			Me.textEdit3.Name = "textEdit3"
			Me.textEdit3.Size = New System.Drawing.Size(91, 20)
			Me.textEdit3.TabIndex = 5
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.labelControl1)
			Me.groupControl1.Controls.Add(Me.spinEdit3)
			Me.groupControl1.Controls.Add(Me.simpleButton1)
			Me.groupControl1.Controls.Add(Me.simpleButton2)
			Me.groupControl1.Location = New System.Drawing.Point(3, 3)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(101, 133)
			Me.groupControl1.TabIndex = 7
			Me.groupControl1.Text = "NavBars"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(5, 82)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(45, 13)
			Me.labelControl1.TabIndex = 4
			Me.labelControl1.Text = "Bar index"
			' 
			' spinEdit3
			' 
			Me.spinEdit3.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit3.Location = New System.Drawing.Point(5, 101)
			Me.spinEdit3.Name = "spinEdit3"
			Me.spinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit3.Size = New System.Drawing.Size(91, 20)
			Me.spinEdit3.TabIndex = 3
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.labelControl3)
			Me.groupControl2.Controls.Add(Me.labelControl2)
			Me.groupControl2.Controls.Add(Me.simpleButton3)
			Me.groupControl2.Controls.Add(Me.simpleButton4)
			Me.groupControl2.Controls.Add(Me.spinEdit1)
			Me.groupControl2.Controls.Add(Me.textEdit1)
			Me.groupControl2.Location = New System.Drawing.Point(3, 142)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(101, 173)
			Me.groupControl2.TabIndex = 4
			Me.groupControl2.Text = "Groups"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(5, 127)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(58, 13)
			Me.labelControl3.TabIndex = 4
			Me.labelControl3.Text = "Group name"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(5, 82)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(45, 13)
			Me.labelControl2.TabIndex = 4
			Me.labelControl2.Text = "Bar index"
			' 
			' groupControl3
			' 
			Me.groupControl3.Controls.Add(Me.simpleButton5)
			Me.groupControl3.Controls.Add(Me.labelControl6)
			Me.groupControl3.Controls.Add(Me.labelControl5)
			Me.groupControl3.Controls.Add(Me.labelControl4)
			Me.groupControl3.Controls.Add(Me.simpleButton6)
			Me.groupControl3.Controls.Add(Me.spinEdit2)
			Me.groupControl3.Controls.Add(Me.textEdit3)
			Me.groupControl3.Controls.Add(Me.textEdit2)
			Me.groupControl3.Location = New System.Drawing.Point(3, 321)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(101, 225)
			Me.groupControl3.TabIndex = 8
			Me.groupControl3.Text = "Items"
			' 
			' labelControl6
			' 
			Me.labelControl6.Location = New System.Drawing.Point(5, 173)
			Me.labelControl6.Name = "labelControl6"
			Me.labelControl6.Size = New System.Drawing.Size(51, 13)
			Me.labelControl6.TabIndex = 4
			Me.labelControl6.Text = "Item name"
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(5, 129)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(58, 13)
			Me.labelControl5.TabIndex = 4
			Me.labelControl5.Text = "Group name"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(5, 82)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(45, 13)
			Me.labelControl4.TabIndex = 4
			Me.labelControl4.Text = "Bar index"
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanel2, Me.dockPanel1})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' dockPanel2
			' 
			Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
			Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
			Me.dockPanel2.ID = New System.Guid("0f98b5ab-7886-4ded-a565-174346537e6a")
			Me.dockPanel2.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel2.Name = "dockPanel2"
			Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
			Me.dockPanel2.Size = New System.Drawing.Size(200, 605)
			Me.dockPanel2.Text = "dockPanel2"
			' 
			' dockPanel2_Container
			' 
			Me.dockPanel2_Container.Controls.Add(Me.myNavBarControl1)
			Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 23)
			Me.dockPanel2_Container.Name = "dockPanel2_Container"
			Me.dockPanel2_Container.Size = New System.Drawing.Size(192, 578)
			Me.dockPanel2_Container.TabIndex = 0
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.dockPanel1.ID = New System.Guid("9138430e-0796-4e25-a17e-d26a6f4e1629")
			Me.dockPanel1.Location = New System.Drawing.Point(403, 0)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
			Me.dockPanel1.Size = New System.Drawing.Size(200, 605)
			Me.dockPanel1.Text = "dockPanel1"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Controls.Add(Me.groupControl3)
			Me.dockPanel1_Container.Controls.Add(Me.groupControl1)
			Me.dockPanel1_Container.Controls.Add(Me.groupControl2)
			Me.dockPanel1_Container.Location = New System.Drawing.Point(4, 23)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(192, 578)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' myNavBarControl1
			' 
			Me.myNavBarControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
			Me.myNavBarControl1.Appearance.Options.UseBackColor = True
			Me.myNavBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myNavBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.myNavBarControl1.Name = "myNavBarControl1"
			Me.myNavBarControl1.Size = New System.Drawing.Size(192, 578)
			Me.myNavBarControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(603, 605)
			Me.Controls.Add(Me.dockPanel1)
			Me.Controls.Add(Me.dockPanel2)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.spinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			Me.groupControl3.PerformLayout()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dockPanel2.ResumeLayout(False)
			Me.dockPanel2_Container.ResumeLayout(False)
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel1_Container.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton4 As DevExpress.XtraEditors.SimpleButton
		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private WithEvents simpleButton5 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton6 As DevExpress.XtraEditors.SimpleButton
		Private spinEdit2 As DevExpress.XtraEditors.SpinEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private textEdit3 As DevExpress.XtraEditors.TextEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private spinEdit3 As DevExpress.XtraEditors.SpinEdit
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private labelControl6 As DevExpress.XtraEditors.LabelControl
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private myNavBarControl1 As MyNavBarControl


	End Class
End Namespace

