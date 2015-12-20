using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dts.Runtime;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.IntegrationServices;

namespace GyankaWarehouse.model
{
    public class EtlModel
    {
        private Package pack;

        public Package Pack
        {
            get
            {
                if (pack == null)
                {
                    pack = new Package();
                }
                return pack;
            }
            set { pack = value; }
        }

        private Application app;

        public Application App
        {
            get
            {
                if (app == null)
                {
                    app = new Application();
                }
                return app;
            }
            set { app = value; }
        }

        private string lokasi;

        public string Lokasi
        {
            get { return lokasi; }
            set { lokasi = value; }
        }
    }
}
