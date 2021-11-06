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
    public partial class Frm_BC_MonHoc : Form
    {
        public Frm_BC_MonHoc()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void Frm_BC_MonHoc_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select*from MONHOC ");
            BC_TTMH BC = new BC_TTMH();
            BC.SetDataSource(dta);
            BCmonhoc.ReportSource = BC;
        }
    }
}
