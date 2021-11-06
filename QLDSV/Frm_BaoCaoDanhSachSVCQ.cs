using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Windows.Forms;

namespace QLDSV
{
    public partial class Frm_BaoCaoDanhSachSVCQ : Form
    {
        Ketnoi kn = new Ketnoi();

        void SINHVIEN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("Select *from LOPCQ");
            cbo_name.DataSource = dta;
            cbo_name.DisplayMember = "ten_lop";
        }
        public Frm_BaoCaoDanhSachSVCQ()
        {
            SINHVIEN();
           
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            string x = "select *from SINHVIEN where SINHVIEN.id_lop = '" + cbo_name.Text + "'";
            kn.Thucthi(x);
            SqlDataAdapter dta = new SqlDataAdapter(x, kn.cnn);
            DataSet ds = new DataSet();
            dta.Fill(ds);
            crv rpt = new crv();
        }

        
    }
}
