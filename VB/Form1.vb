Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTreeList.Nodes

Namespace WindowsFormsApplication16
	Partial Public Class Form1
		Inherits Form
		Private fakeList As New BindingList(Of ChildObject)()

		Public Sub New()
			InitializeComponent()

			For i As Integer = 0 To 199
				fakeList.Add(New ChildObject())
			Next i

		End Sub

		Private Sub UpdateTreeListData(ByVal parent As Parent)
			tree.BeginUnboundLoad()
			Try
                For j As Integer = 0 To 199
                    Dim node As TreeListNode = tree.AppendNode(New Object() {"Foo" & j.ToString(), "Bar" & j.ToString()}, -1)
                    For k As Integer = 0 To 9
                        Dim node2 As TreeListNode = tree.AppendNode(New Object() {"Parent:" & parent.Name & "_Foo" & j.ToString() & "_" & k.ToString(), "Bar" & j.ToString()}, node)
                        For n As Integer = 0 To 9
                            tree.AppendNode(New Object() {"Foo" & j.ToString() & "_" & k.ToString() & "_" & n.ToString(), "Bar" & j.ToString()}, node2)
                        Next n

                    Next k
                Next j
            Finally
                tree.EndUnboundLoad()
			End Try
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			bindingSource1.Add(New Parent("Parent1"))
			bindingSource1.Add(New Parent("Parent2"))
			bindingSource1.Add(New Parent("Parent3"))
			bindingSource1.Add(New Parent("Parent4"))
			gridControl1.Controls.Add(tree)
			tree.Visible = False
		End Sub


		Private Sub gridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs) Handles gridView1.MasterRowGetChildList
			e.ChildList = fakeList
			Dim parent As Parent = TryCast((TryCast(sender, GridView)).GetRow(e.RowHandle), Parent)
			UpdateTreeListData(parent)
		End Sub

		Private Sub UpdateTreeVisibility(ByVal view As GridView)
			If view Is Nothing Then
				Return
			End If
			tree.SetBounds(view.ViewRect.X, view.ViewRect.Y, view.ViewRect.Width, view.ViewRect.Height)
			tree.Tag = view
			tree.Visible = True
		End Sub
		Private Sub gridView1_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles gridView1.MasterRowExpanded
			Dim view As GridView = TryCast(gridView1.GetDetailView(e.RowHandle, e.RelationIndex), GridView)
			UpdateTreeVisibility(view)
		End Sub

		Private Sub gridView1_TopRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.TopRowChanged
            BeginInvoke(New MethodInvoker(AddressOf UpdateVisibility))

		End Sub
		
        Private Sub UpdateVisibility()
            Dim view As GridView = TryCast(tree.Tag, GridView)
            If tree.Visible Then
                UpdateTreeVisibility(view)
            End If
        End Sub

		Private Sub gridView1_MasterRowCollapsing(ByVal sender As Object, ByVal e As MasterRowCanExpandEventArgs) Handles gridView1.MasterRowCollapsing
			tree.Tag = Nothing
			tree.Visible = False
		End Sub

		Private Sub gridView2_Layout(ByVal sender As Object, ByVal e As EventArgs) Handles gridView2.Layout
			Dim view As GridView = TryCast(sender, GridView)
			UpdateTreeVisibility(view)
		End Sub

		Private Sub gridControl1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridControl1.SizeChanged
			Dim view As GridView = TryCast(tree.Tag, GridView)
			If tree.Visible Then
				UpdateTreeVisibility(view)
			End If
		End Sub
	End Class

	Public Class Parent

		Public Sub New(ByVal name As String)
			Me._Name = name
		End Sub


		Public Sub New()

		End Sub

		Private _ID As Integer
		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				_ID = value
			End Set
		End Property

		Private _Name As String
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				_Name = value
			End Set
		End Property

		Private _FakeCollection As New BindingList(Of ChildObject)()
		Public ReadOnly Property FakeCollection() As BindingList(Of ChildObject)
			Get
				Return _FakeCollection
			End Get
		End Property

	End Class

	Public Class ChildObject

		Public Sub New()

		End Sub

		Private _Foo As String
		Public Property Foo() As String
			Get
				Return _Foo
			End Get
			Set(ByVal value As String)
				_Foo = value
			End Set
		End Property

		Private _Bar As String
		Public Property Bar() As String
			Get
				Return _Bar
			End Get
			Set(ByVal value As String)
				_Bar = value
			End Set
		End Property
	End Class
End Namespace
