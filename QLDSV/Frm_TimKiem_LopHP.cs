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
    public partial class Frm_TimKiem_LopHP : Form
    {
        public Frm_TimKiem_LopHP()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void LOPHP()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select *from LOPHOCPHAN order by id_lhp");
            cbo_class_id.DataSource = dta;
            cbo_class_id.DisplayMember = "id_lhp";
        }
        private void MONHOC()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select *from MONHOC order by id_mon");
            cbo_subject_id.DataSource = dta;
            cbo_subject_id.DisplayMember = "id_mon";
        }
        private void GIANGVIEN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select *from GIANGVIEN order by id_gv");
            cbo_teacher_id.DataSource = dta;
            cbo_teacher_id.DisplayMember = "id_gv";
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }
        
        private void Frm_LOPHP_Load(object sender, EventArgs e)
        {
            LOPHP();MONHOC();GIANGVIEN();
            dataGridView1.Hide();
        }

        private void rbtn_class_id_CheckedChanged(object sender, EventArgs e)
        {
            cbo_class_id.Focus();
            cbo_class_id.Enabled = true;
            cbo_subject_id.Enabled = false;
            cbo_teacher_id.Enabled = false;
        }

        private void rbtn_teacher_id_CheckedChanged(object sender, EventArgs e)
        {
            cbo_teacher_id.Focus();
            cbo_teacher_id.Enabled = true;
            cbo_subject_id.Enabled = false;
            cbo_class_id.Enabled = false;
        }

        private void rbtn_subject_id_CheckedChanged(object sender, EventArgs e)
        {
            cbo_subject_id.Focus();
            cbo_subject_id.Enabled = true;
            cbo_teacher_id.Enabled = false;
            cbo_class_id.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            DataTable dta = new DataTable();
            string sqlSearch;
            if (rbtn_class_id.Checked == true)
            {
                sqlSearch = "select * from LOPHOCPHAN where id_lhp = '" + cbo_class_id.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            if (rbtn_subject_id.Checked == true)
            {
                sqlSearch = "select * from LOPHOCPHAN where id_mon = '" + cbo_subject_id.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            if (rbtn_teacher_id.Checked == true)
            {
                sqlSearch = "select * from LOPHOCPHAN where id_gv = '" + cbo_teacher_id.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }

            dataGridView1.DataSource = dta;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
