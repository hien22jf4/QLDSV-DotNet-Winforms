
namespace QLDSV
{
    partial class Frm_BC_GiangVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BCgiangvien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BCgiangvien
            // 
            this.BCgiangvien.ActiveViewIndex = -1;
            this.BCgiangvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BCgiangvien.Cursor = System.Windows.Forms.Cursors.Default;
            this.BCgiangvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BCgiangvien.Location = new System.Drawing.Point(0, 0);
            this.BCgiangvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BCgiangvien.Name = "BCgiangvien";
            this.BCgiangvien.Size = new System.Drawing.Size(687, 528);
            this.BCgiangvien.TabIndex = 0;
            this.BCgiangvien.ToolPanelWidth = 133;
            // 
            // Frm_BC_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 528);
            this.Controls.Add(this.BCgiangvien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_BC_GiangVien";
            this.Text = "Frm_BC_GiangVien";
            this.Load += new System.EventHandler(this.Frm_BC_GiangVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer BCgiangvien;
    }
}