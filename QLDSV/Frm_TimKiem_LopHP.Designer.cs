namespace QLDSV
{
    partial class Frm_TimKiem_LopHP
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbtn_subject_id = new System.Windows.Forms.RadioButton();
            this.cbo_subject_id = new System.Windows.Forms.ComboBox();
            this.cbo_teacher_id = new System.Windows.Forms.ComboBox();
            this.rbtn_teacher_id = new System.Windows.Forms.RadioButton();
            this.cbo_class_id = new System.Windows.Forms.ComboBox();
            this.rbtn_class_id = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.btn_exit);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.rbtn_subject_id);
            this.panel3.Controls.Add(this.cbo_subject_id);
            this.panel3.Controls.Add(this.cbo_teacher_id);
            this.panel3.Controls.Add(this.rbtn_teacher_id);
            this.panel3.Controls.Add(this.cbo_class_id);
            this.panel3.Controls.Add(this.rbtn_class_id);
            this.panel3.Location = new System.Drawing.Point(16, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1035, 512);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn 1 trong các tiêu chí sau:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(468, 97);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 28);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(917, 470);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 28);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(8, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 320);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // rbtn_subject_id
            // 
            this.rbtn_subject_id.AutoSize = true;
            this.rbtn_subject_id.Location = new System.Drawing.Point(720, 63);
            this.rbtn_subject_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_subject_id.Name = "rbtn_subject_id";
            this.rbtn_subject_id.Size = new System.Drawing.Size(110, 21);
            this.rbtn_subject_id.TabIndex = 4;
            this.rbtn_subject_id.TabStop = true;
            this.rbtn_subject_id.Text = "Mã môn học:";
            this.rbtn_subject_id.UseVisualStyleBackColor = true;
            this.rbtn_subject_id.CheckedChanged += new System.EventHandler(this.rbtn_subject_id_CheckedChanged);
            // 
            // cbo_subject_id
            // 
            this.cbo_subject_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_subject_id.FormattingEnabled = true;
            this.cbo_subject_id.Location = new System.Drawing.Point(839, 59);
            this.cbo_subject_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_subject_id.Name = "cbo_subject_id";
            this.cbo_subject_id.Size = new System.Drawing.Size(160, 24);
            this.cbo_subject_id.TabIndex = 5;
            // 
            // cbo_teacher_id
            // 
            this.cbo_teacher_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_teacher_id.FormattingEnabled = true;
            this.cbo_teacher_id.Location = new System.Drawing.Point(493, 59);
            this.cbo_teacher_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_teacher_id.Name = "cbo_teacher_id";
            this.cbo_teacher_id.Size = new System.Drawing.Size(160, 24);
            this.cbo_teacher_id.TabIndex = 3;
            // 
            // rbtn_teacher_id
            // 
            this.rbtn_teacher_id.AutoSize = true;
            this.rbtn_teacher_id.Location = new System.Drawing.Point(376, 62);
            this.rbtn_teacher_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_teacher_id.Name = "rbtn_teacher_id";
            this.rbtn_teacher_id.Size = new System.Drawing.Size(113, 21);
            this.rbtn_teacher_id.TabIndex = 2;
            this.rbtn_teacher_id.TabStop = true;
            this.rbtn_teacher_id.Text = "Mã giáo viên:";
            this.rbtn_teacher_id.UseVisualStyleBackColor = true;
            this.rbtn_teacher_id.CheckedChanged += new System.EventHandler(this.rbtn_teacher_id_CheckedChanged);
            // 
            // cbo_class_id
            // 
            this.cbo_class_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_class_id.FormattingEnabled = true;
            this.cbo_class_id.Location = new System.Drawing.Point(180, 59);
            this.cbo_class_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_class_id.Name = "cbo_class_id";
            this.cbo_class_id.Size = new System.Drawing.Size(160, 24);
            this.cbo_class_id.TabIndex = 1;
            // 
            // rbtn_class_id
            // 
            this.rbtn_class_id.AutoSize = true;
            this.rbtn_class_id.Location = new System.Drawing.Point(36, 62);
            this.rbtn_class_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_class_id.Name = "rbtn_class_id";
            this.rbtn_class_id.Size = new System.Drawing.Size(134, 21);
            this.rbtn_class_id.TabIndex = 0;
            this.rbtn_class_id.TabStop = true;
            this.rbtn_class_id.Text = "Mã lớp học phần";
            this.rbtn_class_id.UseVisualStyleBackColor = true;
            this.rbtn_class_id.CheckedChanged += new System.EventHandler(this.rbtn_class_id_CheckedChanged);
            // 
            // Frm_TimKiem_LopHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_TimKiem_LopHP";
            this.Text = "Frm_LOPHP";
            this.Load += new System.EventHandler(this.Frm_LOPHP_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cbo_subject_id;
        private System.Windows.Forms.ComboBox cbo_teacher_id;
        private System.Windows.Forms.RadioButton rbtn_teacher_id;
        private System.Windows.Forms.ComboBox cbo_class_id;
        private System.Windows.Forms.RadioButton rbtn_class_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtn_subject_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
    }
}