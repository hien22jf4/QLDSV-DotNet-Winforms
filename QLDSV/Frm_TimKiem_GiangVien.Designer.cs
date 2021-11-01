namespace QLDSV
{
    partial class Frm_TimKiem_GiangVien
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttengv = new System.Windows.Forms.TextBox();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radmagv = new System.Windows.Forms.RadioButton();
            this.radtengv = new System.Windows.Forms.RadioButton();
            this.radmakhoa = new System.Windows.Forms.RadioButton();
            this.cbomakhoa = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridtkgiangvien = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtkgiangvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.btn_exit);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(18, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1164, 640);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txttengv);
            this.panel2.Controls.Add(this.txtmagv);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radmagv);
            this.panel2.Controls.Add(this.radtengv);
            this.panel2.Controls.Add(this.radmakhoa);
            this.panel2.Controls.Add(this.cbomakhoa);
            this.panel2.Location = new System.Drawing.Point(9, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 178);
            this.panel2.TabIndex = 9;
            // 
            // txttengv
            // 
            this.txttengv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttengv.Location = new System.Drawing.Point(582, 116);
            this.txttengv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttengv.Name = "txttengv";
            this.txttengv.Size = new System.Drawing.Size(195, 30);
            this.txttengv.TabIndex = 10;
            // 
            // txtmagv
            // 
            this.txtmagv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmagv.Location = new System.Drawing.Point(187, 116);
            this.txtmagv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(194, 30);
            this.txtmagv.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "TÌM KIẾM THÔNG TIN GIẢNG VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn 1 trong các tiêu chí để tìm kiếm:";
            // 
            // radmagv
            // 
            this.radmagv.AutoSize = true;
            this.radmagv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmagv.Location = new System.Drawing.Point(26, 120);
            this.radmagv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radmagv.Name = "radmagv";
            this.radmagv.Size = new System.Drawing.Size(153, 26);
            this.radmagv.TabIndex = 4;
            this.radmagv.TabStop = true;
            this.radmagv.Text = "Mã giảng viên:";
            this.radmagv.UseVisualStyleBackColor = true;
            this.radmagv.CheckedChanged += new System.EventHandler(this.radmagv_CheckedChanged);
            // 
            // radtengv
            // 
            this.radtengv.AutoSize = true;
            this.radtengv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtengv.Location = new System.Drawing.Point(414, 120);
            this.radtengv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radtengv.Name = "radtengv";
            this.radtengv.Size = new System.Drawing.Size(157, 26);
            this.radtengv.TabIndex = 4;
            this.radtengv.TabStop = true;
            this.radtengv.Text = "Tên giảng viên:";
            this.radtengv.UseVisualStyleBackColor = true;
            this.radtengv.CheckedChanged += new System.EventHandler(this.radtengv_CheckedChanged);
            // 
            // radmakhoa
            // 
            this.radmakhoa.AutoSize = true;
            this.radmakhoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmakhoa.Location = new System.Drawing.Point(801, 120);
            this.radmakhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radmakhoa.Name = "radmakhoa";
            this.radmakhoa.Size = new System.Drawing.Size(109, 26);
            this.radmakhoa.TabIndex = 4;
            this.radmakhoa.TabStop = true;
            this.radmakhoa.Text = "Mã khoa:";
            this.radmakhoa.UseVisualStyleBackColor = true;
            this.radmakhoa.CheckedChanged += new System.EventHandler(this.radmakhoa_CheckedChanged);
            // 
            // cbomakhoa
            // 
            this.cbomakhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomakhoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomakhoa.FormattingEnabled = true;
            this.cbomakhoa.Location = new System.Drawing.Point(941, 116);
            this.cbomakhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbomakhoa.Name = "cbomakhoa";
            this.cbomakhoa.Size = new System.Drawing.Size(180, 30);
            this.cbomakhoa.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(534, 193);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 35);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1032, 588);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 35);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridtkgiangvien);
            this.panel1.Location = new System.Drawing.Point(9, 252);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 327);
            this.panel1.TabIndex = 6;
            // 
            // dataGridtkgiangvien
            // 
            this.dataGridtkgiangvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridtkgiangvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtkgiangvien.Location = new System.Drawing.Point(4, 5);
            this.dataGridtkgiangvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridtkgiangvien.Name = "dataGridtkgiangvien";
            this.dataGridtkgiangvien.RowHeadersWidth = 51;
            this.dataGridtkgiangvien.Size = new System.Drawing.Size(1131, 391);
            this.dataGridtkgiangvien.TabIndex = 0;
            // 
            // Frm_TimKiem_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel3);
            this.Name = "Frm_TimKiem_GiangVien";
            this.Text = "Frm_TimKiem_GiangVien";
            this.Load += new System.EventHandler(this.Frm_TimKiem_GiangVien_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtkgiangvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttengv;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radmagv;
        private System.Windows.Forms.RadioButton radtengv;
        private System.Windows.Forms.RadioButton radmakhoa;
        private System.Windows.Forms.ComboBox cbomakhoa;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridtkgiangvien;
    }
}