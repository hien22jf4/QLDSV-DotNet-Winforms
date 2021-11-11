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
    public partial class Frm_ChungChi : Form
    {
        public Frm_ChungChi()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void CHUNGCHI()
        {
            DataTable dta = new DataTable(); 
            dta = kn.Lay_DuLieu("Select *from CHUNGCHI");
            Grid_Chungchi.DataSource = dta;
            HIENTHIDULIEU();
        }

        private void HIENTHIDULIEU()
        {
            txt_machungchi.DataBindings.Clear();
            txt_machungchi.DataBindings.Add("Text", Grid_Chungchi.DataSource, "id_cc");
            txt_tenchungchi.DataBindings.Clear();
            txt_tenchungchi.DataBindings.Add("Text", Grid_Chungchi.DataSource, "ten_cc");
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void Frm_ChungChi_Load(object sender, EventArgs e)
        {
            CHUNGCHI();
            btn_them.Enabled = btn_xoa.Enabled = button3.Enabled = false;
        }

        private void btn_nhapmoi_Click(object sender, EventArgs e)
        {
            txt_machungchi.Text = txt_tenchungchi.Text = "";
            Grid_Chungchi.Show();
            btn_them.Enabled = btn_xoa.Enabled = button3.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_cc from CHUNGCHI where id_cc = '" + txt_machungchi.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã khoa này đã tồn tại, nhập lại mã khác", "Thông báo");
                txt_machungchi.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu = "Insert into CHUNGCHI Values(' " + txt_machungchi.Text + "', '" + txt_tenchungchi.Text + "')";
                kn.Thucthi(sql_luu);
                CHUNGCHI();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_cc from CHUNGCHI where id_cc = '" + txt_machungchi.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == false)
            {
                MessageBox.Show("Mã khoa không đúng, nhập lại mã khác", "Thông báo");
                txt_machungchi.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_change = "update CHUNGCHI set ten_cc='" + txt_tenchungchi.Text + "'where id_cc='" + txt_machungchi.Text + "'";
                kn.Thucthi(sql_change);
                CHUNGCHI();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql_del = "delete CHUNGCHI where id_cc = '" + txt_machungchi.Text + "'";
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu(sql_del);
            Grid_Chungchi.DataSource = dta;
            CHUNGCHI();
        }

        private void Grid_Chungchi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
