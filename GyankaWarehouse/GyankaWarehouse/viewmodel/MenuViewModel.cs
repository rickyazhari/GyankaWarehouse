using GyankaWarehouse.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace GyankaWarehouse.viewmodel
{
    public class MenuViewModel : BaseBindable
    {
        private string selectedItem = string.Empty;

        public string SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; }
        }

        private ObservableCollection<MenuModel> menu;

        public ObservableCollection<MenuModel> Menu
        {
            get
            {
                if (menu == null)
                {
                    menu = new ObservableCollection<MenuModel>();
                } 
                return menu; }
            set { TryChangeProperty(ref menu, value, "Menu"); }
        }

        public MenuViewModel()
        {
                SetOlap();
        }

        public void SetDimensiMenu()
        {
            Menu.Clear();
            Menu.Add(new MenuModel() { NamaMenu = Constant.DIM_DIVISI });
            Menu.Add(new MenuModel() { NamaMenu = Constant.DIM_EVENT});
            Menu.Add(new MenuModel() { NamaMenu = Constant.DIM_KELAMIN });
            Menu.Add(new MenuModel() { NamaMenu = Constant.DIM_OPERASIONAL });
            Menu.Add(new MenuModel() { NamaMenu = Constant.DIM_PENDIDIKAN});
            Menu.Add(new MenuModel(){NamaMenu = Constant.DIM_TEST});
            Menu.Add(new MenuModel() { NamaMenu = Constant.DIM_USER });
            Menu.Add(new MenuModel() { NamaMenu = Constant.DIM_USIA });
            menu.Add(new MenuModel() { NamaMenu = Constant.DIM_WAKTU });
        }

        public void SetFactMenu()
        {
            Menu.Clear();
            Menu.Add(new MenuModel(){NamaMenu = Constant.PREFIX_FAKTA+" "+Constant.KEBUTUHAN_USER});
            Menu.Add(new MenuModel() { NamaMenu = Constant.PREFIX_FAKTA + " " + Constant.KET_KARYAWAN });
            Menu.Add(new MenuModel() { NamaMenu = Constant.PREFIX_FAKTA + " " + Constant.PENDAPATAN});
            Menu.Add(new MenuModel() { NamaMenu = Constant.PREFIX_FAKTA + " " + Constant.COST_EVENT});
            Menu.Add(new MenuModel() { NamaMenu = Constant.PREFIX_FAKTA + " " + Constant.COST_OPERSIONAL });
            Menu.Add(new MenuModel() { NamaMenu = Constant.PREFIX_FAKTA + " " + Constant.COST_TEST});
            Menu.Add(new MenuModel() { NamaMenu = Constant.PREFIX_FAKTA + " " + Constant.LAMARAN_MASUK });
        }

        public void SetOlap()
        {
            Menu.Clear();
            Menu.Add(new MenuModel() { NamaMenu = Constant.PENDAPATAN});
            Menu.Add(new MenuModel() { NamaMenu = Constant.LAMARAN_MASUK});
            Menu.Add(new MenuModel() { NamaMenu = Constant.COST_EVENT}); 
            Menu.Add(new MenuModel() { NamaMenu = Constant.COST_OPERSIONAL });
            Menu.Add(new MenuModel() { NamaMenu = Constant.COST_TEST });
            Menu.Add(new MenuModel() { NamaMenu = Constant.KET_KARYAWAN });
            Menu.Add(new MenuModel() { NamaMenu = Constant.KEBUTUHAN_USER });
        }

    }
}
