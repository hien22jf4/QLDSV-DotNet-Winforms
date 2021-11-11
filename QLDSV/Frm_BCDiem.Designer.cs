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
            this.SuspendLayout();
            // 
            // btn_xembc
            // 
            this.btn_xembc.Location = new System.Drawing.Point(72, 167);
            this.btn_xembc.Name = "btn_xembc";
            this.btn_xembc.Size = new System.Drawing.Size(137, 52);
            this.btn_xembc.TabIndex = 7;
            this.btn_xembc.Text = "Xem báo cáo";
            this.btn_xembc.UseVisualStyleBackColor = true;
            this.btn_xembc.Click += new System.EventHandler(this.btn_xembc_Click);
            // 
            // txt_malhp
            // 
            this.txt_malhp.Location = new System.Drawing.Point(173, 82);
            this.txt_malhp.Name = "txt_malhp";
            this.txt_malhp.Size = new System.Drawing.Size(137, 27);
            this.txt_malhp.TabIndex = 6;
            // 
            // lbl_malhp
            // 
            this.lbl_malhp.AutoSize = true;
            this.lbl_malhp.Location = new System.Drawing.Point(25, 90);
            this.lbl_malhp.Name = "lbl_malhp";
            this.lbl_malhp.Size = new System.Drawing.Size(132, 20);
            this.lbl_malhp.TabIndex = 5;
            this.lbl_malhp.Text = "Mã lớp học phần";
            // 
            // CRV
            // 
            this.CRV.ActiveViewIndex = -1;
            this.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV.Location = new System.Drawing.Point(0, 0);
            this.CRV.Name = "CRV";
            this.CRV.Size = new System.Drawing.Size(1000, 562);
            this.CRV.TabIndex = 4;
            this.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_BCDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btn_xembc);
            this.Controls.Add(this.txt_malhp);
            this.Controls.Add(this.lbl_malhp);
            this.Controls.Add(this.CRV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_BCDiem";
            this.Text = "Frm_BCDiem";
            this.Load += new System.EventHandler(this.Frm_BCDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xembc;
        private System.Windows.Forms.TextBox txt_malhp;
        private System.Windows.Forms.Label lbl_malhp;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV;
    }
}