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
    public partial class Frm_QLDSV : Form
    {
        private int childFormNumber = 0;
        private bool isAdmin = false;

        public Frm_QLDSV(bool isAdmin)
        {
            InitializeComponent();
            if (isAdmin)
            {
                //mnu_TRA_DIEM.Visible = true;
                //mnu_QL_Diem_SV.Visible = true;
            } else
            {
                cHỈNHSỬAToolStripMenuItem1.Visible = false;
                //mnu_TRA_DIEM.Visible = true;
                ////mnu_QL_Diem_SV.Visible = false;
                //bÁOCÁOToolStripMenuItem.Visible = false;
                //cHỈNHSỬAToolStripMenuItem.Visible = false;
            }
        }
        public Frm_QLDSV()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

  

        private void Frm_QLDSV_Load(object sender, EventArgs e)
        {

        }

        private void sINHVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_SinhVien();
            frm.Show();
        }

        private void sINHVIÊNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_SinhVien();
            frm.Show();
        }

        private void đIỂMHỌCPHẦNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_DiemHocPhan();
            frm.Show();
        }

        private void lỚPCHÍNHQUYToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_LopCQ();
            frm.Show();
        }

        private void lỚPHỌCPHẦNToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            Form frm = new Frm_TimKiem_LopHP();
            frm.Show();
        }

        private void gIẢNGVIÊNToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_GiangVien();
            frm.Show();
        }

        private void mÔNHỌCToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_MonHoc();
            frm.Show();
        }

        private void kHOAToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_Khoa();
            frm.Show();
        }

        private void tHÔNGTINSINHVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_SinhVien();
            frm.Show();
        }

        private void tRAĐIỂMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TraCuuDiemHocPhan();
            frm.Show();
        }

        private void lỚPCHÍNHQUYToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_LopCQ();
            frm.Show();
        }

        private void lỚPHỌCPHẦNToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_LopHP();
            frm.Show();
        }

        private void gIẢNGVIÊNToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_GiangVien();
            frm.Show();
        }

        private void mÔNHỌCToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_MonHoc();
            frm.Show();
        }

        private void kHOAToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_Khoa();
            frm.Show();
        }

        private void tHÔNGTINSINHVIÊNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_SinhVien();
            frm.Show();
        }

        private void đIỂMSINHVIÊNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_DiemHocPhan();
            frm.Show();
        }

        private void đĂNGNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_DangNhap();
            frm.Show();
        }

        private void dANHSÁCHSINHVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_BC_LOPCQ();
            frm.Show();
        }

        private void dANHSÁCHSINHVIÊNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_BC_LOPHP();
            frm.Show();
        }

        private void kHOAToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_BC_Khoa();
            frm.Show();
        }

        private void mÔNHỌCToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_BC_MonHoc();
            frm.Show();
        }

        private void gIẢNGVIÊNToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_BC_GiangVien();
            frm.Show();
        }

        private void đIỂMSINHVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_BCDiem();
            frm.Show();
        }

        private void tHÔNGTINLỚPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_BC_DS_LOPHP();
            frm.Show();
        }

        private void dANHSÁCHLỚPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_BC_DS_LOPCQ();
            frm.Show();
        }
    }
}
