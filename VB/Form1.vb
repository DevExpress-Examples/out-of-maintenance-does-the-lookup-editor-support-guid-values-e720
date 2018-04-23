Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace GuidLookup
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataTable2 = New System.Data.DataTable()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.lookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1, Me.dataTable2})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			Me.dataColumn1.DataType = GetType(System.Guid)
			' 
			' dataTable2
			' 
			Me.dataTable2.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn2, Me.dataColumn3})
			Me.dataTable2.TableName = "Table2"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "ID"
			Me.dataColumn2.DataType = GetType(System.Guid)
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Item"
			' 
			' lookUpEdit1
			' 
			Me.lookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dataTable1, "Column1", True))
			Me.lookUpEdit1.Location = New System.Drawing.Point(8, 8)
			Me.lookUpEdit1.Name = "lookUpEdit1"
			Me.lookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Item", "Item", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
			Me.lookUpEdit1.Properties.DataSource = Me.dataTable2
			Me.lookUpEdit1.Properties.DisplayMember = "Item"
			Me.lookUpEdit1.Properties.ValueMember = "ID"
			Me.lookUpEdit1.Size = New System.Drawing.Size(233, 20)
			Me.lookUpEdit1.TabIndex = 0
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.dataTable1
			Me.gridControl1.Location = New System.Drawing.Point(8, 40)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(360, 182)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colColumn1, Me.gridColumn1})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
			' 
			' colColumn1
			' 
			Me.colColumn1.Caption = "Column1 (LookUp)"
			Me.colColumn1.ColumnEdit = Me.repositoryItemLookUpEdit1
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.Name = "colColumn1"
			Me.colColumn1.Visible = True
			Me.colColumn1.VisibleIndex = 0
			Me.colColumn1.Width = 126
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Item", "Item", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
			Me.repositoryItemLookUpEdit1.DataSource = Me.dataTable2
			Me.repositoryItemLookUpEdit1.DisplayMember = "Item"
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.ValueMember = "ID"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Column1 (Text)"
			Me.gridColumn1.FieldName = "Column1"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 1
			Me.gridColumn1.Width = 292
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.DataSource = Me.dataTable1
			Me.dataNavigator1.Location = New System.Drawing.Point(8, 232)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(233, 21)
			Me.dataNavigator1.TabIndex = 2
			Me.dataNavigator1.Text = "dataNavigator1"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(256, 8)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(112, 23)
			Me.simpleButton1.TabIndex = 3
			Me.simpleButton1.Text = "Get item ID"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(376, 258)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.lookUpEdit1)
			Me.Font = New System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.Name = "Form1"
			Me.Text = "Does the LookUp editor support GUID values?"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataTable2 As System.Data.DataTable
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private lookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private colColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Const Count As Integer = 5
			For i As Integer = 0 To Count - 1
				dataTable2.Rows.Add(New Object() {Guid.NewGuid(), "Item " & i.ToString()})
			Next i
			dataTable1.Rows.Add(New Object() {dataTable2.Rows(0)("ID")})
			dataTable1.Rows.Add(New Object() {dataTable2.Rows(dataTable2.Rows.Count - 1)("ID")})
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			Dim val As Object = lookUpEdit1.EditValue
			If (val Is Nothing OrElse val Is DBNull.Value) Then
				MessageBox.Show(String.Format("Item ID: {0}","n/a"))
			Else
				MessageBox.Show(String.Format("Item ID: {0}",val))
			End If
		End Sub
	End Class
End Namespace
