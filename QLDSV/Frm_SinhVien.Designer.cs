
namespace QLDSV
{
    partial class Frm_SinhVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_masv = new System.Windows.Forms.Label();
            this.lbl_sinhvien = new System.Windows.Forms.Label();
            this.lbl_tensv = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_quequan = new System.Windows.Forms.Label();
            this.lbl_malop = new System.Windows.Forms.Label();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.txt_tensv = new System.Windows.Forms.TextBox();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_quequan = new System.Windows.Forms.TextBox();
            this.cbo_malop = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_nhapmoi = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.Grid_Sinhvien = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Sinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.cbo_malop);
            this.panel1.Controls.Add(this.txt_quequan);
            this.panel1.Controls.Add(this.ngaysinh);
            this.panel1.Controls.Add(this.txt_tensv);
            this.panel1.Controls.Add(this.txt_masv);
            this.panel1.Controls.Add(this.lbl_malop);
            this.panel1.Controls.Add(this.lbl_quequan);
            this.panel1.Controls.Add(this.lbl_gioitinh);
            this.panel1.Controls.Add(this.lbl_ngaysinh);
            this.panel1.Controls.Add(this.lbl_tensv);
            this.panel1.Controls.Add(this.lbl_masv);
            this.panel1.Controls.Add(this.lbl_sinhvien);
            this.panel1.Location = new System.Drawing.Point(75, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 239);
            this.panel1.TabIndex = 0;
            // 
            // lbl_masv
            // 
            this.lbl_masv.AutoSize = true;
            this.lbl_masv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masv.Location = new System.Drawing.Point(42, 78);
            this.lbl_masv.Name = "lbl_masv";
            this.lbl_masv.Size = new System.Drawing.Size(95, 19);
            this.lbl_masv.TabIndex = 1;
            this.lbl_masv.Text = "Mã sinh viên";
            // 
            // lbl_sinhvien
            // 
            this.lbl_sinhvien.AutoSize = true;
            this.lbl_sinhvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sinhvien.Location = new System.Drawing.Point(265, 16);
            this.lbl_sinhvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sinhvien.Name = "lbl_sinhvien";
            this.lbl_sinhvien.Size = new System.Drawing.Size(228, 23);
            this.lbl_sinhvien.TabIndex = 0;
            this.lbl_sinhvien.Text = "THÔNG TIN SINH VIÊN";
            // 
            // lbl_tensv
            // 
            this.lbl_tensv.AutoSize = true;
            this.lbl_tensv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensv.Location = new System.Drawing.Point(42, 134);
            this.lbl_tensv.Name = "lbl_tensv";
            this.lbl_tensv.Size = new System.Drawing.Size(98, 19);
            this.lbl_tensv.TabIndex = 2;
            this.lbl_tensv.Text = "Tên sinh viên";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaysinh.Location = new System.Drawing.Point(42, 190);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(76, 19);
            this.lbl_ngaysinh.TabIndex = 3;
            this.lbl_ngaysinh.Text = "Ngày sinh";
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.Location = new System.Drawing.Point(519, 73);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(70, 19);
            this.lbl_gioitinh.TabIndex = 4;
            this.lbl_gioitinh.Text = "Giới tính";
            // 
            // lbl_quequan
            // 
            this.lbl_quequan.AutoSize = true;
            this.lbl_quequan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quequan.Location = new System.Drawing.Point(519, 130);
            this.lbl_quequan.Name = "lbl_quequan";
            this.lbl_quequan.Size = new System.Drawing.Size(72, 19);
            this.lbl_quequan.TabIndex = 5;
            this.lbl_quequan.Text = "Quê quán";
            // 
            // lbl_malop
            // 
            this.lbl_malop.AutoSize = true;
            this.lbl_malop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_malop.Location = new System.Drawing.Point(519, 187);
            this.lbl_malop.Name = "lbl_malop";
            this.lbl_malop.Size = new System.Drawing.Size(57, 19);
            this.lbl_malop.TabIndex = 6;
            this.lbl_malop.Text = "Mã lớp";
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(179, 75);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(246, 27);
            this.txt_masv.TabIndex = 7;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Location = new System.Drawing.Point(179, 129);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(246, 27);
            this.txt_tensv.TabIndex = 8;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaysinh.Location = new System.Drawing.Point(179, 183);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(246, 27);
            this.ngaysinh.TabIndex = 9;
            // 
            // txt_quequan
            // 
            this.txt_quequan.Location = new System.Drawing.Point(647, 127);
            this.txt_quequan.Name = "txt_quequan";
            this.txt_quequan.Size = new System.Drawing.Size(235, 27);
            this.txt_quequan.TabIndex = 10;
            // 
            // cbo_malop
            // 
            this.cbo_malop.FormattingEnabled = true;
            this.cbo_malop.Location = new System.Drawing.Point(647, 179);
            this.cbo_malop.Name = "cbo_malop";
            this.cbo_malop.Size = new System.Drawing.Size(235, 28);
            this.cbo_malop.TabIndex = 11;
            this.cbo_malop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(647, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 27);
            this.textBox2.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_nhapmoi);
            this.panel2.Location = new System.Drawing.Point(300, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 71);
            this.panel2.TabIndex = 1;
            // 
            // btn_nhapmoi
            // 
            this.btn_nhapmoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapmoi.Location = new System.Drawing.Point(19, 17);
            this.btn_nhapmoi.Name = "btn_nhapmoi";
            this.btn_nhapmoi.Size = new System.Drawing.Size(100, 34);
            this.btn_nhapmoi.TabIndex = 0;
            this.btn_nhapmoi.Text = "Nhập mới";
            this.btn_nhapmoi.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(139, 17);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 34);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(259, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cập nhật";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(379, 17);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 34);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // Grid_Sinhvien
            // 
            this.Grid_Sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Sinhvien.Location = new System.Drawing.Point(75, 362);
            this.Grid_Sinhvien.Name = "Grid_Sinhvien";
            this.Grid_Sinhvien.RowHeadersWidth = 51;
            this.Grid_Sinhvien.RowTemplate.Height = 24;
            this.Grid_Sinhvien.Size = new System.Drawing.Size(958, 225);
            this.Grid_Sinhvien.TabIndex = 2;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(921, 607);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(112, 34);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // Frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 653);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.Grid_Sinhvien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_SinhVien";
            this.Text = "Frm_SinhVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Sinhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_sinhvien;
        private System.Windows.Forms.Label lbl_masv;
        private System.Windows.Forms.Label lbl_tensv;
        private System.Windows.Forms.Label lbl_malop;
        private System.Windows.Forms.Label lbl_quequan;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbo_malop;
        private System.Windows.Forms.TextBox txt_quequan;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.TextBox txt_tensv;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_nhapmoi;
        private System.Windows.Forms.DataGridView Grid_Sinhvien;
        private System.Windows.Forms.Button btn_thoat;
    }
}