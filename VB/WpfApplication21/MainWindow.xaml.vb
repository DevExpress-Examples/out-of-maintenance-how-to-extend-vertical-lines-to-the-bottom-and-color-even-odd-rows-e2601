Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid
Imports DevExpress.Data

Namespace WpfApplication21
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			Dim list As New List(Of TestData)()
			For i As Integer = 0 To 9
				list.Add(New TestData() With {.Text = "Row" & i, .Number1 = i, .Number2 = i, .Number3 = i, .Number4 = i, .Number5 = i})
			Next i
			grid.ItemsSource = list
			grid.Columns(0).Fixed = DevExpress.Xpf.Grid.FixedStyle.Left
			grid.Columns(2).Fixed = DevExpress.Xpf.Grid.FixedStyle.Right

			AddHandler Loaded, AddressOf MainWindow_Loaded
		End Sub

		Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim column As GridColumn = grid.Columns(1)

			grid.TotalSummary.Add(New GridSummaryItem() With {.FieldName = column.FieldName, .SummaryType = SummaryItemType.Sum, .ShowInColumn = column.FieldName})

			column = grid.Columns(3)

			grid.TotalSummary.Add(New GridSummaryItem() With {.FieldName = column.FieldName, .SummaryType = SummaryItemType.Sum, .ShowInColumn = column.FieldName})
		End Sub
	End Class

	Public Class TestData
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateNumber1 As Integer
		Public Property Number1() As Integer
			Get
				Return privateNumber1
			End Get
			Set(ByVal value As Integer)
				privateNumber1 = value
			End Set
		End Property
		Private privateNumber2 As Integer
		Public Property Number2() As Integer
			Get
				Return privateNumber2
			End Get
			Set(ByVal value As Integer)
				privateNumber2 = value
			End Set
		End Property
		Private privateNumber3 As Integer
		Public Property Number3() As Integer
			Get
				Return privateNumber3
			End Get
			Set(ByVal value As Integer)
				privateNumber3 = value
			End Set
		End Property
		Private privateNumber4 As Integer
		Public Property Number4() As Integer
			Get
				Return privateNumber4
			End Get
			Set(ByVal value As Integer)
				privateNumber4 = value
			End Set
		End Property
		Private privateNumber5 As Integer
		Public Property Number5() As Integer
			Get
				Return privateNumber5
			End Get
			Set(ByVal value As Integer)
				privateNumber5 = value
			End Set
		End Property
	End Class
End Namespace
