using System;
using GyankaWarehouse.model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dts.Runtime;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.IntegrationServices;
using System.ComponentModel;
using System.Windows;

namespace GyankaWarehouse.viewmodel
{
    public class EtlViewModel:BaseBindable
    {
        private EtlModel etl;

        public EtlModel Etl
        {
            get
            {
                if (etl == null)
                {
                    etl = new EtlModel();
                }
                return etl;
            }
            set { etl = value; }
        }


        public EtlViewModel()
        {

        }

        private Package run_etl(Package x, string y, Microsoft.SqlServer.Dts.Runtime.Application z)
        {
            x = z.LoadPackage(@y, null);
            return x;
        }

        public Microsoft.SqlServer.Dts.Runtime.DTSExecResult load_etl()
        {
            Microsoft.SqlServer.Dts.Runtime.DTSExecResult x = new DTSExecResult(); ;
            Etl.Lokasi = Environment.CurrentDirectory.ToString() + "\\Resources\\Package.dtsx";
            try
             {
                Etl.Pack = run_etl(Etl.Pack, Etl.Lokasi, Etl.App);
                 x = Etl.Pack.Execute();
             }
             catch (Exception ex)
             {
                MessageBox.Show("Terjadi kesalahan pada sistem dalam membaca paket, eksekusi dibatalkan", "General Error", MessageBoxButton.OK);
               
             }
            return x;
        }
    }
}
