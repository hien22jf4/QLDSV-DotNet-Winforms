using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLDSV
{
    public partial class Frm_TimKiem_GiangVien : Form
    {
        public Frm_TimKiem_GiangVien()
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
        private void radmagv_CheckedChanged(object sender, EventArgs e)
        {
            txtmagv.Focus();
            txtmagv.Enabled = true;
            txttengv.Enabled = false;
            cbomakhoa.Enabled = false;
        }

        private void Frm_TimKiem_GiangVien_Load(object sender, EventArgs e)
        {
            KHOA();
            dataGridtkgiangvien.Hide();

        }

        private void radtengv_CheckedChanged(object sender, EventArgs e)
        {
            txtmagv.Focus();
            txtmagv.Enabled = false;
            txttengv.Enabled = true;
            cbomakhoa.Enabled = false;
        }

        private void radmakhoa_CheckedChanged(object sender, EventArgs e)
        {
            txtmagv.Focus();
            txtmagv.Enabled = false;
            txttengv.Enabled = false;
            cbomakhoa.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridtkgiangvien.Show();
            DataTable dta = new DataTable();
            string sqlSearch;
            if (radmagv.Checked == true)
            {
                sqlSearch = "select * from GIANGVIEN where id_GV = '" + txtmagv.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            if (radtengv.Checked == true)
            {
                sqlSearch = "select * from GIANGVIEN where ten_GV = '" + txttengv.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            if (radmakhoa.Checked == true)
            {
                sqlSearch = "select * from GIANGVIEN where id_khoa= '" + cbomakhoa.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            dataGridtkgiangvien.DataSource = dta;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }
    }
}
