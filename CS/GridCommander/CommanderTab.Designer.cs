namespace GridCommander
{
    partial class CommanderTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.te_CurentText = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Drives = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAttributes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.te_CurentText.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Drives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // te_CurentText
            // 
            this.te_CurentText.Dock = System.Windows.Forms.DockStyle.Top;
            this.te_CurentText.Location = new System.Drawing.Point(0, 20);
            this.te_CurentText.Name = "te_CurentText";
            this.te_CurentText.Properties.ReadOnly = true;
            this.te_CurentText.Size = new System.Drawing.Size(775, 20);
            this.te_CurentText.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_Drives);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 20);
            this.panel1.TabIndex = 5;
            // 
            // cmb_Drives
            // 
            this.cmb_Drives.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmb_Drives.Location = new System.Drawing.Point(0, 0);
            this.cmb_Drives.Name = "cmb_Drives";
            this.cmb_Drives.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Drives.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_Drives.Size = new System.Drawing.Size(42, 20);
            this.cmb_Drives.TabIndex = 1;
            this.cmb_Drives.EditValueChanged += new System.EventHandler(this.cmb_Drives_EditValueChanged);
            this.cmb_Drives.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cmb_Drives_EditValueChanging);
            // 
            // Grid
            // 
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 40);
            this.Grid.MainView = this.gridView1;
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemPictureEdit1});
            this.Grid.Size = new System.Drawing.Size(775, 445);
            this.Grid.TabIndex = 1;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grid.Load += new System.EventHandler(this.Grid_Load);
            this.Grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommanderTab_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAttributes,
            this.colName,
            this.colFullName,
            this.colExtension,
            this.colCreationTime,
            this.colSize});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.Grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowHorzLines = false;
            this.gridView1.OptionsView.ShowVertLines = false;
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colAttributes
            // 
            this.colAttributes.Caption = "Attributes";
            this.colAttributes.FieldName = "Attributes";
            this.colAttributes.Name = "colAttributes";
            this.colAttributes.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 0, false, true, true, DevExpress.XtraEditors.ImageLocation.MiddleLeft, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "FullName";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            // 
            // colExtension
            // 
            this.colExtension.Caption = "Extension";
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            this.colExtension.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.colExtension.Visible = true;
            this.colExtension.VisibleIndex = 1;
            // 
            // colCreationTime
            // 
            this.colCreationTime.Caption = "Date";
            this.colCreationTime.FieldName = "CreationTime";
            this.colCreationTime.Name = "colCreationTime";
            this.colCreationTime.Visible = true;
            this.colCreationTime.VisibleIndex = 2;
            // 
            // colSize
            // 
            this.colSize.Caption = "Size";
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 3;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // CommanderTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.te_CurentText);
            this.Controls.Add(this.panel1);
            this.Name = "CommanderTab";
            this.Size = new System.Drawing.Size(775, 485);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommanderTab_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.te_CurentText.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Drives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Drives;
        private DevExpress.XtraGrid.Columns.GridColumn colAttributes;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationTime;
        private DevExpress.XtraEditors.TextEdit te_CurentText;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}
