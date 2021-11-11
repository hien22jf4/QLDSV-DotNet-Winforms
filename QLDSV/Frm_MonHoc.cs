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
    public partial class Frm_MonHoc : Form
    {
        public Frm_MonHoc()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void MONHOC()
        {
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu("Select *from MONHOC");
            dataGridViewMonHoc.DataSource = dta;
            HIENTHIDULIEU();
        }
        private void KHOA()
        {
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu("Select *from KHOA");
            cbomakhoa.DataSource = dta;
            cbomakhoa.DisplayMember = "id_khoa";
        }
        private void HIENTHIDULIEU()
        {
            txtmamon.DataBindings.Clear();
            txtmamon.DataBindings.Add("Text", dataGridViewMonHoc.DataSource, "id_mon");
            txttenmon.DataBindings.Clear();
            txttenmon.DataBindings.Add("Text", dataGridViewMonHoc.DataSource, "ten_mon");
            cbomakhoa.DataBindings.Clear();
            cbomakhoa.DataBindings.Add("Text", dataGridViewMonHoc.DataSource, "id_khoa");
            txtsotinchi.DataBindings.Clear();
            txtsotinchi.DataBindings.Add("Text", dataGridViewMonHoc.DataSource, "so_tin_chi");
            txtdiemcc.DataBindings.Clear();
            txtdiemcc.DataBindings.Add("Text", dataGridViewMonHoc.DataSource, "he_so_cc");
            txtdiemgk.DataBindings.Clear();
            txtdiemgk.DataBindings.Add("Text", dataGridViewMonHoc.DataSource, "he_so_gk");
            txtdiemck.DataBindings.Clear();
            txtdiemck.DataBindings.Add("Text", dataGridViewMonHoc.DataSource, "he_so_ck");

        }
        private void Frm_MonHoc_Load(object sender, EventArgs e)
        {
            KHOA();
            MONHOC();
            dataGridViewMonHoc.Hide();
            btnchapnhat.Enabled = btnthem.Enabled = btnxoa.Enabled = false;
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            txtmamon.Text = txttenmon.Text = txtsotinchi.Text = txtdiemcc.Text = txtdiemck.Text = txtdiemgk.Text = "";
            dataGridViewMonHoc.Show();
            btnchapnhat.Enabled = btnthem.Enabled = btnxoa.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
            string strCheck = "Select id_mon from MONHOC where id_mon = '" + txtmamon.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã môn này đã tồn tại, nhập lại mã khác", "Thông báo");
                txtmamon.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu = "Insert into MONHOC Values(' " + txtmamon.Text + "', '" + txttenmon.Text + "','" + cbomakhoa.Text + "','" + txtsotinchi.Text + "', '" + txtdiemcc.Text + "','" + txtdiemgk.Text + "','" + txtdiemck.Text + "')";

                kn.Thucthi(sql_luu);
               MONHOC();
            }
        }

        private void btnchapnhat_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_mon from MONHOC where id_mon = '" + txtmamon.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == false)
            {
                MessageBox.Show("Mã môn không đúng, nhập lại mã khác", "Thông báo");
                txtmamon.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_change = "update MONHOC set ten_mon='" + txttenmon.Text + "',he_so_cc='" + txtdiemcc.Text + "',he_so_gk='" + txtdiemgk.Text + "',he_so_ck='" + txtdiemck.Text + "',so_tin_chi ='" + txtsotinchi.Text + "' where id_mon='" + txtmamon.Text + "'";
                kn.Thucthi(sql_change);
                MONHOC();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql_del = "delete MONHOC where id_mon = '" + txtmamon.Text + "'";
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu(sql_del);
            dataGridViewMonHoc.DataSource = dta;
            MONHOC();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void dataGridViewMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HIENTHIDULIEU();
        }

       
    }
}
