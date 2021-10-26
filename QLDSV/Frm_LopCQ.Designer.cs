namespace QLDSV
{
    partial class Frm_LopCQ
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
            this.dataGridView_LopCQ = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtb_number = new System.Windows.Forms.TextBox();
            this.lbl_number = new System.Windows.Forms.Label();
            this.label_fal_id = new System.Windows.Forms.Label();
            this.cbo_fal_id = new System.Windows.Forms.ComboBox();
            this.lbl_class_name = new System.Windows.Forms.Label();
            this.lbl_class_id = new System.Windows.Forms.Label();
            this.txtb_class_id = new System.Windows.Forms.TextBox();
            this.txtb_class_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LopCQ)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_LopCQ);
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 242);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_LopCQ
            // 
            this.dataGridView_LopCQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LopCQ.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_LopCQ.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_LopCQ.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_LopCQ.Name = "dataGridView_LopCQ";
            this.dataGridView_LopCQ.Size = new System.Drawing.Size(773, 236);
            this.dataGridView_LopCQ.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_del);
            this.panel2.Controls.Add(this.btn_change);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Location = new System.Drawing.Point(234, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 37);
            this.panel2.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(713, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(246, 11);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(165, 11);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 7;
            this.btn_change.Text = "Cập nhật";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(84, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(3, 11);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "Nhập mới";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtb_class_name);
            this.panel3.Controls.Add(this.txtb_class_id);
            this.panel3.Controls.Add(this.txtb_number);
            this.panel3.Controls.Add(this.lbl_number);
            this.panel3.Controls.Add(this.label_fal_id);
            this.panel3.Controls.Add(this.cbo_fal_id);
            this.panel3.Controls.Add(this.lbl_class_name);
            this.panel3.Controls.Add(this.lbl_class_id);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 106);
            this.panel3.TabIndex = 2;
            // 
            // txtb_number
            // 
            this.txtb_number.Location = new System.Drawing.Point(456, 68);
            this.txtb_number.Name = "txtb_number";
            this.txtb_number.Size = new System.Drawing.Size(156, 20);
            this.txtb_number.TabIndex = 5;
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(387, 75);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(36, 13);
            this.lbl_number.TabIndex = 7;
            this.lbl_number.Text = "Sĩ số:";
            // 
            // label_fal_id
            // 
            this.label_fal_id.AutoSize = true;
            this.label_fal_id.Location = new System.Drawing.Point(130, 75);
            this.label_fal_id.Name = "label_fal_id";
            this.label_fal_id.Size = new System.Drawing.Size(52, 13);
            this.label_fal_id.TabIndex = 5;
            this.label_fal_id.Text = "Mã khoa:";
            // 
            // cbo_fal_id
            // 
            this.cbo_fal_id.AllowDrop = true;
            this.cbo_fal_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_fal_id.FormattingEnabled = true;
            this.cbo_fal_id.Location = new System.Drawing.Point(199, 67);
            this.cbo_fal_id.Name = "cbo_fal_id";
            this.cbo_fal_id.Size = new System.Drawing.Size(121, 21);
            this.cbo_fal_id.TabIndex = 4;
            // 
            // lbl_class_name
            // 
            this.lbl_class_name.AutoSize = true;
            this.lbl_class_name.Location = new System.Drawing.Point(387, 30);
            this.lbl_class_name.Name = "lbl_class_name";
            this.lbl_class_name.Size = new System.Drawing.Size(46, 13);
            this.lbl_class_name.TabIndex = 3;
            this.lbl_class_name.Text = "Tên lớp:";
            // 
            // lbl_class_id
            // 
            this.lbl_class_id.AutoSize = true;
            this.lbl_class_id.Location = new System.Drawing.Point(130, 30);
            this.lbl_class_id.Name = "lbl_class_id";
            this.lbl_class_id.Size = new System.Drawing.Size(42, 13);
            this.lbl_class_id.TabIndex = 1;
            this.lbl_class_id.Text = "Mã lớp:";
            // 
            // txtb_class_id
            // 
            this.txtb_class_id.Location = new System.Drawing.Point(199, 23);
            this.txtb_class_id.Name = "txtb_class_id";
            this.txtb_class_id.Size = new System.Drawing.Size(121, 20);
            this.txtb_class_id.TabIndex = 2;
            // 
            // txtb_class_name
            // 
            this.txtb_class_name.Location = new System.Drawing.Point(456, 23);
            this.txtb_class_name.Name = "txtb_class_name";
            this.txtb_class_name.Size = new System.Drawing.Size(156, 20);
            this.txtb_class_name.TabIndex = 3;
            // 
            // Frm_LopCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_LopCQ";
            this.Text = "Frm_LopCQ";
            this.Load += new System.EventHandler(this.Frm_LopCQ_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LopCQ)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_LopCQ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtb_number;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label label_fal_id;
        private System.Windows.Forms.ComboBox cbo_fal_id;
        private System.Windows.Forms.Label lbl_class_name;
        private System.Windows.Forms.Label lbl_class_id;
        private System.Windows.Forms.TextBox txtb_class_name;
        private System.Windows.Forms.TextBox txtb_class_id;
    }
}