Namespace GridCommander
	Partial Public Class CommanderTab
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.te_CurentText = New DevExpress.XtraEditors.TextEdit()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.cmb_Drives = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.Grid = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colAttributes = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
			Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colExtension = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCreationTime = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSize = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			CType(Me.te_CurentText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.cmb_Drives.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' te_CurentText
			' 
			Me.te_CurentText.Dock = System.Windows.Forms.DockStyle.Top
			Me.te_CurentText.Location = New System.Drawing.Point(0, 20)
			Me.te_CurentText.Name = "te_CurentText"
			Me.te_CurentText.Properties.ReadOnly = True
			Me.te_CurentText.Size = New System.Drawing.Size(775, 20)
			Me.te_CurentText.TabIndex = 6
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.cmb_Drives)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(775, 20)
			Me.panel1.TabIndex = 5
			' 
			' cmb_Drives
			' 
			Me.cmb_Drives.Dock = System.Windows.Forms.DockStyle.Left
			Me.cmb_Drives.Location = New System.Drawing.Point(0, 0)
			Me.cmb_Drives.Name = "cmb_Drives"
			Me.cmb_Drives.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmb_Drives.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmb_Drives.Size = New System.Drawing.Size(42, 20)
			Me.cmb_Drives.TabIndex = 1
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.cmb_Drives.EditValueChanged += new System.EventHandler(this.cmb_Drives_EditValueChanged);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.cmb_Drives.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cmb_Drives_EditValueChanging);
			' 
			' Grid
			' 
			Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.Grid.Location = New System.Drawing.Point(0, 40)
			Me.Grid.MainView = Me.gridView1
			Me.Grid.Name = "Grid"
			Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemButtonEdit1, Me.repositoryItemPictureEdit1})
			Me.Grid.Size = New System.Drawing.Size(775, 445)
			Me.Grid.TabIndex = 1
			Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Grid.Load += new System.EventHandler(this.Grid_Load);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommanderTab_KeyDown);
			' 
			' gridView1
			' 
			Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colAttributes, Me.colName, Me.colFullName, Me.colExtension, Me.colCreationTime, Me.colSize})
			Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			Me.gridView1.GridControl = Me.Grid
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsBehavior.ReadOnly = True
			Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.gridView1.OptionsSelection.MultiSelect = True
			Me.gridView1.OptionsView.ShowHorzLines = False
			Me.gridView1.OptionsView.ShowVertLines = False
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
			' 
			' colAttributes
			' 
			Me.colAttributes.Caption = "Attributes"
			Me.colAttributes.FieldName = "Attributes"
			Me.colAttributes.Name = "colAttributes"
			Me.colAttributes.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.ColumnEdit = Me.repositoryItemButtonEdit1
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' repositoryItemButtonEdit1
			' 
			Me.repositoryItemButtonEdit1.AutoHeight = False
			Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 0, False, True, True, DevExpress.XtraEditors.ImageLocation.MiddleLeft, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
			Me.repositoryItemButtonEdit1.ReadOnly = True
			' 
			' colFullName
			' 
			Me.colFullName.Caption = "FullName"
			Me.colFullName.FieldName = "FullName"
			Me.colFullName.Name = "colFullName"
			' 
			' colExtension
			' 
			Me.colExtension.Caption = "Extension"
			Me.colExtension.FieldName = "Extension"
			Me.colExtension.Name = "colExtension"
			Me.colExtension.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
			Me.colExtension.Visible = True
			Me.colExtension.VisibleIndex = 1
			' 
			' colCreationTime
			' 
			Me.colCreationTime.Caption = "Date"
			Me.colCreationTime.FieldName = "CreationTime"
			Me.colCreationTime.Name = "colCreationTime"
			Me.colCreationTime.Visible = True
			Me.colCreationTime.VisibleIndex = 2
			' 
			' colSize
			' 
			Me.colSize.Caption = "Size"
			Me.colSize.Name = "colSize"
			Me.colSize.Visible = True
			Me.colSize.VisibleIndex = 3
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' CommanderTab
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.Grid)
			Me.Controls.Add(Me.te_CurentText)
			Me.Controls.Add(Me.panel1)
			Me.Name = "CommanderTab"
			Me.Size = New System.Drawing.Size(775, 485)
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommanderTab_KeyDown);
			CType(Me.te_CurentText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.cmb_Drives.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents Grid As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents cmb_Drives As DevExpress.XtraEditors.ComboBoxEdit
		Private colAttributes As DevExpress.XtraGrid.Columns.GridColumn
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colFullName As DevExpress.XtraGrid.Columns.GridColumn
		Private colExtension As DevExpress.XtraGrid.Columns.GridColumn
		Private colCreationTime As DevExpress.XtraGrid.Columns.GridColumn
		Private te_CurentText As DevExpress.XtraEditors.TextEdit
		Private colSize As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
	End Class
End Namespace
