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
    public partial class Frm_TimKiem_MonHoc : Form
    {
        public Frm_TimKiem_MonHoc()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void KHOA()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select *from KHOA order by id_khoa");
            cbomakhoa.DataSource = dta;
            cbomakhoa.DisplayMember = "id_khoa";
        }
        private void Frm_TimKiem_MonHoc_Load(object sender, EventArgs e)
        {
            KHOA();
            dataGridtkmonhoc.Hide();
        }

        private void radmamon_CheckedChanged(object sender, EventArgs e)
        {
            txtmamon.Focus();
            txtmamon.Enabled = true;
            txttenmon.Enabled = false;
            cbomakhoa.Enabled = false;
        }

        private void radtenmon_CheckedChanged(object sender, EventArgs e)
        {
            txtmamon.Focus();
            txtmamon.Enabled = false;
            txttenmon.Enabled = true;
            cbomakhoa.Enabled = false;
        }

        private void radmakhoa_CheckedChanged(object sender, EventArgs e)
        {
            txtmamon.Focus();
            txtmamon.Enabled = false;
            txttenmon.Enabled = false;
            cbomakhoa.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridtkmonhoc.Show();
            DataTable dta = new DataTable();
            string sqlSearch;
            if (radmamon.Checked == true)
            {
                sqlSearch = "select * from MONHOC where id_mon = '" + txtmamon.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            if (radtenmon.Checked == true)
            {
                sqlSearch = "select * from MONHOC where ten_mon = '" + txttenmon.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            if (radmakhoa.Checked == true)
            {
                sqlSearch = "select * from MONHOC where id_khoa= '" + cbomakhoa.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            dataGridtkmonhoc.DataSource = dta;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
