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
    public partial class Frm_DangNhap : Form
    {
        bool isAdmin = false;
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kn.KetNoi_DuLieu();
            string user = txtTenDN.Text;
            string pass = txtMatkhau.Text;
            string sql_login = "Select user_id, password from LOGIN where user_id = '" + user + "' AND password= '" + pass + "'"; 
            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();
            
            if (datRed.Read() == true)
            {
                isAdmin = true;
                MessageBox.Show("Đăng nhập thành công!");
                Form frmmain = new Frm_QLDSV(isAdmin);
                frmmain.Show();
                //Visible = false;
                this.Hide();
                kn.HuyKetNoi();
            }

            else
            {
                kn.KetNoi_DuLieu();
                string sql_login_student = "Select id_sv, pass from SINHVIEN_MK where id_sv = '" + user + "' AND pass = '" + pass + "'";
                SqlCommand cmd2 = new SqlCommand(sql_login_student, kn.cnn);
                SqlDataReader datRed2 = cmd2.ExecuteReader();
                if (datRed2.Read())
                {
                    isAdmin = false;
                    MessageBox.Show("Đăng nhập thành công!");
                    Form frmmain = new Frm_QLDSV(isAdmin);
                    frmmain.Show();
                    //Visible = false;
                    this.Hide();
                    kn.HuyKetNoi();
                }
                else
                {
                    MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
