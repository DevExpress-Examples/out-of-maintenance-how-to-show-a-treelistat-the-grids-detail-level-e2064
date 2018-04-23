Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication16
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
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.tree = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tree, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView2
			' 
			Me.gridView2.DetailHeight = 999
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
'			Me.gridView2.Layout += New System.EventHandler(Me.gridView2_Layout);
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.bindingSource1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.gridView2
			gridLevelNode1.RelationName = "FakeCollection"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(695, 487)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
'			Me.gridControl1.SizeChanged += New System.EventHandler(Me.gridControl1_SizeChanged);
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataSource = GetType(WindowsFormsApplication16.Parent)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colName})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.AllowExpandEmptyDetails = True
			Me.gridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
			Me.gridView1.OptionsDetail.AllowZoomDetail = False
			Me.gridView1.OptionsDetail.ShowDetailTabs = False
			Me.gridView1.OptionsDetail.SmartDetailExpand = False
			Me.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
			Me.gridView1.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveHorzScroll
'			Me.gridView1.TopRowChanged += New System.EventHandler(Me.gridView1_TopRowChanged);
'			Me.gridView1.MasterRowCollapsing += New DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventHandler(Me.gridView1_MasterRowCollapsing);
'			Me.gridView1.MasterRowGetChildList += New DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(Me.gridView1_MasterRowGetChildList);
'			Me.gridView1.MasterRowExpanded += New DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(Me.gridView1_MasterRowExpanded);
			' 
			' colID
			' 
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' colName
			' 
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 1
			' 
			' tree
			' 
			Me.tree.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2})
			Me.tree.Location = New System.Drawing.Point(39, 128)
			Me.tree.Name = "tree"
			Me.tree.Size = New System.Drawing.Size(400, 200)
			Me.tree.TabIndex = 1
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Foo"
			Me.treeListColumn1.FieldName = "Foo"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "Bar"
			Me.treeListColumn2.FieldName = "Bar"
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(695, 487)
			Me.Controls.Add(Me.tree)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tree, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private tree As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
	End Class
End Namespace

