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
    public partial class Frm_LopHP : Form
    {
        public Frm_LopHP()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void HIENTHIDULIEU()
        {
            txtb_class_id.DataBindings.Clear();
            txtb_class_id.DataBindings.Add("Text", dataGridView_LopHP.DataSource, "id_lhp");
            txtb_class_name.DataBindings.Clear();
            txtb_class_name.DataBindings.Add("Text", dataGridView_LopHP.DataSource, "ten_lhp");
            cbo_fal_id.DataBindings.Clear();
            cbo_fal_id.DataBindings.Add("Text", dataGridView_LopHP.DataSource, "id_gv");
            cbo_id_mon.DataBindings.Clear();
            cbo_id_mon.DataBindings.Add("Text", dataGridView_LopHP.DataSource, "id_mon");
            txtb_si_so.DataBindings.Clear();
            txtb_si_so.DataBindings.Add("Text", dataGridView_LopHP.DataSource, "si_so");
        }
        private void LOPHP()
        {
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu("Select *from LOPHOCPHAN");
            dataGridView_LopHP.DataSource = dta;
            HIENTHIDULIEU();
        }
        private void BANGGIANGVIEN_MONHOC()
        {
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu("Select *from GIANGVIEN_MONHOC");
            cbo_fal_id.DataSource = dta;
            cbo_fal_id.DisplayMember = "id_gv";
            cbo_id_mon.DataSource = dta;
            cbo_id_mon.DisplayMember = "id_mon";
        }
        private void Frm_LopHP_Load(object sender, EventArgs e)
        {
            LOPHP();BANGGIANGVIEN_MONHOC();
            btn_add.Enabled = btn_change.Enabled = btn_del.Enabled = false;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txtb_class_id.Text = txtb_class_name.Text = txtb_si_so.Text = "";
            dataGridView_LopHP.Show();
            btn_add.Enabled = btn_change.Enabled = btn_del.Enabled = true;

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql_del = "delete LOPHOCPHAN where id_lop = '" + txtb_class_id.Text + "'";
            DataTable dta = new DataTable(); dta = kn.Lay_DuLieu(sql_del);
            dataGridView_LopHP.DataSource = dta;
            LOPHP();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_lhp from LOPHOCPHAN where id_lhp = '" + txtb_class_id.Text + "'";
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
                string sql_luu = "Insert into LOPHOCPHAN Values(' " + txtb_class_id.Text + "', '" + txtb_class_name.Text + "', '" + cbo_id_mon.Text + "', '" +
                                      cbo_fal_id.Text + "', 0)";

                kn.Thucthi(sql_luu);
                LOPHP();
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            string strCheck = "Select id_lhp from LOPHOCPHAN where id_lhp = '" + txtb_class_id.Text + "'";
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
                string sql_change = "update LOPCQ set ten_lop ='" + txtb_class_name.Text + "' where id_lop='" + txtb_class_id.Text + "'";
                kn.Thucthi(sql_change);
                LOPHP();
            }
        }
    }
}
