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
            this.label3 = new System.Windows.Forms.Label();
            this.lblmagv = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewGiangvien = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnchapnhat = new System.Windows.Forms.Button();
            this.cbomakhoa = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.lbmakhoa = new System.Windows.Forms.Label();
            this.lblsotinchi = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttengv = new System.Windows.Forms.TextBox();
            this.txtsodt = new System.Windows.Forms.TextBox();
            this.lstgioitinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltengv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiangvien)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "THÔNG TIN GIẢNG VIÊN";
            // 
            // lblmagv
            // 
            this.lblmagv.AutoSize = true;
            this.lblmagv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmagv.Location = new System.Drawing.Point(48, 85);
            this.lblmagv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmagv.Name = "lblmagv";
            this.lblmagv.Size = new System.Drawing.Size(128, 22);
            this.lblmagv.TabIndex = 1;
            this.lblmagv.Text = "Mã giảng viên:";
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(126, 17);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(112, 35);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntaomoi
            // 
            this.btntaomoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaomoi.Location = new System.Drawing.Point(4, 17);
            this.btntaomoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(112, 35);
            this.btntaomoi.TabIndex = 1;
            this.btntaomoi.Text = "Nhập mới";
            this.btntaomoi.UseVisualStyleBackColor = true;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewGiangvien);
            this.panel1.Location = new System.Drawing.Point(18, 354);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 267);
            this.panel1.TabIndex = 22;
            // 
            // dataGridViewGiangvien
            // 
            this.dataGridViewGiangvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGiangvien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGiangvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewGiangvien.ColumnHeadersHeight = 34;
            this.dataGridViewGiangvien.Location = new System.Drawing.Point(4, 5);
            this.dataGridViewGiangvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewGiangvien.Name = "dataGridViewGiangvien";
            this.dataGridViewGiangvien.RowHeadersWidth = 62;
            this.dataGridViewGiangvien.Size = new System.Drawing.Size(1156, 262);
            this.dataGridViewGiangvien.TabIndex = 0;
            this.dataGridViewGiangvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGiangvien_CellContentClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(369, 17);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(112, 35);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnchapnhat
            // 
            this.btnchapnhat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchapnhat.Location = new System.Drawing.Point(248, 17);
            this.btnchapnhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnchapnhat.Name = "btnchapnhat";
            this.btnchapnhat.Size = new System.Drawing.Size(112, 35);
            this.btnchapnhat.TabIndex = 7;
            this.btnchapnhat.Text = "Cập nhật";
            this.btnchapnhat.UseVisualStyleBackColor = true;
            this.btnchapnhat.Click += new System.EventHandler(this.btnchapnhat_Click);
            // 
            // cbomakhoa
            // 
            this.cbomakhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomakhoa.FormattingEnabled = true;
            this.cbomakhoa.Location = new System.Drawing.Point(996, 202);
            this.cbomakhoa.Name = "cbomakhoa";
            this.cbomakhoa.Size = new System.Drawing.Size(143, 28);
            this.cbomakhoa.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnchapnhat);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btntaomoi);
            this.panel2.Location = new System.Drawing.Point(341, 276);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 57);
            this.panel2.TabIndex = 23;
            // 
            // txtquequan
            // 
            this.txtquequan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquequan.Location = new System.Drawing.Point(609, 201);
            this.txtquequan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(224, 30);
            this.txtquequan.TabIndex = 3;
            // 
            // txtmagv
            // 
            this.txtmagv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmagv.Location = new System.Drawing.Point(249, 82);
            this.txtmagv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(171, 30);
            this.txtmagv.TabIndex = 2;
            // 
            // lbmakhoa
            // 
            this.lbmakhoa.AutoSize = true;
            this.lbmakhoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmakhoa.Location = new System.Drawing.Point(868, 204);
            this.lbmakhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmakhoa.Name = "lbmakhoa";
            this.lbmakhoa.Size = new System.Drawing.Size(84, 22);
            this.lbmakhoa.TabIndex = 5;
            this.lbmakhoa.Text = "Mã khoa:";
            // 
            // lblsotinchi
            // 
            this.lblsotinchi.AutoSize = true;
            this.lblsotinchi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsotinchi.Location = new System.Drawing.Point(494, 207);
            this.lblsotinchi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsotinchi.Name = "lblsotinchi";
            this.lblsotinchi.Size = new System.Drawing.Size(90, 22);
            this.lblsotinchi.TabIndex = 3;
            this.lblsotinchi.Text = "Quê quán:";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1070, 639);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 35);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbomakhoa);
            this.panel3.Controls.Add(this.txtquequan);
            this.panel3.Controls.Add(this.txttengv);
            this.panel3.Controls.Add(this.txtsodt);
            this.panel3.Controls.Add(this.lstgioitinh);
            this.panel3.Controls.Add(this.txtmagv);
            this.panel3.Controls.Add(this.lbmakhoa);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblsotinchi);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbltengv);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblmagv);
            this.panel3.Location = new System.Drawing.Point(18, 19);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1169, 247);
            this.panel3.TabIndex = 24;
            // 
            // txttengv
            // 
            this.txttengv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttengv.Location = new System.Drawing.Point(743, 82);
            this.txttengv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttengv.Name = "txttengv";
            this.txttengv.Size = new System.Drawing.Size(224, 30);
            this.txttengv.TabIndex = 3;
            // 
            // txtsodt
            // 
            this.txtsodt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsodt.Location = new System.Drawing.Point(249, 201);
            this.txtsodt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(171, 30);
            this.txtsodt.TabIndex = 2;
            // 
            // lstgioitinh
            // 
            this.lstgioitinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstgioitinh.Location = new System.Drawing.Point(249, 138);
            this.lstgioitinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstgioitinh.Name = "lstgioitinh";
            this.lstgioitinh.Size = new System.Drawing.Size(171, 30);
            this.lstgioitinh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // lbltengv
            // 
            this.lbltengv.AutoSize = true;
            this.lbltengv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltengv.Location = new System.Drawing.Point(567, 85);
            this.lbltengv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltengv.Name = "lbltengv";
            this.lbltengv.Size = new System.Drawing.Size(132, 22);
            this.lbltengv.TabIndex = 3;
            this.lbltengv.Text = "Tên giảng viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giới tính:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(747, 125);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2021, 10, 29, 8, 40, 49, 0);
            // 
            // Frm_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel3);
            this.Name = "Frm_GiangVien";
            this.Text = "Frm_GiangVien";
            this.Load += new System.EventHandler(this.Frm_GiangVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiangvien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmagv;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewGiangvien;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnchapnhat;
        private System.Windows.Forms.ComboBox cbomakhoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.Label lbmakhoa;
        private System.Windows.Forms.Label lblsotinchi;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttengv;
        private System.Windows.Forms.TextBox txtsodt;
        private System.Windows.Forms.Label lbltengv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lstgioitinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}