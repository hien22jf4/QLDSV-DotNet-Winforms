
namespace QLDSV
{
    partial class Frm_ChungChi
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
            this.Grid_Chungchi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_nhapmoi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_tenchungchi = new System.Windows.Forms.TextBox();
            this.txt_machungchi = new System.Windows.Forms.TextBox();
            this.lbl_tenchungchi = new System.Windows.Forms.Label();
            this.lbl_machungchi = new System.Windows.Forms.Label();
            this.lbl_chungchi = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Chungchi)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_Chungchi
            // 
            this.Grid_Chungchi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Chungchi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_Chungchi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Chungchi.ColumnHeadersHeight = 34;
            this.Grid_Chungchi.Location = new System.Drawing.Point(83, 277);
            this.Grid_Chungchi.Margin = new System.Windows.Forms.Padding(4);
            this.Grid_Chungchi.Name = "Grid_Chungchi";
            this.Grid_Chungchi.RowHeadersWidth = 62;
            this.Grid_Chungchi.RowTemplate.Height = 24;
            this.Grid_Chungchi.Size = new System.Drawing.Size(958, 327);
            this.Grid_Chungchi.TabIndex = 0;
            this.Grid_Chungchi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Chungchi_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_nhapmoi);
            this.panel2.Location = new System.Drawing.Point(272, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 71);
            this.panel2.TabIndex = 4;
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
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(139, 17);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 34);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
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
            this.btn_nhapmoi.Click += new System.EventHandler(this.btn_nhapmoi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_tenchungchi);
            this.panel1.Controls.Add(this.txt_machungchi);
            this.panel1.Controls.Add(this.lbl_tenchungchi);
            this.panel1.Controls.Add(this.lbl_machungchi);
            this.panel1.Controls.Add(this.lbl_chungchi);
            this.panel1.Location = new System.Drawing.Point(83, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 145);
            this.panel1.TabIndex = 3;
            // 
            // txt_tenchungchi
            // 
            this.txt_tenchungchi.Location = new System.Drawing.Point(647, 73);
            this.txt_tenchungchi.Name = "txt_tenchungchi";
            this.txt_tenchungchi.Size = new System.Drawing.Size(235, 23);
            this.txt_tenchungchi.TabIndex = 12;
            // 
            // txt_machungchi
            // 
            this.txt_machungchi.Location = new System.Drawing.Point(179, 75);
            this.txt_machungchi.Name = "txt_machungchi";
            this.txt_machungchi.Size = new System.Drawing.Size(246, 23);
            this.txt_machungchi.TabIndex = 7;
            // 
            // lbl_tenchungchi
            // 
            this.lbl_tenchungchi.AutoSize = true;
            this.lbl_tenchungchi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenchungchi.Location = new System.Drawing.Point(519, 73);
            this.lbl_tenchungchi.Name = "lbl_tenchungchi";
            this.lbl_tenchungchi.Size = new System.Drawing.Size(91, 16);
            this.lbl_tenchungchi.TabIndex = 4;
            this.lbl_tenchungchi.Text = "Tên chứng chỉ";
            // 
            // lbl_machungchi
            // 
            this.lbl_machungchi.AutoSize = true;
            this.lbl_machungchi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_machungchi.Location = new System.Drawing.Point(42, 78);
            this.lbl_machungchi.Name = "lbl_machungchi";
            this.lbl_machungchi.Size = new System.Drawing.Size(87, 16);
            this.lbl_machungchi.TabIndex = 1;
            this.lbl_machungchi.Text = "Mã chứng chỉ";
            // 
            // lbl_chungchi
            // 
            this.lbl_chungchi.AutoSize = true;
            this.lbl_chungchi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chungchi.Location = new System.Drawing.Point(265, 16);
            this.lbl_chungchi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_chungchi.Name = "lbl_chungchi";
            this.lbl_chungchi.Size = new System.Drawing.Size(196, 19);
            this.lbl_chungchi.TabIndex = 0;
            this.lbl_chungchi.Text = "THÔNG TIN CHỨNG CHỈ\r\n";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(910, 630);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(116, 32);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Frm_ChungChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 394);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.Grid_Chungchi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ChungChi";
            this.Text = "Chứng chỉ";
            this.Load += new System.EventHandler(this.Frm_ChungChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Chungchi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Chungchi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_nhapmoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_tenchungchi;
        private System.Windows.Forms.TextBox txt_machungchi;
        private System.Windows.Forms.Label lbl_tenchungchi;
        private System.Windows.Forms.Label lbl_machungchi;
        private System.Windows.Forms.Label lbl_chungchi;
        private System.Windows.Forms.Button btn_thoat;
    }
}