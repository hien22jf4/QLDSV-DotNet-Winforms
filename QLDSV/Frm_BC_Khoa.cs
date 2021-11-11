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
    public partial class Frm_BC_Khoa : Form
    {
        public Frm_BC_Khoa()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void Frm_BC_Khoa_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select * from KHOA ");
            BC_TTK BC = new BC_TTK();
            BC.SetDataSource(dta);
            BCkhoa.ReportSource = BC;
        }
    }
}
