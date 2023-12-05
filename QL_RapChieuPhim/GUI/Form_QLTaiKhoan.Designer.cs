namespace GUI
{
    partial class Form_QLTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_tt = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_quyen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_trangthai = new System.Windows.Forms.Button();
            this.date_ngaydk = new System.Windows.Forms.DateTimePicker();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_tendn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_TK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TK)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tt
            // 
            this.btn_tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tt.Location = new System.Drawing.Point(709, 535);
            this.btn_tt.Name = "btn_tt";
            this.btn_tt.Size = new System.Drawing.Size(381, 43);
            this.btn_tt.TabIndex = 31;
            this.btn_tt.Text = "Thông Tin Người Dùng";
            this.btn_tt.UseVisualStyleBackColor = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Red;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(794, 603);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(222, 43);
            this.btn_thoat.TabIndex = 30;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(378, 603);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(222, 43);
            this.btn_xoa.TabIndex = 29;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(88, 603);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(222, 43);
            this.btn_sua.TabIndex = 28;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(704, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Trạng Thái";
            // 
            // cmb_quyen
            // 
            this.cmb_quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_quyen.FormattingEnabled = true;
            this.cmb_quyen.Location = new System.Drawing.Point(868, 396);
            this.cmb_quyen.Name = "cmb_quyen";
            this.cmb_quyen.Size = new System.Drawing.Size(324, 37);
            this.cmb_quyen.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Quyền";
            // 
            // btn_trangthai
            // 
            this.btn_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangthai.Location = new System.Drawing.Point(868, 465);
            this.btn_trangthai.Name = "btn_trangthai";
            this.btn_trangthai.Size = new System.Drawing.Size(222, 43);
            this.btn_trangthai.TabIndex = 24;
            this.btn_trangthai.UseVisualStyleBackColor = true;
            this.btn_trangthai.Click += new System.EventHandler(this.btn_trangthai_Click);
            // 
            // date_ngaydk
            // 
            this.date_ngaydk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngaydk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaydk.Location = new System.Drawing.Point(287, 537);
            this.date_ngaydk.Name = "date_ngaydk";
            this.date_ngaydk.Size = new System.Drawing.Size(360, 35);
            this.date_ngaydk.TabIndex = 23;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(287, 469);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(360, 35);
            this.txt_matkhau.TabIndex = 22;
            // 
            // txt_tendn
            // 
            this.txt_tendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendn.Location = new System.Drawing.Point(287, 396);
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(360, 35);
            this.txt_tendn.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày Đăng Ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // dtg_TK
            // 
            this.dtg_TK.AllowUserToAddRows = false;
            this.dtg_TK.AllowUserToDeleteRows = false;
            this.dtg_TK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_TK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_TK.ColumnHeadersHeight = 20;
            this.dtg_TK.Location = new System.Drawing.Point(21, 86);
            this.dtg_TK.Name = "dtg_TK";
            this.dtg_TK.ReadOnly = true;
            this.dtg_TK.RowTemplate.Height = 28;
            this.dtg_TK.Size = new System.Drawing.Size(1171, 290);
            this.dtg_TK.TabIndex = 17;
            this.dtg_TK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_TK_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tài Khoản";
            // 
            // Form_QLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1213, 694);
            this.Controls.Add(this.btn_tt);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_quyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_trangthai);
            this.Controls.Add(this.date_ngaydk);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tendn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_TK);
            this.Controls.Add(this.label1);
            this.Name = "Form_QLTaiKhoan";
            this.Text = "Form_QLTaiKhoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_QLTaiKhoan_FormClosing);
            this.Load += new System.EventHandler(this.Form_QLTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_TK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tt;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_quyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_trangthai;
        private System.Windows.Forms.DateTimePicker date_ngaydk;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_tendn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_TK;
        private System.Windows.Forms.Label label1;
    }
}