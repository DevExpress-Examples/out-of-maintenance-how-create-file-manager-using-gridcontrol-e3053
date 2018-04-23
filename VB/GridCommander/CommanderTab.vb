Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Diagnostics
Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Namespace GridCommander
	Partial Public Class CommanderTab
		Inherits DevExpress.XtraEditors.XtraUserControl
		Private _parent As DirectoryInfo
		Private _curentDirectory As DirectoryInfo
		Private Property CurentDirectory() As DirectoryInfo
			Get
				Return _curentDirectory
			End Get
			Set(ByVal value As DirectoryInfo)
				If _curentDirectory Is value Then
					Return
				End If
				te_CurentText.Text = value.FullName
				_curentDirectory = value
				Dim infos As New List(Of FileSystemInfo)()
				infos.AddRange(_curentDirectory.GetFileSystemInfos())
				If _curentDirectory.Parent IsNot Nothing Then
					_parent = _curentDirectory.Parent
					infos.Insert(0, _parent)
				End If
				Grid.DataSource = infos
			End Set
		End Property
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Grid_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Grid.Load
			cmb_Drives.Properties.Items.AddRange(Directory.GetLogicalDrives())
			cmb_Drives.Text = cmb_Drives.Properties.Items(0).ToString()
		End Sub

		Private Sub cmb_Drives_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_Drives.EditValueChanged
			CurentDirectory = New DirectoryInfo(cmb_Drives.Text)
		End Sub

		Private Sub cmb_Drives_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles cmb_Drives.EditValueChanging
			Try
				CurentDirectory = New DirectoryInfo(e.NewValue.ToString())
			Catch
				CurentDirectory = New DirectoryInfo(e.OldValue.ToString())
				e.Cancel = True
			End Try
		End Sub

		Private Sub gridView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.DoubleClick
			Dim fi As FileSystemInfo = TryCast(gridView1.GetRow(gridView1.FocusedRowHandle), FileSystemInfo)
			If (fi.Attributes And FileAttributes.Directory) <> FileAttributes.Directory Then
				Dim p As Process = Process.Start(fi.FullName)
			Else
				CurentDirectory = New DirectoryInfo(fi.FullName)
			End If
			Return
		End Sub

		Private Sub CommanderTab_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Grid.KeyDown, MyBase.KeyDown
			If (e.KeyCode = Keys.Back) AndAlso (CurentDirectory.Parent IsNot Nothing) Then
				CurentDirectory = CurentDirectory.Parent
			End If
		End Sub

		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
			If e.Column Is colName Then
				Dim ic As Icon
				Dim fa As FileAttributes = CType(gridView1.GetRowCellValue(e.RowHandle, colAttributes), FileAttributes)
				If (fa And FileAttributes.Directory) = FileAttributes.Directory Then
					ic = New Icon("../../Resources/Folder-Open.ico")
				Else
					Dim path As String = CStr(gridView1.GetRowCellValue(e.RowHandle, colFullName))
					ic = Icon.ExtractAssociatedIcon(path)
				End If
				Dim rec As Rectangle = e.Bounds
				rec.Width = rec.Height
				rec.Inflate(-2, -2)
				rec.Offset(1, 1)
				e.Cache.Graphics.DrawIcon(ic, rec)
			End If
		End Sub

		Private Sub gridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles gridView1.CustomColumnDisplayText
			Dim rowHandler As Integer = gridView1.GetRowHandle(e.ListSourceRowIndex)
			If e.Column Is colName Then
				Dim s As String = CStr(gridView1.GetRowCellValue(rowHandler, colFullName))
				If (_parent IsNot Nothing) AndAlso (s = _parent.FullName) Then
					e.DisplayText = "[..]"
				Else
					Dim fa As FileAttributes = CType(gridView1.GetRowCellValue(rowHandler, colAttributes), FileAttributes)
					If (fa And FileAttributes.Directory) = FileAttributes.Directory Then
						e.DisplayText = "[" & e.Value & "]"
					End If
				End If
			End If
			If e.Column Is colSize Then
				Dim fa As FileAttributes = CType(gridView1.GetRowCellValue(rowHandler, colAttributes), FileAttributes)
				If (fa And FileAttributes.Directory) = FileAttributes.Directory Then
					e.DisplayText = "<DIR>"
				Else
					Dim path As String = CStr(gridView1.GetRowCellValue(rowHandler, colFullName))
					Dim fi As New FileInfo(path)
					e.DisplayText = fi.Length.ToString()
				End If
			End If
		End Sub
	End Class
End Namespace
