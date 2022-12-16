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
    Public Partial Class MainWindow
        Inherits System.Windows.Window

        Public Sub New()
            Me.InitializeComponent()
            Dim list As System.Collections.Generic.List(Of WpfApplication21.TestData) = New System.Collections.Generic.List(Of WpfApplication21.TestData)()
            For i As Integer = 0 To 10 - 1
                list.Add(New WpfApplication21.TestData() With {.Text = "Row" & i, .Number1 = i, .Number2 = i, .Number3 = i, .Number4 = i, .Number5 = i})
            Next

            Me.grid.ItemsSource = list
            Me.grid.Columns(CInt((0))).Fixed = DevExpress.Xpf.Grid.FixedStyle.Left
            Me.grid.Columns(CInt((2))).Fixed = DevExpress.Xpf.Grid.FixedStyle.Right
            AddHandler Me.Loaded, New System.Windows.RoutedEventHandler(AddressOf Me.MainWindow_Loaded)
        End Sub

        Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim column As DevExpress.Xpf.Grid.GridColumn = Me.grid.Columns(1)
            Me.grid.TotalSummary.Add(New DevExpress.Xpf.Grid.GridSummaryItem() With {.FieldName = column.FieldName, .SummaryType = DevExpress.Data.SummaryItemType.Sum, .ShowInColumn = column.FieldName})
            column = Me.grid.Columns(3)
            Me.grid.TotalSummary.Add(New DevExpress.Xpf.Grid.GridSummaryItem() With {.FieldName = column.FieldName, .SummaryType = DevExpress.Data.SummaryItemType.Sum, .ShowInColumn = column.FieldName})
        End Sub
    End Class

    Public Class TestData

        Public Property Text As String

        Public Property Number1 As Integer

        Public Property Number2 As Integer

        Public Property Number3 As Integer

        Public Property Number4 As Integer

        Public Property Number5 As Integer
    End Class
End Namespace
