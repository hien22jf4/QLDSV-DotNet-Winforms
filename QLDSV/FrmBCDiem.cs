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
    public partial class FrmBCDiem : Form
    {
        public FrmBCDiem()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void FrmBCDiem_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DuLieu("select*from DIEMHOCPHAN ");
            BCDIEMSV BC = new BCDIEMSV();    // KHỞI TẠO BÁO CÁO
            BC.SetDataSource(dta);
            CRV.ReportSource = BC;
        }
    }
}
