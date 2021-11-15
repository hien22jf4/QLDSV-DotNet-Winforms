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
    public partial class Frm_TimKiem_SinhVien : Form
    {
        public Frm_TimKiem_SinhVien()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        private void Frm_TimKiem_SinhVien_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DuLieu("Select* From LOPCQ order by id_lop ");
            cbo_malop.DataSource = dta;
            cbo_malop.DisplayMember = "id_lop";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;

            if (rad_masv.Checked == true)
            {
                string strCheck = "Select id_sv from SINHVIEN where id_sv = '" + txt_masv.Text + "'";
                SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
                SqlDataReader doc_dl = cmd.ExecuteReader();
                if (doc_dl.Read() == false)
                {
                    MessageBox.Show("Mã sinh viên này không tồn tại, nhập lại mã khác", "Thông báo");
                    txt_masv.Focus();
                    doc_dl.Close();
                    doc_dl.Dispose();
                }
                else
                {
                    sqltk = "Select * from SINHVIEN where id_sv like '" + txt_masv.Text + "'";
                    dta = kn.Lay_DuLieu(sqltk);
                }
               
            }

            if (rad_tensv.Checked == true)
            {
                string strCheck = "Select ten_sv from SINHVIEN where ten_sv = '" + txt_tensv.Text + "'";
                SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
                SqlDataReader doc_dl = cmd.ExecuteReader();
                if (doc_dl.Read() == false)
                {
                    MessageBox.Show("Tên sinh viên này không tồn tại, nhập lại tên khác", "Thông báo");
                    txt_masv.Focus();
                    doc_dl.Close();
                    doc_dl.Dispose();
                }
                else
                {
                    sqltk = "Select * from SINHVIEN where ten_sv '%" + txt_tensv.Text + "%'";
                    dta = kn.Lay_DuLieu(sqltk);
                }
            }

            if (rad_malop.Checked == true)
            {
                sqltk = "Select * from SINHVIEN  where id_lop like '" + cbo_malop.Text + "'";
                dta = kn.Lay_DuLieu(sqltk);
            }

            Grid_SinhVien.DataSource = dta;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void Grid_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
