
namespace QLDSV
{
    partial class Frm_TraCuuDiemHocPhan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radmamon = new System.Windows.Forms.RadioButton();
            this.radtenmon = new System.Windows.Forms.RadioButton();
            this.cbomasv = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridtklhp = new System.Windows.Forms.DataGridView();
            this.cbomlhp = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtklhp)).BeginInit();
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
            this.panel3.Size = new System.Drawing.Size(1169, 652);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbomlhp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radmamon);
            this.panel2.Controls.Add(this.radtenmon);
            this.panel2.Controls.Add(this.cbomasv);
            this.panel2.Location = new System.Drawing.Point(9, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 203);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(534, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "TÌM KIẾM THÔNG TIN ĐIỂM LỚP HỌC PHẦN";
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
            // radmamon
            // 
            this.radmamon.AutoSize = true;
            this.radmamon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radmamon.Location = new System.Drawing.Point(41, 117);
            this.radmamon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radmamon.Name = "radmamon";
            this.radmamon.Size = new System.Drawing.Size(174, 26);
            this.radmamon.TabIndex = 4;
            this.radmamon.TabStop = true;
            this.radmamon.Text = "Mã lớp học phần:";
            this.radmamon.UseVisualStyleBackColor = true;
            this.radmamon.CheckedChanged += new System.EventHandler(this.radmamon_CheckedChanged);
            // 
            // radtenmon
            // 
            this.radtenmon.AutoSize = true;
            this.radtenmon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtenmon.Location = new System.Drawing.Point(609, 120);
            this.radtenmon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radtenmon.Name = "radtenmon";
            this.radtenmon.Size = new System.Drawing.Size(137, 26);
            this.radtenmon.TabIndex = 4;
            this.radtenmon.TabStop = true;
            this.radtenmon.Text = "Mã sinh viên";
            this.radtenmon.UseVisualStyleBackColor = true;
            this.radtenmon.CheckedChanged += new System.EventHandler(this.radtenmon_CheckedChanged);
            // 
            // cbomasv
            // 
            this.cbomasv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomasv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomasv.FormattingEnabled = true;
            this.cbomasv.Location = new System.Drawing.Point(800, 117);
            this.cbomasv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbomasv.Name = "cbomasv";
            this.cbomasv.Size = new System.Drawing.Size(180, 30);
            this.cbomasv.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(507, 245);
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
            this.panel1.Controls.Add(this.dataGridtklhp);
            this.panel1.Location = new System.Drawing.Point(9, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 274);
            this.panel1.TabIndex = 6;
            // 
            // dataGridtklhp
            // 
            this.dataGridtklhp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridtklhp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtklhp.Location = new System.Drawing.Point(4, 0);
            this.dataGridtklhp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridtklhp.Name = "dataGridtklhp";
            this.dataGridtklhp.RowHeadersWidth = 51;
            this.dataGridtklhp.Size = new System.Drawing.Size(1156, 396);
            this.dataGridtklhp.TabIndex = 0;
            // 
            // cbomlhp
            // 
            this.cbomlhp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomlhp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomlhp.FormattingEnabled = true;
            this.cbomlhp.Location = new System.Drawing.Point(239, 116);
            this.cbomlhp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbomlhp.Name = "cbomlhp";
            this.cbomlhp.Size = new System.Drawing.Size(180, 30);
            this.cbomlhp.TabIndex = 10;
            // 
            // Frm_TraCuuDiemHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel3);
            this.Name = "Frm_TraCuuDiemHocPhan";
            this.Text = "Frm_TraCuuDiemHocPhan";
            this.Load += new System.EventHandler(this.Frm_TraCuuDiemHocPhan_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtklhp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radmamon;
        private System.Windows.Forms.RadioButton radtenmon;
        private System.Windows.Forms.ComboBox cbomasv;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridtklhp;
        private System.Windows.Forms.ComboBox cbomlhp;
    }
}