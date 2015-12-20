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
    /// Interaction logic for menu.xaml
    /// </summary>
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
            DataContext = App.MenuViewModel;
        }

        private void ListMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // MessageBox.Show(ListMenu.SelectedIndex.ToString());
           // MessageBox.Show(App.MenuViewModel.Menu[ListMenu.SelectedIndex].NamaMenu.ToString());
            if (App.MenuViewModel.SelectedItem == Constant.DIMENSI_SELECTED)
            {
                switch (ListMenu.SelectedIndex)
                {
                    case 1 :
                        App.DimFactViewModel.HeadTabel = Constant.DIM_EVENT;
                        App.DimFactViewModel.GenerateTabel(Constant.DIMENSI_EVENT);
                        break;

                    case 2:
                        App.DimFactViewModel.Generateheader(Constant.DIM_KELAMIN);
                        App.DimFactViewModel.GenerateTabel(Constant.DIMENSI_KELAMIN);
                        break;

                    case 3:
                        App.DimFactViewModel.Generateheader(Constant.DIM_OPERASIONAL);
                        App.DimFactViewModel.GenerateTabel(Constant.DIMENSI_OPERASIONAL);
                        break;

                    case 4:
                        App.DimFactViewModel.Generateheader(Constant.DIM_PENDIDIKAN);
                        App.DimFactViewModel.GenerateTabel(Constant.DIMENSI_PENDIDIKAN);
                        break;

                    case 5:
                        App.DimFactViewModel.Generateheader(Constant.DIM_TEST);
                        App.DimFactViewModel.GenerateTabel(Constant.DIMENSI_TEST);
                        break;

                    case 6:
                        App.DimFactViewModel.Generateheader(Constant.DIM_USER);
                        App.DimFactViewModel.GenerateTabel(Constant.DIMENSI_USER);
                        break;

                    case 7:
                        App.DimFactViewModel.Generateheader(Constant.DIM_USIA);
                        App.DimFactViewModel.GenerateTabel(Constant.DIMENSI_USIA);
                        break;

                    case 8:
                        App.DimFactViewModel.Generateheader(Constant.DIM_WAKTU);
                        App.DimFactViewModel.GenerateTabel(Constant.DIMENSI_WAKTU);
                        break;

                    default :
                        App.DimFactViewModel.Generateheader(Constant.DIM_DIVISI);
                        App.DimFactViewModel.GenerateTabel(Constant.DIMENSI_DIVISI);
                        break;
                }
            }

            if (App.MenuViewModel.SelectedItem == Constant.FAKTA_SELECTED)
            {
                switch (ListMenu.SelectedIndex)
                {
                    case 1:
                        App.DimFactViewModel.Generateheader(Constant.PREFIX_FAKTA +" "+ Constant.KET_KARYAWAN);
                        App.DimFactViewModel.GenerateTabel(Constant.FAKTA_KET_KARYAWAN);
                        break;

                    case 2:
                        App.DimFactViewModel.Generateheader(Constant.PREFIX_FAKTA + " " + Constant.PENDAPATAN);
                        App.DimFactViewModel.GenerateTabel(Constant.FAKTA_PENDAPATAN);
                        break;

                    case 3:
                        App.DimFactViewModel.Generateheader(Constant.PREFIX_FAKTA + " " + Constant.COST_EVENT);
                        App.DimFactViewModel.GenerateTabel(Constant.FAKTA_COST_EVENT);
                        break;

                    case 4:
                        App.DimFactViewModel.Generateheader(Constant.PREFIX_FAKTA + " " + Constant.COST_OPERSIONAL);
                        App.DimFactViewModel.GenerateTabel(Constant.FAKTA_COST_OPERASIONAL);
                        break;

                    case 5:
                        App.DimFactViewModel.Generateheader(Constant.PREFIX_FAKTA + " " + Constant.COST_TEST);
                        App.DimFactViewModel.GenerateTabel(Constant.FAKTA_COST_TEST);
                        break;

                    case 6:
                        App.DimFactViewModel.Generateheader(Constant.PREFIX_FAKTA + " " + Constant.LAMARAN_MASUK);
                        App.DimFactViewModel.GenerateTabel(Constant.FAKTA_LAMARAN_MASUK);
                        break;

                    default:
                        App.DimFactViewModel.Generateheader(Constant.PREFIX_FAKTA + " " + Constant.KEBUTUHAN_USER);
                        App.DimFactViewModel.GenerateTabel(Constant.FAKTA_KEBUTUHAN_USER);
                        break;
                }
            }
        }
    }
}
