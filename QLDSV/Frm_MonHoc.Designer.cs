
namespace QLDSV
{
    partial class Frm_MonHoc
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
            this.txttenmon = new System.Windows.Forms.TextBox();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.lbmakhoa = new System.Windows.Forms.Label();
            this.lblsotinchi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMonHoc = new System.Windows.Forms.DataGridView();
            this.txtsotinchi = new System.Windows.Forms.TextBox();
            this.lbltenmon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnchapnhat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.lblmamon = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbomakhoa = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttenmon
            // 
            this.txttenmon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenmon.Location = new System.Drawing.Point(485, 58);
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(156, 23);
            this.txttenmon.TabIndex = 3;
            // 
            // txtmamon
            // 
            this.txtmamon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmamon.Location = new System.Drawing.Point(171, 58);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(121, 23);
            this.txtmamon.TabIndex = 2;
            // 
            // lbmakhoa
            // 
            this.lbmakhoa.AutoSize = true;
            this.lbmakhoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmakhoa.Location = new System.Drawing.Point(70, 101);
            this.lbmakhoa.Name = "lbmakhoa";
            this.lbmakhoa.Size = new System.Drawing.Size(60, 16);
            this.lbmakhoa.TabIndex = 5;
            this.lbmakhoa.Text = "Mã khoa:";
            // 
            // lblsotinchi
            // 
            this.lblsotinchi.AutoSize = true;
            this.lblsotinchi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsotinchi.Location = new System.Drawing.Point(394, 101);
            this.lblsotinchi.Name = "lblsotinchi";
            this.lblsotinchi.Size = new System.Drawing.Size(66, 16);
            this.lblsotinchi.TabIndex = 3;
            this.lblsotinchi.Text = "Số tín chỉ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMonHoc);
            this.panel1.Location = new System.Drawing.Point(12, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 202);
            this.panel1.TabIndex = 18;
            // 
            // dataGridViewMonHoc
            // 
            this.dataGridViewMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMonHoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMonHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMonHoc.ColumnHeadersHeight = 34;
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.RowHeadersWidth = 62;
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(767, 236);
            this.dataGridViewMonHoc.TabIndex = 0;
            this.dataGridViewMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonHoc_CellContentClick);
            // 
            // txtsotinchi
            // 
            this.txtsotinchi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotinchi.Location = new System.Drawing.Point(485, 99);
            this.txtsotinchi.Name = "txtsotinchi";
            this.txtsotinchi.Size = new System.Drawing.Size(84, 23);
            this.txtsotinchi.TabIndex = 3;
            // 
            // lbltenmon
            // 
            this.lbltenmon.AutoSize = true;
            this.lbltenmon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenmon.Location = new System.Drawing.Point(394, 60);
            this.lbltenmon.Name = "lbltenmon";
            this.lbltenmon.Size = new System.Drawing.Size(62, 16);
            this.lbltenmon.TabIndex = 3;
            this.lbltenmon.Text = "Tên môn:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnchapnhat);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btntaomoi);
            this.panel2.Location = new System.Drawing.Point(233, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 37);
            this.panel2.TabIndex = 19;
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(246, 11);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnchapnhat
            // 
            this.btnchapnhat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchapnhat.Location = new System.Drawing.Point(165, 11);
            this.btnchapnhat.Name = "btnchapnhat";
            this.btnchapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnchapnhat.TabIndex = 7;
            this.btnchapnhat.Text = "Cập nhật";
            this.btnchapnhat.UseVisualStyleBackColor = true;
            this.btnchapnhat.Click += new System.EventHandler(this.btnchapnhat_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(84, 11);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntaomoi
            // 
            this.btntaomoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaomoi.Location = new System.Drawing.Point(3, 11);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(75, 23);
            this.btntaomoi.TabIndex = 1;
            this.btntaomoi.Text = "Nhập mới";
            this.btntaomoi.UseVisualStyleBackColor = true;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // lblmamon
            // 
            this.lblmamon.AutoSize = true;
            this.lblmamon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmamon.Location = new System.Drawing.Point(73, 58);
            this.lblmamon.Name = "lblmamon";
            this.lblmamon.Size = new System.Drawing.Size(58, 16);
            this.lblmamon.TabIndex = 1;
            this.lblmamon.Text = "Mã môn:";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(713, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbomakhoa);
            this.panel3.Controls.Add(this.txtsotinchi);
            this.panel3.Controls.Add(this.txttenmon);
            this.panel3.Controls.Add(this.txtmamon);
            this.panel3.Controls.Add(this.lbmakhoa);
            this.panel3.Controls.Add(this.lblsotinchi);
            this.panel3.Controls.Add(this.lbltenmon);
            this.panel3.Controls.Add(this.lblmamon);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 129);
            this.panel3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "THÔNG TIN MÔN HỌC";
            // 
            // cbomakhoa
            // 
            this.cbomakhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomakhoa.FormattingEnabled = true;
            this.cbomakhoa.Location = new System.Drawing.Point(171, 99);
            this.cbomakhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbomakhoa.Name = "cbomakhoa";
            this.cbomakhoa.Size = new System.Drawing.Size(121, 21);
            this.cbomakhoa.TabIndex = 6;
            // 
            // Frm_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_MonHoc";
            this.Text = "Frm_MonHoc";
            this.Load += new System.EventHandler(this.Frm_MonHoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txttenmon;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.Label lbmakhoa;
        private System.Windows.Forms.Label lblsotinchi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMonHoc;
        private System.Windows.Forms.TextBox txtsotinchi;
        private System.Windows.Forms.Label lbltenmon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnchapnhat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Label lblmamon;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbomakhoa;
        private System.Windows.Forms.Label label3;
    }
}