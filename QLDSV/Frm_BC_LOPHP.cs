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

namespace QLDSV
{
    public partial class Frm_BC_LOPHP : Form
    {
        public Frm_BC_LOPHP()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void Frm_BC_LOPHP_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("Select *from LOPHOCPHAN");
            cbo.DataSource = dta;
            cbo.DisplayMember = "ten_lhp";
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand();
            //SqlDataAdapter ada = new SqlDataAdapter();
            //cmd.CommandText = "Select SINHVIEN.id_sv,SINHVIEN.ten_sv,SINHVIEN.dob_sv,LOPHOCPHAN.ten_lhp from SINHVIEN,LOPHOCPHAN,SINHVIEN_LOPHP " +
            //    "where SINHVIEN.id_sv = SINHVIEN_LOPHP.id_sv and SINHVIEN_LOPHP.id_lhp = LOPHOCPHAN.id_lhp and LOPHOCPHAN.ten_lhp  = @ten_lhp";
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@ten_lhp", cbo.SelectedValue.ToString());
            //ada.SelectCommand = cmd;
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("Select SINHVIEN.id_sv,SINHVIEN.ten_sv,SINHVIEN.dob_sv,LOPHOCPHAN.ten_lhp from SINHVIEN,LOPHOCPHAN,SINHVIEN_LOPHP " +
                "where SINHVIEN.id_sv = SINHVIEN_LOPHP.id_sv and SINHVIEN_LOPHP.id_lhp = LOPHOCPHAN.id_lhp and LOPHOCPHAN.ten_lhp  = '" + cbo.Text + "'");
            DSSV_LOPHP rpt = new DSSV_LOPHP();
            rpt.SetDataSource(dta);
            crystalReportViewer1.ReportSource = rpt;
            //ada.Fill(dta);
            //DSSV_LOPHP rpt = new DSSV_LOPHP();
            //rpt.SetDataSource(dta);
            //Frm_BC_LOPHP f = new Frm_BC_LOPHP();
            //f.crystalReportViewer1.ReportSource = rpt;
            //f.ShowDialog();
        }
    }
}
