namespace QLDSV
{
    partial class Frm_BCDiem
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
            this.btn_xembc = new System.Windows.Forms.Button();
            this.txt_malhp = new System.Windows.Forms.TextBox();
            this.lbl_malhp = new System.Windows.Forms.Label();
            this.CRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xembc
            // 
            this.btn_xembc.Location = new System.Drawing.Point(376, 31);
            this.btn_xembc.Name = "btn_xembc";
            this.btn_xembc.Size = new System.Drawing.Size(95, 23);
            this.btn_xembc.TabIndex = 7;
            this.btn_xembc.Text = "In báo cáo";
            this.btn_xembc.UseVisualStyleBackColor = true;
            this.btn_xembc.Click += new System.EventHandler(this.btn_xembc_Click);
            // 
            // txt_malhp
            // 
            this.txt_malhp.Location = new System.Drawing.Point(214, 31);
            this.txt_malhp.Name = "txt_malhp";
            this.txt_malhp.Size = new System.Drawing.Size(137, 22);
            this.txt_malhp.TabIndex = 6;
            // 
            // lbl_malhp
            // 
            this.lbl_malhp.AutoSize = true;
            this.lbl_malhp.Location = new System.Drawing.Point(79, 37);
            this.lbl_malhp.Name = "lbl_malhp";
            this.lbl_malhp.Size = new System.Drawing.Size(110, 16);
            this.lbl_malhp.TabIndex = 5;
            this.lbl_malhp.Text = "Mã lớp học phần:";
            // 
            // CRV
            // 
            this.CRV.ActiveViewIndex = -1;
            this.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CRV.Location = new System.Drawing.Point(0, 88);
            this.CRV.Name = "CRV";
            this.CRV.Size = new System.Drawing.Size(789, 474);
            this.CRV.TabIndex = 4;
            this.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_malhp);
            this.panel1.Controls.Add(this.btn_xembc);
            this.panel1.Controls.Add(this.txt_malhp);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 70);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Điền mã lớp học phần để in danh sách điểm sinh viên";
            // 
            // Frm_BCDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CRV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_BCDiem";
            this.Text = "Frm_BCDiem";
            this.Load += new System.EventHandler(this.Frm_BCDiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_xembc;
        private System.Windows.Forms.TextBox txt_malhp;
        private System.Windows.Forms.Label lbl_malhp;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}