using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLDSV
{
    class Ketnoi
    {
        //Data Source=DESKTOP-2L7IN18\SQLEXPRESS;Initial Catalog=QL_Diem_SV;Integrated Security=True
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        /*
         Demo github by phucpt from Moola
         */
        //string strKetNoi = @"Data Source=MINHX0AWN;Initial Catalog=QL_Diem_SV;Integrated Security=True";
        //MINHX0AWN
        // string strKetNoi = @"Data Source=DESKTOP-0I1V82C\GIANG;Initial Catalog=QL_DIEM_SV;Integrated Security=True";

        //string strKetNoi = @"Data Source=DESKTOP-RU5LL1M\MAYA0;Initial Catalog=QL_DIEM_SV;Integrated Security=True";
        public void KetNoi_DuLieu()
        {
            //string strKetNoi = @"Data Source=DESKTOP-2L7IN18\SQLEXPRESS;Initial Catalog=QL_DIEM_SV;Integrated Security=True";
            string strKetNoi = @"data source=minhx0awn;initial catalog=TEST_BTL;integrated security=true";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable Lay_DuLieu(string Sql)
        {
            KetNoi_DuLieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void Thucthi(string sql)
        {
            KetNoi_DuLieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();

        }
    }
}
