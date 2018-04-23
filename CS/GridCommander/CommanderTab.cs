using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace GridCommander
{
    public partial class CommanderTab : DevExpress.XtraEditors.XtraUserControl
    {
        DirectoryInfo _parent;
        DirectoryInfo _curentDirectory;
        DirectoryInfo CurentDirectory
        {
            get { return _curentDirectory; }
            set
            {
                if (_curentDirectory == value)
                    return;
                te_CurentText.Text = value.FullName;
                _curentDirectory = value;
                List<FileSystemInfo> infos = new List<FileSystemInfo>();
                infos.AddRange(_curentDirectory.GetFileSystemInfos());
                if (_curentDirectory.Parent != null)
                {
                    _parent = _curentDirectory.Parent;
                    infos.Insert(0, _parent);
                }
                Grid.DataSource = infos;
            }
        }
        public CommanderTab()
        {
            InitializeComponent();
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            cmb_Drives.Properties.Items.AddRange(Directory.GetLogicalDrives());
            cmb_Drives.Text = cmb_Drives.Properties.Items[0].ToString();
        }

        private void cmb_Drives_EditValueChanged(object sender, EventArgs e)
        {
            CurentDirectory = new DirectoryInfo(cmb_Drives.Text);
        }

        private void cmb_Drives_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try 
            {
                CurentDirectory = new DirectoryInfo(e.NewValue.ToString());
            }
            catch
            {
                CurentDirectory = new DirectoryInfo(e.OldValue.ToString());
                e.Cancel = true;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FileSystemInfo fi = gridView1.GetRow(gridView1.FocusedRowHandle) as FileSystemInfo;
            if ((fi.Attributes & FileAttributes.Directory) != FileAttributes.Directory)
            {
                Process p = Process.Start(fi.FullName);
            }
            else
            {
                CurentDirectory = new DirectoryInfo(fi.FullName);
            }
            return;
        }

        private void CommanderTab_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back)&&(CurentDirectory.Parent!=null))
            {
                CurentDirectory = CurentDirectory.Parent;
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == colName)
            {
                Icon ic;
                FileAttributes fa = (FileAttributes)gridView1.GetRowCellValue(e.RowHandle, colAttributes);
                if ((fa & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    ic = new Icon("../../Resources/Folder-Open.ico");
                }
                else
                {
                    string path = (string)gridView1.GetRowCellValue(e.RowHandle, colFullName);
                    ic = Icon.ExtractAssociatedIcon(path);
                }
                Rectangle rec = e.Bounds;
                rec.Width = rec.Height;
                rec.Inflate(-2, -2);
                rec.Offset(1, 1);
                e.Cache.Graphics.DrawIcon(ic, rec);
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            int rowHandler = gridView1.GetRowHandle(e.ListSourceRowIndex);
            if (e.Column == colName)
            {
                string s = (string)gridView1.GetRowCellValue(rowHandler, colFullName);
                if ((_parent != null) && (s == _parent.FullName))
                    e.DisplayText = "[..]";
                else
                {
                    FileAttributes fa = (FileAttributes)gridView1.GetRowCellValue(rowHandler, colAttributes);
                    if ((fa & FileAttributes.Directory) == FileAttributes.Directory)
                        e.DisplayText = "[" + e.Value + "]";
                }
            }
            if (e.Column == colSize)
            {
                FileAttributes fa = (FileAttributes)gridView1.GetRowCellValue(rowHandler, colAttributes);
                if ((fa & FileAttributes.Directory) == FileAttributes.Directory)
                    e.DisplayText = "<DIR>";
                else
                {
                    string path = (string)gridView1.GetRowCellValue(rowHandler, colFullName);
                    FileInfo fi = new FileInfo(path);
                    e.DisplayText = fi.Length.ToString();
                }
            }
        }
    }
}
