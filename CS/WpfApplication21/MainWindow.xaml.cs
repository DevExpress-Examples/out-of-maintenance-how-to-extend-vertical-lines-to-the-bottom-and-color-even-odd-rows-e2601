using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid;
using DevExpress.Data;

namespace WpfApplication21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<TestData> list = new List<TestData>();
            for (int i = 0; i < 10; i++)
                list.Add(new TestData() { Text = "Row" + i, Number1 = i, Number2 = i, Number3 = i, Number4 = i, Number5 = i });
            grid.ItemsSource = list;
            grid.Columns[0].Fixed = DevExpress.Xpf.Grid.FixedStyle.Left;
            grid.Columns[2].Fixed = DevExpress.Xpf.Grid.FixedStyle.Right;

            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            GridColumn column = grid.Columns[1];

            grid.TotalSummary.Add(new GridSummaryItem() {
                FieldName = column.FieldName,
                SummaryType = SummaryItemType.Sum,
                ShowInColumn = column.FieldName
            });

            column = grid.Columns[3];

            grid.TotalSummary.Add(new GridSummaryItem() {
                FieldName = column.FieldName,
                SummaryType = SummaryItemType.Sum,
                ShowInColumn = column.FieldName
            });
        }
    }

    public class TestData
    {
        public string Text { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
        public int Number4 { get; set; }
        public int Number5 { get; set; }
    }
}
