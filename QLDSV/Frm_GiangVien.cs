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
    public partial class Frm_GiangVien : Form
    {
        public Frm_GiangVien()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        private void GIANGVIEN()
        {
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu("Select *from GIANGVIEN");
            dataGridViewGiangvien.DataSource = dta;
            HIENTHIDULIEU();
        }
        private void BANGKHOA()
        {
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu("Select *from KHOA");
            cbomakhoa.DataSource = dta;
            cbomakhoa.DisplayMember = "id_khoa";
        }

        private void HIENTHIDULIEU()
        {
            txtmagv.DataBindings.Clear();
            txtmagv.DataBindings.Add("Text", dataGridViewGiangvien.DataSource, "id_GV");
            txttengv.DataBindings.Clear();
            txttengv.DataBindings.Add("Text", dataGridViewGiangvien.DataSource, "ten_GV");
            lstgioitinh.DataBindings.Clear();
            lstgioitinh.DataBindings.Add("Text", dataGridViewGiangvien.DataSource, "gioi_tinh");
            dtpngaysinh.DataBindings.Clear();
            dtpngaysinh.DataBindings.Add("Text", dataGridViewGiangvien.DataSource, "dob_gv");
            txtsodt.DataBindings.Clear();
            txtsodt.DataBindings.Add("Text", dataGridViewGiangvien.DataSource, "So_dien_thoai");
            txtquequan.DataBindings.Clear();
            txtquequan.DataBindings.Add("Text", dataGridViewGiangvien.DataSource, "quequan");
            cbomakhoa.DataBindings.Clear();
            cbomakhoa.DataBindings.Add("Text", dataGridViewGiangvien.DataSource, "id_khoa");
        }


        private void Frm_GiangVien_Load(object sender, EventArgs e)
        {
            GIANGVIEN();
            BANGKHOA();
            dataGridViewGiangvien.Hide();
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            txtmagv.Text = txtmagv.Text = txtsodt.Text = dtpngaysinh.Text = lstgioitinh.Text = txtquequan.Text = "";
            dataGridViewGiangvien.Show();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_GV from GIANGVIEN where id_GV = '" + txtmagv.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã giảng viên  này đã tồn tại, nhập lại mã khác", "Thông báo");
                txtmagv.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu = "Insert into GIANGVIEN Values(' " + txtmagv.Text + "', '" + txttengv.Text + "','" + cbomakhoa.Text + "', '" + txtquequan.Text + "', '" + txtsodt.Text + "', '" + lstgioitinh.Text + "' , '" + dtpngaysinh.Text + "')";

                kn.Thucthi(sql_luu);
                GIANGVIEN();
            }
        }

        private void btnchapnhat_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_GV from GIANGVIEN where id_GV = '" + txtmagv.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == false)
            {
                MessageBox.Show("Mã giảng viên không đúng, nhập lại mã khác", "Thông báo");
                txtmagv.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_change = "update GIANGVIEN set ten_GV='" + txttengv.Text + "',dob_gv ='" + dtpngaysinh.Text + "',quequan ='" + txtquequan.Text + "' ,So_dien_thoai ='" + txtsodt.Text + "' ,gioi_tinh ='" + lstgioitinh.Text + "' where id_GV='" + txtmagv.Text + "'";
                kn.Thucthi(sql_change);
                GIANGVIEN();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql_del = "delete GIANGVIEN where id_GV = '" + txtmagv.Text + "'";
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu(sql_del);
            dataGridViewGiangvien.DataSource = dta;
            GIANGVIEN();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void dataGridViewGiangvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HIENTHIDULIEU();
        }
    }
}
