namespace QLDSV
{
    partial class Frm_TimKiem_LopCQ
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbo_fal_id = new System.Windows.Forms.ComboBox();
            this.rbtn_fal_id = new System.Windows.Forms.RadioButton();
            this.cbo_class_id = new System.Windows.Forms.ComboBox();
            this.rbtn_class_id = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chọn 1 trong các tiêu chí sau:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(360, 96);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(697, 394);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(15, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 260);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbo_fal_id
            // 
            this.cbo_fal_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_fal_id.FormattingEnabled = true;
            this.cbo_fal_id.Location = new System.Drawing.Point(500, 64);
            this.cbo_fal_id.Name = "cbo_fal_id";
            this.cbo_fal_id.Size = new System.Drawing.Size(121, 21);
            this.cbo_fal_id.TabIndex = 12;
            // 
            // rbtn_fal_id
            // 
            this.rbtn_fal_id.AutoSize = true;
            this.rbtn_fal_id.Location = new System.Drawing.Point(400, 72);
            this.rbtn_fal_id.Name = "rbtn_fal_id";
            this.rbtn_fal_id.Size = new System.Drawing.Size(70, 17);
            this.rbtn_fal_id.TabIndex = 11;
            this.rbtn_fal_id.TabStop = true;
            this.rbtn_fal_id.Text = "Mã khoa:";
            this.rbtn_fal_id.UseVisualStyleBackColor = true;
            this.rbtn_fal_id.CheckedChanged += new System.EventHandler(this.rbtn_fal_id_CheckedChanged);
            // 
            // cbo_class_id
            // 
            this.cbo_class_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_class_id.FormattingEnabled = true;
            this.cbo_class_id.Location = new System.Drawing.Point(256, 64);
            this.cbo_class_id.Name = "cbo_class_id";
            this.cbo_class_id.Size = new System.Drawing.Size(120, 21);
            this.cbo_class_id.TabIndex = 10;
            // 
            // rbtn_class_id
            // 
            this.rbtn_class_id.AutoSize = true;
            this.rbtn_class_id.Location = new System.Drawing.Point(176, 64);
            this.rbtn_class_id.Name = "rbtn_class_id";
            this.rbtn_class_id.Size = new System.Drawing.Size(60, 17);
            this.rbtn_class_id.TabIndex = 9;
            this.rbtn_class_id.TabStop = true;
            this.rbtn_class_id.Text = "Mã lớp:";
            this.rbtn_class_id.UseVisualStyleBackColor = true;
            this.rbtn_class_id.CheckedChanged += new System.EventHandler(this.rbtn_class_id_CheckedChanged);
            // 
            // Frm_TimKiem_LopCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbo_fal_id);
            this.Controls.Add(this.rbtn_fal_id);
            this.Controls.Add(this.cbo_class_id);
            this.Controls.Add(this.rbtn_class_id);
            this.Name = "Frm_TimKiem_LopCQ";
            this.Text = "Frm_TimKiem_LopCQ";
            this.Load += new System.EventHandler(this.Frm_TimKiem_LopCQ_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbo_fal_id;
        private System.Windows.Forms.RadioButton rbtn_fal_id;
        private System.Windows.Forms.ComboBox cbo_class_id;
        private System.Windows.Forms.RadioButton rbtn_class_id;
    }
}