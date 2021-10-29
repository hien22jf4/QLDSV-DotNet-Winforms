
namespace QLDSV
{
    partial class Frm_TimKiem_SinhVien
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Grid_SinhVien = new System.Windows.Forms.DataGridView();
            this.cbo_malop = new System.Windows.Forms.ComboBox();
            this.rad_tensv = new System.Windows.Forms.RadioButton();
            this.rad_masv = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.txt_tensv = new System.Windows.Forms.TextBox();
            this.rad_malop = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_SinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(395, 130);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(120, 28);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(842, 529);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(79, 28);
            this.btn_thoat.TabIndex = 25;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Grid_SinhVien);
            this.panel1.Location = new System.Drawing.Point(39, 189);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 320);
            this.panel1.TabIndex = 24;
            // 
            // Grid_SinhVien
            // 
            this.Grid_SinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_SinhVien.Location = new System.Drawing.Point(4, 0);
            this.Grid_SinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.Grid_SinhVien.Name = "Grid_SinhVien";
            this.Grid_SinhVien.RowHeadersWidth = 51;
            this.Grid_SinhVien.Size = new System.Drawing.Size(889, 316);
            this.Grid_SinhVien.TabIndex = 0;
            // 
            // cbo_malop
            // 
            this.cbo_malop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_malop.FormattingEnabled = true;
            this.cbo_malop.Location = new System.Drawing.Point(818, 69);
            this.cbo_malop.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_malop.Name = "cbo_malop";
            this.cbo_malop.Size = new System.Drawing.Size(132, 27);
            this.cbo_malop.TabIndex = 22;
            // 
            // rad_tensv
            // 
            this.rad_tensv.AutoSize = true;
            this.rad_tensv.Location = new System.Drawing.Point(338, 73);
            this.rad_tensv.Margin = new System.Windows.Forms.Padding(4);
            this.rad_tensv.Name = "rad_tensv";
            this.rad_tensv.Size = new System.Drawing.Size(119, 23);
            this.rad_tensv.TabIndex = 21;
            this.rad_tensv.TabStop = true;
            this.rad_tensv.Text = "Tên sinh viên";
            this.rad_tensv.UseVisualStyleBackColor = true;
            // 
            // rad_masv
            // 
            this.rad_masv.AutoSize = true;
            this.rad_masv.Location = new System.Drawing.Point(43, 73);
            this.rad_masv.Margin = new System.Windows.Forms.Padding(4);
            this.rad_masv.Name = "rad_masv";
            this.rad_masv.Size = new System.Drawing.Size(116, 23);
            this.rad_masv.TabIndex = 19;
            this.rad_masv.TabStop = true;
            this.rad_masv.Text = "Mã sinh viên";
            this.rad_masv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "TÌM KIẾM THÔNG TIN SINH VIÊN";
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(178, 69);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(115, 27);
            this.txt_masv.TabIndex = 27;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Location = new System.Drawing.Point(478, 69);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(199, 27);
            this.txt_tensv.TabIndex = 28;
            // 
            // rad_malop
            // 
            this.rad_malop.AutoSize = true;
            this.rad_malop.Location = new System.Drawing.Point(720, 73);
            this.rad_malop.Name = "rad_malop";
            this.rad_malop.Size = new System.Drawing.Size(78, 23);
            this.rad_malop.TabIndex = 29;
            this.rad_malop.TabStop = true;
            this.rad_malop.Text = "Mã lớp";
            this.rad_malop.UseVisualStyleBackColor = true;
            // 
            // Frm_TimKiem_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 581);
            this.Controls.Add(this.rad_malop);
            this.Controls.Add(this.txt_tensv);
            this.Controls.Add(this.txt_masv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbo_malop);
            this.Controls.Add(this.rad_tensv);
            this.Controls.Add(this.rad_masv);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_TimKiem_SinhVien";
            this.Text = "Tìm kiếm sinh viên";
            this.Load += new System.EventHandler(this.Frm_TimKiem_SinhVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_SinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Grid_SinhVien;
        private System.Windows.Forms.ComboBox cbo_malop;
        private System.Windows.Forms.RadioButton rad_tensv;
        private System.Windows.Forms.RadioButton rad_masv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.TextBox txt_tensv;
        private System.Windows.Forms.RadioButton rad_malop;
    }
}