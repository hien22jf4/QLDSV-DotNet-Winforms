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

        public void GIANGVIEN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select * From GIANGVIEN");
            Gridgiangvien.DataSource = dta;
            HIENTHIDULIEU();
        }
        private void BANGKHOA()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select * From KHOA");
            cbo_makhoa.DataSource = dta;
            cbo_makhoa.DisplayMember = "id_khoa";
            cbo_makhoa.ValueMember = "id_khoa";
        }

        private void HIENTHIDULIEU()
        {
            txtmagv.DataBindings.Clear();
            txtmagv.DataBindings.Add("Text", Gridgiangvien.DataSource, "id_GV");

            txttengv.DataBindings.Clear();
            txttengv.DataBindings.Add("Text", Gridgiangvien.DataSource, "ten_GV");

            ngaysinh.DataBindings.Clear();
            ngaysinh.DataBindings.Add("Text", Gridgiangvien.DataSource, "dob_gv");

            txtgioitinh.DataBindings.Clear();
            txtgioitinh.DataBindings.Add("Text", Gridgiangvien.DataSource, "gioi_tinh");

            txtsodt.DataBindings.Clear();
            txtsodt.DataBindings.Add("Text", Gridgiangvien.DataSource, "So_dien_thoai");

            cbo_makhoa.DataBindings.Clear();
            cbo_makhoa.DataBindings.Add("Text", Gridgiangvien.DataSource, "id_khoa");
        }


        private void Frm_GiangVien_Load(object sender, EventArgs e)
        {
            GIANGVIEN();
            BANGKHOA();
            Gridgiangvien.Hide();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_GV from GIANGVIEN where id_GV = '" + txtmagv.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã giảng viên này đã tồn tại, nhập lại mã khác", "Thông báo");
                txtmagv.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu = "Insert into GIANGVIEN Values(' " + txtmagv.Text + "', '" + txttengv.Text + "',  '" +
                                      txtgioitinh.Text + "','" + ngaysinh.Value + "', '" + txtsodt.Text + "','" + txtquequan.Text + "','" + cbo_makhoa.Text + "')";

                kn.Thucthi(sql_luu);
                GIANGVIEN();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
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
                string sql_change = "update GIANGVIEN set ten_GV='" + txtmagv.Text + "',dob_gv ='" + ngaysinh.Value + "' ,gioi_tinh ='" + txtgioitinh.Text + "' ,So_dien_thoai ='" + txtsodt.Text + "' ,que_quan ='" + txtquequan.Text + "' ,id_khoa ='" + cbo_makhoa.Text + "' where id_GV='" + txtmagv.Text + "'";
                kn.Thucthi(sql_change);
                GIANGVIEN();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql_del = "delete GIANGVIEN where id_GV = '" + txtmagv.Text + "'";
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu(sql_del);
            Gridgiangvien.DataSource = dta;
            GIANGVIEN();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void btn_nhapmoi_Click(object sender, EventArgs e)
        {
            txtmagv.Text = txttengv.Text = txtquequan.Text = txtgioitinh.Text = txtsodt.Text = "";
            ngaysinh.Value = DateTime.Today;
            Gridgiangvien.Show();
        }
    }
}
