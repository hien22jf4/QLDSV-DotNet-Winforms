
namespace QLDSV
{
    partial class Frm_DangNhap
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(366, 176);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(195, 176);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(96, 33);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(262, 117);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(214, 23);
            this.txtMatkhau.TabIndex = 2;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(262, 74);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(214, 23);
            this.txtTenDN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(158, 123);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(68, 17);
            this.lblMatkhau.TabIndex = 6;
            this.lblMatkhau.Text = "Mật Khẩu";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDN.Location = new System.Drawing.Point(117, 80);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(109, 17);
            this.lblTenDN.TabIndex = 7;
            this.lblTenDN.Text = "Tên Đăng Nhập";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(117, 28);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(288, 17);
            this.lblThongBao.TabIndex = 4;
            this.lblThongBao.Text = "CHƯƠNG TRÌNH QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblThongBao);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.lblMatkhau);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.lblTenDN);
            this.panel1.Controls.Add(this.txtMatkhau);
            this.panel1.Controls.Add(this.txtTenDN);
            this.panel1.Location = new System.Drawing.Point(94, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 281);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDSV.Properties.Resources.key;
            this.pictureBox1.Location = new System.Drawing.Point(11, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DangNhap";
            this.Text = "Frm_DangNhap";
            this.Load += new System.EventHandler(this.Frm_DangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}