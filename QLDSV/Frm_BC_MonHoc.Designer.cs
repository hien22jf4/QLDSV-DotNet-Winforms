
namespace QLDSV
{
    partial class Frm_BC_MonHoc
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
            this.BCmonhoc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BCmonhoc
            // 
            this.BCmonhoc.ActiveViewIndex = -1;
            this.BCmonhoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BCmonhoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.BCmonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BCmonhoc.Location = new System.Drawing.Point(0, 0);
            this.BCmonhoc.Name = "BCmonhoc";
            this.BCmonhoc.Size = new System.Drawing.Size(1450, 812);
            this.BCmonhoc.TabIndex = 0;
            // 
            // Frm_BC_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 812);
            this.Controls.Add(this.BCmonhoc);
            this.Name = "Frm_BC_MonHoc";
            this.Text = "Frm_BC_MonHoc";
            this.Load += new System.EventHandler(this.Frm_BC_MonHoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer BCmonhoc;
    }
}