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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class main : Window
    {
         public main()
        {
            InitializeComponent();
            submenu.Children.Add(new menu(this));
            Content.Children.Add(new olap());
            App.MenuViewModel.SelectedItem = Constant.OLAP_SELECTED;
        }

        private void exitbtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void laporan_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (App.MenuViewModel.SelectedItem != Constant.OLAP_SELECTED)
            {
                Content.Children.Clear();
                Content.Children.Add(new olap());
            }
            App.MenuViewModel.SetOlap();
            App.MenuViewModel.SelectedItem = Constant.OLAP_SELECTED;
            
        }

        private void fakta_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (App.MenuViewModel.SelectedItem != Constant.FAKTA_SELECTED)
            {
                App.MenuViewModel.SetFactMenu();
                App.MenuViewModel.SelectedItem = Constant.FAKTA_SELECTED;
            }

                Content.Children.Clear();
                Content.Children.Add(new DimFact());
        }

        private void dimensi_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (App.MenuViewModel.SelectedItem != Constant.DIMENSI_SELECTED)
            {
                App.MenuViewModel.SetDimensiMenu();
                App.MenuViewModel.SelectedItem = Constant.DIMENSI_SELECTED;
            }
                Content.Children.Clear();
                Content.Children.Add(new DimFact());
        }
    }
}
