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
    public partial class Frm_DiemHocPhan : Form
    {
        public Frm_DiemHocPhan()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        void DIEMHOCPHAN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("Select  distinct id_lhp from DIEMHOCPHAN");
            cbomlhp.DataSource = dta;
            DataTable dta1 = new DataTable();
            dta1 = kn.Lay_DuLieu("select *from DIEMHOCPHAN");
            cbomlhp.DisplayMember = "id_lhp";
            dataGridtklhp.DataSource = dta1;
            dataGridtklhp.Hide();
        }
        void HIENTHIDULIEU()
        {
            cbomlhp.DataBindings.Clear();
            cbomlhp.DataBindings.Add("Text", dataGridtklhp.DataSource, "id_lhp");

            textBox4.DataBindings.Clear();
            textBox4.DataBindings.Add("Text", dataGridtklhp.DataSource, "id_sv");

            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridtklhp.DataSource, "diem_cc");

            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridtklhp.DataSource, "diem_gk");

            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dataGridtklhp.DataSource, "diem_ck");
        }
        private void Frm_DiemHocPhan_Load(object sender, EventArgs e)
        {
            DIEMHOCPHAN();
            btn_search.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridtklhp.Show();
            btn_search.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_sv from DIEMHOCPHAN where id_sv != '" + textBox4.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã sinh viên này không tồn tại, nhập lại mã khác", "Thông báo");
                textBox4.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else {
            string sql_change = "update DIEMHOCPHAN set diem_cc='" + textBox1.Text + "',diem_gk ='" + textBox2.Text + "' ,diem_ck ='" + textBox3.Text + "' ,diem_tk =0,diem_he_4='F' where id_sv='" + textBox4.Text + "' and id_lhp = '"+cbomlhp.Text+"'";
            kn.Thucthi(sql_change);
            DIEMHOCPHAN();dataGridtklhp.Show();
                    }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }


    }
}
