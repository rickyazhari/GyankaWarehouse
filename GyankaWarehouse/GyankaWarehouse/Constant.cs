using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyankaWarehouse
{
    public class Constant
    {
        public const string ETL_SUKSES = "success";
        public const string ETL_FAILURE = "failure";

        public const string OLAP_SELECTED = "olap";
        public const string FAKTA_SELECTED = "fakta";
        public const string DIMENSI_SELECTED = "dimensi";

        public const string DIMENSI_DIVISI = "dim_divisi";
        public const string DIMENSI_EVENT = "dim_event";
        public const string DIMENSI_KELAMIN = "dim_jenis_kelamin";
        public const string DIMENSI_OPERASIONAL = "dim_operasional";
        public const string DIMENSI_TEST = "dim_test";
        public const string DIMENSI_USER = "dim_user";
        public const string DIMENSI_USIA = "dim_usia";
        public const string DIMENSI_WAKTU = "dim_waktu";
        public const string DIMENSI_PENDIDIKAN = "dim_pendidikan";

        public const string FAKTA_KEBUTUHAN_USER = "fact_kebutuhan_user";
        public const string FAKTA_KET_KARYAWAN = "fact_keterangan_karyawan";
        public const string FAKTA_LAMARAN_MASUK = "fact_lamaran_masuk";
        public const string FAKTA_PENDAPATAN = "fact_pendapatan";
        public const string FAKTA_COST_EVENT = "fact_pengeluaran_event";
        public const string FAKTA_COST_OPERASIONAL = "fact_pengeluaran_operasional";
        public const string FAKTA_COST_TEST = "fact_pengeluaran_test";

        public const string DIM_DIVISI = "Dimensi Divisi";
        public const string DIM_EVENT = "Dimensi Event";
        public const string DIM_KELAMIN = "Dimensi Kelamin";
        public const string DIM_OPERASIONAL = "Dimensi Operasional";
        public const string DIM_TEST = "Dimensi Test";
        public const string DIM_USER = "Dimensi User";
        public const string DIM_USIA = "Dimensi Usia";
        public const string DIM_WAKTU = "Dimensi Waktu";
        public const string DIM_PENDIDIKAN = "Dimensi Pendidikan";

        public const string KEBUTUHAN_USER = "Kebutuhan User";
        public const string KET_KARYAWAN = "Keterangan Karyawan";
        public const string LAMARAN_MASUK = "Lamaran Masuk";
        public const string PENDAPATAN = "Pendapatan";
        public const string COST_EVENT = "Pengeluaran Event";
        public const string COST_OPERSIONAL = "Pengeluaran Operasional";
        public const string COST_TEST = "Pengeluaran Test";

        public const string PREFIX_FAKTA = "Fakta";
    }
}
