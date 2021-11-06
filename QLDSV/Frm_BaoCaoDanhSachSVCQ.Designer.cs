namespace QLDSV
{
    partial class Frm_BaoCaoDanhSachSVCQ
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
            this.cbo_name = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rpvDanhSachSVCQ = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.DSSV_CQ1 = new QLDSV.DSSV_CQ();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_name
            // 
            this.cbo_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_name.FormattingEnabled = true;
            this.cbo_name.Location = new System.Drawing.Point(144, 31);
            this.cbo_name.Name = "cbo_name";
            this.cbo_name.Size = new System.Drawing.Size(195, 21);
            this.cbo_name.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.cbo_name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp";
            this.groupBox1.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(70, 39);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(46, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Tên lớp:";
            // 
            // btn_print
            // 
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_print.Location = new System.Drawing.Point(361, 29);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(81, 23);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "In báo cáo";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.crv);
            this.groupBox2.Controls.Add(this.rpvDanhSachSVCQ);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả báo cáo:";
            // 
            // rpvDanhSachSVCQ
            // 
            this.rpvDanhSachSVCQ.ActiveViewIndex = -1;
            this.rpvDanhSachSVCQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvDanhSachSVCQ.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvDanhSachSVCQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvDanhSachSVCQ.Location = new System.Drawing.Point(3, 16);
            this.rpvDanhSachSVCQ.Name = "rpvDanhSachSVCQ";
            this.rpvDanhSachSVCQ.Size = new System.Drawing.Size(794, 331);
            this.rpvDanhSachSVCQ.TabIndex = 0;
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = 0;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv.Location = new System.Drawing.Point(3, 16);
            this.crv.Name = "crv";
            this.crv.ReportSource = this.DSSV_CQ1;
            this.crv.Size = new System.Drawing.Size(794, 331);
            this.crv.TabIndex = 1;
            // 
            // Frm_BaoCaoDanhSachSVCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_BaoCaoDanhSachSVCQ";
            this.Text = "Frm_BaoCaoDanhSachSVCQ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvDanhSachSVCQ;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private DSSV_CQ DSSV_CQ1;
    }
}