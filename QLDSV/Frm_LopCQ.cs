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
    public partial class Frm_LopCQ : Form
    {
        public Frm_LopCQ()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        private void LOPCQ()
        {
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu("Select *from LOPCQ");
            dataGridView_LopCQ.DataSource = dta;
            HIENTHIDULIEU();
        }
        private void BANGKHOA()
        {
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu("Select *from KHOA");
            cbo_fal_id.DataSource = dta;
            cbo_fal_id.DisplayMember = "id_khoa";
        }

        private void HIENTHIDULIEU()
        {
            txtb_class_id.DataBindings.Clear();
            txtb_class_id.DataBindings.Add("Text", dataGridView_LopCQ.DataSource, "id_lop");
            txtb_class_name.DataBindings.Clear();
            txtb_class_name.DataBindings.Add("Text", dataGridView_LopCQ.DataSource, "ten_lop");
            cbo_fal_id.DataBindings.Clear();
            cbo_fal_id.DataBindings.Add("Text", dataGridView_LopCQ.DataSource, "id_khoa");
            txtb_number.DataBindings.Clear();
            txtb_number.DataBindings.Add("Text", dataGridView_LopCQ.DataSource, "si_so");
        }

        private void Frm_LopCQ_Load(object sender, EventArgs e)
        {
            LOPCQ(); BANGKHOA();
            dataGridView_LopCQ.Hide();
            btn_change.Enabled = btn_del.Enabled = btn_add.Enabled = false;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txtb_class_id.Text = txtb_class_name.Text = txtb_number.Text = "";
            dataGridView_LopCQ.Show();
            btn_change.Enabled = btn_del.Enabled = btn_add.Enabled = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql_del = "delete LOPCQ where id_lop = '" + txtb_class_id.Text + "'";
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu(sql_del);
            dataGridView_LopCQ.DataSource = dta;
            LOPCQ();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_lop from LOPCQ where id_lop = '" + txtb_class_id.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == true)
            {
                MessageBox.Show("Mã lớp này đã tồn tại, nhập lại mã khác", "Thông báo");
                txtb_class_id.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_luu = "Insert into LOPCQ Values(' " + txtb_class_id.Text + "', '" + txtb_class_name.Text + "', '" + cbo_fal_id.Text + "', '" +
                                      txtb_number.Text + "')";

                kn.Thucthi(sql_luu);
                LOPCQ();
            }

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_lop from LOPCQ where id_lop = '" + txtb_class_id.Text + "'";
            SqlCommand cmd = new SqlCommand(strCheck, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if (doc_dl.Read() == false)
            {
                MessageBox.Show("Mã lớp không đúng, nhập lại mã khác", "Thông báo");
                txtb_class_id.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else
            {
                string sql_change = "update LOPCQ set si_so='" + txtb_number.Text + "',ten_lop ='" + txtb_class_name.Text + "' where id_lop='" + txtb_class_id.Text + "'";
                kn.Thucthi(sql_change);
                LOPCQ();
            }
        }
    }
}
