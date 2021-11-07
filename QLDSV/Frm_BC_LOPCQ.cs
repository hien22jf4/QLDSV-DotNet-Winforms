using CrystalDecisions.Windows.Forms;
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
    public partial class Frm_BC_LOPCQ : Form
    {
        Ketnoi kn = new Ketnoi();
        public Frm_BC_LOPCQ()
        {
            InitializeComponent();
        }

        private void Frm_BC_LOPCQ_Load(object sender, EventArgs e)
        {
            CrystalReportViewer crp = new CrystalReportViewer();
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("Select * from LOPCHINHQUY");

        }
    }
}
