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
    public partial class Frm_SinhVien : Form
    {
        public Frm_SinhVien()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        public void SINHVIEN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select * From SINHVIEN");
            Grid_Sinhvien.DataSource = dta;
            Hienthi_Dulieu();
        }
        public void LOPCQ()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select * From LOPCQ");
            cbo_malop.DataSource = dta;
            cbo_malop.DisplayMember = "id_lop";
            cbo_malop.ValueMember = "id_lop";
        }

        private void Hienthi_Dulieu()
        {
            txt_masv.DataBindings.Clear();
            txt_masv.DataBindings.Add("Text", Grid_Sinhvien.DataSource, "id_sv");

            txt_tensv.DataBindings.Clear();
            txt_tensv.DataBindings.Add("Text", Grid_Sinhvien.DataSource, "ten_sv");

            ngaysinh.DataBindings.Clear();
            ngaysinh.DataBindings.Add("Text", Grid_Sinhvien.DataSource, "dob_sv");

            txt_gioitinh.DataBindings.Clear();
            txt_gioitinh.DataBindings.Add("Text", Grid_Sinhvien.DataSource, "gioi_tinh");

            txt_quequan.DataBindings.Clear();
            txt_quequan.DataBindings.Add("Text", Grid_Sinhvien.DataSource, "que_quan");

            cbo_malop.DataBindings.Clear();
            cbo_malop.DataBindings.Add("Text", Grid_Sinhvien.DataSource, "id_lop");

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_sv from SINHVIEN where id_sv = '" + txt_masv.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == false)
            {
                MessageBox.Show("Mã sinh viên không đúng, nhập lại mã khác", "Thông báo");
                txt_masv.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_change = "update SINHVIEN set ten_sv='" + txt_tensv.Text + "',dob_sv ='" + ngaysinh.Value + "' ,gioi_tinh ='" + txt_gioitinh.Text + "' ,que_quan ='" + txt_quequan.Text + "' ,id_lop ='" + cbo_malop.Text + "' where id_sv='" + txt_masv.Text + "'";
                kn.Thucthi(sql_change);
                SINHVIEN();
            }
        }

        private void Frm_SinhVien_Load(object sender, EventArgs e)
        {
            SINHVIEN();
            LOPCQ();
            Grid_Sinhvien.Hide();
            btn_them.Enabled = btn_xoa.Enabled = button3.Enabled = false;
        }

        private void btn_nhapmoi_Click(object sender, EventArgs e)
        {
            txt_masv.Text = txt_tensv.Text = txt_quequan.Text = "";
            ngaysinh.Value = DateTime.Today;
            Grid_Sinhvien.Show();
            btn_them.Enabled = btn_xoa.Enabled = button3.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_sv from SINHVIEN where id_sv = '" + txt_masv.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại, nhập lại mã khác", "Thông báo");
                txt_masv.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu = "Insert into SINHVIEN Values(' " + txt_masv.Text + "', '" + txt_tensv.Text + "', '" + ngaysinh.Value + "', '" +
                                      txt_gioitinh.Text + "', '" + txt_quequan.Text + "','" + cbo_malop.Text + "')";

                kn.Thucthi(sql_luu);
                SINHVIEN();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql_del = "delete SINHVIEN where id_sv = '" + txt_masv.Text + "'";
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu(sql_del);
            Grid_Sinhvien.DataSource = dta;
            SINHVIEN();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
