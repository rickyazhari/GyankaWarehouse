using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for DimFact.xaml
    /// </summary>
    public partial class DimFact : UserControl
    {
        kon sql = new kon();
        public DimFact()
        {
            InitializeComponent();
            DataContext = App.DimFactViewModel;
            if (App.MenuViewModel.SelectedItem == Constant.DIMENSI_SELECTED)
            {
                App.DimFactViewModel.DT = sql.RequestData(Constant.DIMENSI_DIVISI);
                App.DimFactViewModel.HeadTabel = Constant.DIM_DIVISI;
            }
            else if (App.MenuViewModel.SelectedItem == Constant.FAKTA_SELECTED)
            {
                App.DimFactViewModel.HeadTabel = Constant.PREFIX_FAKTA + " " + Constant.KEBUTUHAN_USER;
                App.DimFactViewModel.DT = sql.RequestData(Constant.FAKTA_KEBUTUHAN_USER);
            }
        }
    }
}
