
namespace QLDSV
{
    partial class Frm_BC_Khoa
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
            this.BCkhoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BCkhoa
            // 
            this.BCkhoa.ActiveViewIndex = -1;
            this.BCkhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BCkhoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.BCkhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BCkhoa.Location = new System.Drawing.Point(0, 0);
            this.BCkhoa.Name = "BCkhoa";
            this.BCkhoa.Size = new System.Drawing.Size(1450, 812);
            this.BCkhoa.TabIndex = 0;
            // 
            // Frm_BC_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 812);
            this.Controls.Add(this.BCkhoa);
            this.Name = "Frm_BC_Khoa";
            this.Text = "Frm_BC_Khoa";
            this.Load += new System.EventHandler(this.Frm_BC_Khoa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer BCkhoa;
    }
}