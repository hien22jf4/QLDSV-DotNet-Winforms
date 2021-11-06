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
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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

        private void mnu_DangNhap_Click(object sender, EventArgs e)
        {
            Form frmDangNhap = new Frm_DangNhap();
            frmDangNhap.Show();
        }

        private void lỚPCHÍNHQUYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_LopCQ();
            frm.Show();
        }

        private void lỚPHỌCPHẦNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_LopHP();
            frm.Show();
        }

        private void lỚPCHÍNHQUYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_LopCQ();
            frm.Show();
        }

        private void lỚPHỌCPHẦNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_LopHP();
            frm.Show();
        }

        private void kHOAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = new Frm_Khoa();
            frm.Show();
        }

        private void mÔNHỌCToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = new Frm_MonHoc();
            frm.Show();
        }

        private void gIẢNGVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_GiangVien();
            frm.Show();
        }

        private void mÔNHỌCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_MonHoc();
            frm.Show();
        }

        private void kHOAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_TimKiem_Khoa();
            frm.Show();
        }

        private void gIẢNGVIÊNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_GiangVien();
            frm.Show();
        }

        private void lỚPCHÍNHQUYToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_BaoCaoLopCQ();
            frm.Show();
        }

        private void lỚPHỌCPHẦNToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = new FrmBaoCaoLopHP();
            frm.Show();
        }
    }
}
