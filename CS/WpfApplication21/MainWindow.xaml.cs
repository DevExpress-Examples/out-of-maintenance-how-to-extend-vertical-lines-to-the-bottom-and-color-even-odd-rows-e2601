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
                list.Add(new TestData() { Text = "Row" + i, Number = i });
            grid.DataSource = list;
        }
    }

    public class TestData
    {
        public string Text { get; set; }
        public int Number { get; set; }
    }
}
