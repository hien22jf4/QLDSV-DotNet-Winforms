namespace QLDSV
{
    partial class Frm_GiangVien
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_nhapmoi = new System.Windows.Forms.Button();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.cbo_makhoa = new System.Windows.Forms.ComboBox();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txttengv = new System.Windows.Forms.TextBox();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.lbl_malop = new System.Windows.Forms.Label();
            this.lbl_quequan = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.lbl_tensv = new System.Windows.Forms.Label();
            this.Gridgiangvien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_magv = new System.Windows.Forms.Label();
            this.lbl_sinhvien = new System.Windows.Forms.Label();
            this.txtsodt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridgiangvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(1067, 646);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(112, 34);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_nhapmoi
            // 
            this.btn_nhapmoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapmoi.Location = new System.Drawing.Point(19, 31);
            this.btn_nhapmoi.Name = "btn_nhapmoi";
            this.btn_nhapmoi.Size = new System.Drawing.Size(128, 34);
            this.btn_nhapmoi.TabIndex = 0;
            this.btn_nhapmoi.Text = "Nhập mới";
            this.btn_nhapmoi.UseVisualStyleBackColor = true;
            this.btn_nhapmoi.Click += new System.EventHandler(this.btn_nhapmoi_Click);
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(647, 65);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(235, 26);
            this.txtgioitinh.TabIndex = 12;
            // 
            // cbo_makhoa
            // 
            this.cbo_makhoa.FormattingEnabled = true;
            this.cbo_makhoa.Location = new System.Drawing.Point(647, 179);
            this.cbo_makhoa.Name = "cbo_makhoa";
            this.cbo_makhoa.Size = new System.Drawing.Size(235, 28);
            this.cbo_makhoa.TabIndex = 11;
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(647, 127);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(235, 26);
            this.txtquequan.TabIndex = 10;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaysinh.Location = new System.Drawing.Point(179, 183);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(246, 26);
            this.ngaysinh.TabIndex = 9;
            // 
            // txttengv
            // 
            this.txttengv.Location = new System.Drawing.Point(179, 129);
            this.txttengv.Name = "txttengv";
            this.txttengv.Size = new System.Drawing.Size(246, 26);
            this.txttengv.TabIndex = 8;
            // 
            // txtmagv
            // 
            this.txtmagv.Location = new System.Drawing.Point(179, 75);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(246, 26);
            this.txtmagv.TabIndex = 7;
            // 
            // lbl_malop
            // 
            this.lbl_malop.AutoSize = true;
            this.lbl_malop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_malop.Location = new System.Drawing.Point(519, 187);
            this.lbl_malop.Name = "lbl_malop";
            this.lbl_malop.Size = new System.Drawing.Size(82, 23);
            this.lbl_malop.TabIndex = 6;
            this.lbl_malop.Text = "Mã khoa";
            // 
            // lbl_quequan
            // 
            this.lbl_quequan.AutoSize = true;
            this.lbl_quequan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quequan.Location = new System.Drawing.Point(519, 130);
            this.lbl_quequan.Name = "lbl_quequan";
            this.lbl_quequan.Size = new System.Drawing.Size(90, 23);
            this.lbl_quequan.TabIndex = 5;
            this.lbl_quequan.Text = "Quê quán";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(470, 31);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 34);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.Location = new System.Drawing.Point(307, 31);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(120, 34);
            this.btn_capnhat.TabIndex = 2;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(172, 31);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 34);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_capnhat);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_nhapmoi);
            this.panel2.Location = new System.Drawing.Point(337, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 82);
            this.panel2.TabIndex = 5;
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.Location = new System.Drawing.Point(519, 73);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(85, 23);
            this.lbl_gioitinh.TabIndex = 4;
            this.lbl_gioitinh.Text = "Giới tính";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaysinh.Location = new System.Drawing.Point(42, 190);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(92, 23);
            this.lbl_ngaysinh.TabIndex = 3;
            this.lbl_ngaysinh.Text = "Ngày sinh";
            // 
            // lbl_tensv
            // 
            this.lbl_tensv.AutoSize = true;
            this.lbl_tensv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tensv.Location = new System.Drawing.Point(42, 134);
            this.lbl_tensv.Name = "lbl_tensv";
            this.lbl_tensv.Size = new System.Drawing.Size(131, 23);
            this.lbl_tensv.TabIndex = 2;
            this.lbl_tensv.Text = "Tên giảng viên";
            // 
            // Gridgiangvien
            // 
            this.Gridgiangvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridgiangvien.Location = new System.Drawing.Point(121, 415);
            this.Gridgiangvien.Name = "Gridgiangvien";
            this.Gridgiangvien.RowHeadersWidth = 51;
            this.Gridgiangvien.RowTemplate.Height = 24;
            this.Gridgiangvien.Size = new System.Drawing.Size(958, 225);
            this.Gridgiangvien.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtsodt);
            this.panel1.Controls.Add(this.txtgioitinh);
            this.panel1.Controls.Add(this.cbo_makhoa);
            this.panel1.Controls.Add(this.txtquequan);
            this.panel1.Controls.Add(this.ngaysinh);
            this.panel1.Controls.Add(this.txttengv);
            this.panel1.Controls.Add(this.txtmagv);
            this.panel1.Controls.Add(this.lbl_malop);
            this.panel1.Controls.Add(this.lbl_quequan);
            this.panel1.Controls.Add(this.lbl_gioitinh);
            this.panel1.Controls.Add(this.lbl_ngaysinh);
            this.panel1.Controls.Add(this.lbl_tensv);
            this.panel1.Controls.Add(this.lbl_magv);
            this.panel1.Controls.Add(this.lbl_sinhvien);
            this.panel1.Location = new System.Drawing.Point(121, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 282);
            this.panel1.TabIndex = 4;
            // 
            // lbl_magv
            // 
            this.lbl_magv.AutoSize = true;
            this.lbl_magv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_magv.Location = new System.Drawing.Point(42, 78);
            this.lbl_magv.Name = "lbl_magv";
            this.lbl_magv.Size = new System.Drawing.Size(127, 23);
            this.lbl_magv.TabIndex = 1;
            this.lbl_magv.Text = "Mã giảng viên";
            // 
            // lbl_sinhvien
            // 
            this.lbl_sinhvien.AutoSize = true;
            this.lbl_sinhvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sinhvien.Location = new System.Drawing.Point(265, 16);
            this.lbl_sinhvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sinhvien.Name = "lbl_sinhvien";
            this.lbl_sinhvien.Size = new System.Drawing.Size(297, 26);
            this.lbl_sinhvien.TabIndex = 0;
            this.lbl_sinhvien.Text = "THÔNG TIN GIẢNG VIÊN";
            // 
            // txtsodt
            // 
            this.txtsodt.Location = new System.Drawing.Point(179, 238);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(246, 26);
            this.txtsodt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số điện thoại";
            // 
            // Frm_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Gridgiangvien);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_GiangVien";
            this.Text = "Frm_GiangVien";
            this.Load += new System.EventHandler(this.Frm_GiangVien_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridgiangvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_nhapmoi;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.ComboBox cbo_makhoa;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.TextBox txttengv;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.Label lbl_malop;
        private System.Windows.Forms.Label lbl_quequan;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.Label lbl_tensv;
        private System.Windows.Forms.DataGridView Gridgiangvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsodt;
        private System.Windows.Forms.Label lbl_magv;
        private System.Windows.Forms.Label lbl_sinhvien;
    }
}