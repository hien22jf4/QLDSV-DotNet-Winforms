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
    public partial class Frm_BaoCaoLopCQ : Form
    {
        public Frm_BaoCaoLopCQ()
        {
            InitializeComponent();
        }

        //private void Frm_BaoCaoLopCQ_Load(object sender, EventArgs e)
        //{
        //    crystalReportViewer1 rpt = new crystalReportViewer1();
        //    SqlConnection conn = new SqlConnection("Server=TIENPT\\SQL;Database=NorthWind;Uid=sa;Pwd=admin123");
        //    conn.Open();
        //    SqlDataAdapter dap = new SqlDataAdapter("Select * from Products", conn);
        //    DataSet ds = new DataSet();
        //    dap.Fill(ds);
        //    rpt.SetDataSource(ds.Tables[0]);
        //    crvProducts.ReportSource = rpt;
        //}
    }
}
