﻿using System;
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
    public partial class Frm_TraCuuDiemHocPhan : Form
    {
        public Frm_TraCuuDiemHocPhan()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void DIEMHOCPHAN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select *from DIEMHOCPHAN order by id_lhp");
            cbomlhp.DataSource = dta;
            cbomlhp.DisplayMember = "id_lhp";
        }
        private void SINHVIEN()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select *from DIEMHOCPHAN order by id_sv");
            cbomasv.DataSource = dta;
            cbomasv.DisplayMember = "id_sv";
        }
        private void Frm_TraCuuDiemHocPhan_Load(object sender, EventArgs e)
        {
            SINHVIEN();
            DIEMHOCPHAN();
            dataGridtklhp.Hide();
        }

        private void radmamon_CheckedChanged(object sender, EventArgs e)
        {
            cbomlhp.Focus();
            cbomlhp.Enabled = true;
            cbomasv.Enabled = false;
            
        }

        private void radtenmon_CheckedChanged(object sender, EventArgs e)
        {
            cbomlhp.Focus();
            cbomlhp.Enabled = false;
            cbomasv.Enabled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridtklhp.Show();
            DataTable dta = new DataTable();
            string sqlSearch;
            if (radmamon.Checked == true)
            {
                sqlSearch = "select * from DIEMHOCPHAN where id_lhp = '" + cbomlhp.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
            if (radtenmon.Checked == true)
            {
                sqlSearch = "select * from DIEMHOCPHAN where id_sv = '" + cbomasv.Text + "'";
                dta = kn.Lay_DuLieu(sqlSearch);
            }
           
            dataGridtklhp.DataSource = dta;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }
    }
}
