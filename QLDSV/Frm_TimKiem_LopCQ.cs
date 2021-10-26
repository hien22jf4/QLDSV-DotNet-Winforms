using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class Frm_TimKiem_LopCQ : Form
    {
        public Frm_TimKiem_LopCQ()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
       
        private void LOPCQ()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("Select *from LOPCQ");
            cbo_class_id.DataSource = dta;
            cbo_class_id.DisplayMember = "id_lop";
        }
        private void KHOA()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select *from KHOA");
            cbo_fal_id.DataSource = dta;
            cbo_fal_id.DisplayMember = "id_khoa"; 
        }
        private void Frm_TimKiem_LopCQ_Load(object sender, EventArgs e)
        {
            KHOA();LOPCQ();
            rbtn_class_id.Checked = true;
            rbtn_fal_id.Checked = false;
            dataGridView1.Hide();
        }

        private void rbtn_fal_id_CheckedChanged(object sender, EventArgs e)
        {
            cbo_fal_id.Focus();
            cbo_fal_id.Enabled = false;
            cbo_fal_id.Enabled = true;
        }
         private void rbtn_class_id_CheckedChanged(object sender, EventArgs e)
        {
            cbo_class_id.Focus();
            cbo_class_id.Enabled = true;
            cbo_fal_id.Enabled = false;
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
             DataTable dta = new DataTable();
            string sql_search;
            if(rbtn_class_id.Checked == true)
            {
                sql_search = "select *from LOPCQ where id_lop='" + cbo_class_id.Text + "' order by id_lop";
                dta = kn.Lay_DuLieu(sql_search);
            }
            if(rbtn_fal_id.Checked == true)
            {
                sql_search = "Select *from LOPCQ where id_khoa='" + cbo_fal_id.Text + "' order by id_khoa";
                dta = kn.Lay_DuLieu(sql_search);
            }
            dataGridView1.DataSource = dta;
            dataGridView1.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }
    }
}
