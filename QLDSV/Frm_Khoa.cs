using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLDSV
{
    public partial class Frm_Khoa : Form
    {
        public Frm_Khoa()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void KHOA()
        {
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu("Select *from KHOA");
            dataGridViewKhoa.DataSource = dta;
            HIENTHIDULIEU();
        }
        private void HIENTHIDULIEU()
        {
            txtmakhoa.DataBindings.Clear();
            txtmakhoa.DataBindings.Add("Text", dataGridViewKhoa.DataSource, "id_khoa");
            txttenkhoa.DataBindings.Clear();
            txttenkhoa.DataBindings.Add("Text", dataGridViewKhoa.DataSource, "ten_khoa");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dataGridViewKhoa.DataSource, "dia_chi");
            txtsodt.DataBindings.Clear();
            txtsodt.DataBindings.Add("Text", dataGridViewKhoa.DataSource, "so_dien_thoai");
            txtnamtl.DataBindings.Clear();
            txtnamtl.DataBindings.Add("Text", dataGridViewKhoa.DataSource, "nam_thanh_lap");
        }

        private void Frm_Khoa_Load(object sender, EventArgs e)
        {
            KHOA(); 
            dataGridViewKhoa.Hide();
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            txtmakhoa.Text = txttenkhoa.Text = txtdiachi.Text = txtsodt.Text=txtnamtl.Text="";
            dataGridViewKhoa.Show();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_khoa from KHOA where id_khoa = '" + txtmakhoa.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã khoa này đã tồn tại, nhập lại mã khác", "Thông báo");
                txtmakhoa.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu = "Insert into KHOA Values(' " + txtmakhoa.Text + "', '" + txttenkhoa.Text + "', '" + txtdiachi.Text + "', '" +
                                      txtsodt.Text + "', '" + txtnamtl.Text + "')";

                kn.Thucthi(sql_luu);
                KHOA();
            }
        }

        private void btnchapnhat_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_khoa from KHOA where id_khoa = '" + txtmakhoa.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == false)
            {
                MessageBox.Show("Mã khoa không đúng, nhập lại mã khác", "Thông báo");
                txtmakhoa.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_change = "update KHOA set ten_khoa='" + txttenkhoa.Text + "',dia_chi ='" + txtdiachi.Text + "' ,so_dien_thoai ='" + txtsodt.Text + "' ,nam_thanh_lap ='" + txtnamtl.Text + "'where id_khoa='" + txtmakhoa.Text + "'";
                kn.Thucthi(sql_change);
                KHOA();
            }

        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql_del = "delete KHOA where id_khoa = '" + txtmakhoa.Text + "'";
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu(sql_del);
            dataGridViewKhoa.DataSource = dta;
            KHOA();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }
    }
}
