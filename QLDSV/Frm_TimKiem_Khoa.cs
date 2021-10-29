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
    public partial class Frm_TimKiem_Khoa : Form
    {
        public Frm_TimKiem_Khoa()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void Frm_TimKiem_Khoa_Load(object sender, EventArgs e)
        {
            dataGridtkkhoa.Hide();
        }

        private void radmakhoa_CheckedChanged(object sender, EventArgs e)
        {
            txtmakhoa.Focus();
            txtmakhoa.Enabled = true;
            txttenkhoa.Enabled = false;
           
        }

        private void radtengv_CheckedChanged(object sender, EventArgs e)
        {
            txtmakhoa.Focus();
            txtmakhoa.Enabled = false;
            txttenkhoa.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridtkkhoa.Show();
            DataTable dta = new DataTable();
            string sqlSearch;
            if (radmakhoa.Checked == true)
            {
                sqlSearch = "select * from KHOA where id_khoa = '" + txtmakhoa.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            if (radtenkhoa.Checked == true)
            {
                sqlSearch = "select * from KHOA where ten_khoa = '" + txttenkhoa.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            dataGridtkkhoa.DataSource = dta;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }
    }
}
