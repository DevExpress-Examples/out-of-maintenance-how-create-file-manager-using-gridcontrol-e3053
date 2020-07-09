Namespace GridCommander
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
			Me.commanderTab2 = New GridCommander.CommanderTab()
			Me.commanderTab1 = New GridCommander.CommanderTab()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' commanderTab2
			' 
			Me.commanderTab2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.commanderTab2.Location = New System.Drawing.Point(0, 0)
			Me.commanderTab2.Name = "commanderTab2"
			Me.commanderTab2.Size = New System.Drawing.Size(671, 594)
			Me.commanderTab2.TabIndex = 5
			' 
			' commanderTab1
			' 
			Me.commanderTab1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.commanderTab1.Location = New System.Drawing.Point(0, 0)
			Me.commanderTab1.Name = "commanderTab1"
			Me.commanderTab1.Size = New System.Drawing.Size(796, 594)
			Me.commanderTab1.TabIndex = 4
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.commanderTab2)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.commanderTab1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(1472, 594)
			Me.splitContainerControl1.SplitterPosition = 671
			Me.splitContainerControl1.TabIndex = 1
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1472, 594)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "GridCommander"
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private commanderTab2 As CommanderTab
		Private commanderTab1 As CommanderTab
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
	End Class
End Namespace

