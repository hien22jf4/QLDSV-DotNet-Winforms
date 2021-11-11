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
    public partial class Frm_BCDiem : Form
    {
        public Frm_BCDiem()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void Frm_BCDiem_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select * from DIEMHOCPHAN ");
            BCDIEMSV BC = new BCDIEMSV();    // KHỞI TẠO BÁO CÁO
            BC.SetDataSource(dta);
            CRV.ReportSource = BC;
            CRV.Hide();
        }

        private void btn_xembc_Click(object sender, EventArgs e)
        {
            if (txt_malhp.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã lớp học phần ");
            }
            else
            {
                DataTable dta = new DataTable();
                dta = kn.Lay_DuLieu("select * from DIEMHOCPHAN where id_lhp = '" + txt_malhp.Text + "' ");
                BCDIEMSV BC = new BCDIEMSV();    // KHỞI TẠO BÁO CÁO
                BC.SetDataSource(dta);
                CRV.ReportSource = BC;
                CRV.Show();
            }
        }
    }
}
