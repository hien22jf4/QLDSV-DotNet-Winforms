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
    public partial class Frm_BC_GiangVien : Form
    {
        public Frm_BC_GiangVien()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void Frm_BC_GiangVien_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select*from GIANGVIEN ");
            BC_TTGV BC = new BC_TTGV();    
            BC.SetDataSource(dta);
            BCgiangvien.ReportSource = BC;

        }
    }
}
