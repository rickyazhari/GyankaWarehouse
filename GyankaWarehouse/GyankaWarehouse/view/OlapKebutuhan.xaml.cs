using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GyankaWarehouse.view
{
    /// <summary>
    /// Interaction logic for OlapKebutuhan.xaml
    /// </summary>
    public partial class OlapKebutuhan : UserControl
    {
        public OlapKebutuhan()
        {
            InitializeComponent();
        }

        private void PivotBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (pivotGridControl.Visibility == System.Windows.Visibility.Collapsed)
            {
                ChartCont.Visibility = System.Windows.Visibility.Collapsed;
                pivotGridControl.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PivotBtn_MouseLeftButtonUp(sender, e);
        }

        private void ChartBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (ChartCont.Visibility == System.Windows.Visibility.Collapsed)
            {
                pivotGridControl.Visibility = System.Windows.Visibility.Collapsed;
                ChartCont.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void TextBlock_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            ChartBtn_MouseLeftButtonUp(sender, e);
        }

        private void PrintBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Window parent = Window.GetWindow(this);
            pivotGridControl.ShowPrintPreviewDialog(parent, "Laporan Pendapatan", "Laporan Pendapatan");
        }

        private void TextBlock_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            PrintBtn_MouseLeftButtonUp(sender, e);
        }

    }
}
