using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GyankaWarehouse.model
{
    public class DimensiFakta:Base
    {
        private DataTable dt;
        private string headerTabel;
        public DataTable DT
        {
            get {
                if (dt == null)
                {
                    dt = new DataTable();
                }    
                return dt; 
            }
            set { dt = value; }
        }

        public string HeaderTabel
        {
            get
            {
                return headerTabel;
            }
            set
            {
                headerTabel = value;
            }
        }
    }
}
