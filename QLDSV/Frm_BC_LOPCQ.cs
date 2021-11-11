using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class Frm_BC_LOPCQ : Form
    {
        Ketnoi kn = new Ketnoi();
        public Frm_BC_LOPCQ()
        {
            InitializeComponent();
        }

        private void Frm_BC_LOPCQ_Load(object sender, EventArgs e)
        {
            CrystalReportViewer crp = new CrystalReportViewer();
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("Select id_lop from LOPCQ");
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "id_lop";
            crystalReportViewer1.Hide();
        
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select * from SINHVIEN where id_lop = '" + comboBox1.Text + "' ");
            DSSV_CQ ds = new DSSV_CQ();    // KHỞI TẠO BÁO CÁO
            ds.SetDataSource(dta);
            crystalReportViewer1.ReportSource = ds;
            crystalReportViewer1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }
    }
}
