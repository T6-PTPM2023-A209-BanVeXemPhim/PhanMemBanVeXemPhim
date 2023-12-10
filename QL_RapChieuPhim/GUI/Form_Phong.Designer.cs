namespace GUI
{
    partial class Form_Phong
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
            this.dtg_phong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenp = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.RichTextBox();
            this.txt_slg = new Controls.txtNumber();
            this.txt_slh = new Controls.txtNumber();
            this.btn_tinhtrang = new Controls.btn_control();
            this.btn_them = new Controls.btn_control();
            this.btn_xoa = new Controls.btn_control();
            this.btn_sua = new Controls.btn_control();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_phong
            // 
            this.dtg_phong.AllowUserToAddRows = false;
            this.dtg_phong.AllowUserToDeleteRows = false;
            this.dtg_phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_phong.Location = new System.Drawing.Point(124, 86);
            this.dtg_phong.Name = "dtg_phong";
            this.dtg_phong.ReadOnly = true;
            this.dtg_phong.RowTemplate.Height = 28;
            this.dtg_phong.Size = new System.Drawing.Size(1655, 396);
            this.dtg_phong.TabIndex = 0;
            this.dtg_phong.SelectionChanged += new System.EventHandler(this.dtg_phong_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(802, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng Chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 690);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Lượng ghế/hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(931, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(931, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mô Tả";
            // 
            // txt_tenp
            // 
            this.txt_tenp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenp.Location = new System.Drawing.Point(272, 505);
            this.txt_tenp.Name = "txt_tenp";
            this.txt_tenp.Size = new System.Drawing.Size(607, 35);
            this.txt_tenp.TabIndex = 7;
            // 
            // txt_mota
            // 
            this.txt_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mota.Location = new System.Drawing.Point(1019, 602);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(760, 148);
            this.txt_mota.TabIndex = 8;
            this.txt_mota.Text = "";
            // 
            // txt_slg
            // 
            this.txt_slg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slg.Location = new System.Drawing.Point(358, 687);
            this.txt_slg.Name = "txt_slg";
            this.txt_slg.Size = new System.Drawing.Size(242, 35);
            this.txt_slg.TabIndex = 11;
            // 
            // txt_slh
            // 
            this.txt_slh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slh.Location = new System.Drawing.Point(358, 595);
            this.txt_slh.Name = "txt_slh";
            this.txt_slh.Size = new System.Drawing.Size(242, 35);
            this.txt_slh.TabIndex = 10;
            // 
            // btn_tinhtrang
            // 
            this.btn_tinhtrang.BackColor = System.Drawing.Color.White;
            this.btn_tinhtrang.BackgroundColor = System.Drawing.Color.White;
            this.btn_tinhtrang.BorderColor = System.Drawing.Color.Black;
            this.btn_tinhtrang.BorderRadius = 20;
            this.btn_tinhtrang.BorderSize = 2;
            this.btn_tinhtrang.FlatAppearance.BorderSize = 0;
            this.btn_tinhtrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhtrang.ForeColor = System.Drawing.Color.Black;
            this.btn_tinhtrang.Location = new System.Drawing.Point(1069, 488);
            this.btn_tinhtrang.Name = "btn_tinhtrang";
            this.btn_tinhtrang.Size = new System.Drawing.Size(293, 74);
            this.btn_tinhtrang.TabIndex = 15;
            this.btn_tinhtrang.Text = "btn_control1";
            this.btn_tinhtrang.TextColor = System.Drawing.Color.Black;
            this.btn_tinhtrang.UseVisualStyleBackColor = false;
            this.btn_tinhtrang.Click += new System.EventHandler(this.btn_tinhtrang_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_them.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btn_them.BorderColor = System.Drawing.Color.Gold;
            this.btn_them.BorderRadius = 20;
            this.btn_them.BorderSize = 2;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(114, 773);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(184, 75);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.White;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.Red;
            this.btn_xoa.BorderColor = System.Drawing.Color.Brown;
            this.btn_xoa.BorderRadius = 20;
            this.btn_xoa.BorderSize = 2;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(382, 773);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(184, 75);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.White;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Teal;
            this.btn_sua.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_sua.BorderColor = System.Drawing.Color.Black;
            this.btn_sua.BorderRadius = 20;
            this.btn_sua.BorderSize = 2;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(656, 773);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(184, 75);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.White;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // Form_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1871, 933);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_tinhtrang);
            this.Controls.Add(this.txt_slg);
            this.Controls.Add(this.txt_slh);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_tenp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_phong);
            this.Name = "Form_Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form_Phong";
            this.Load += new System.EventHandler(this.Form_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_phong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tenp;
        private System.Windows.Forms.RichTextBox txt_mota;
        private Controls.txtNumber txt_slh;
        private Controls.txtNumber txt_slg;
        private Controls.btn_control btn_tinhtrang;
        private Controls.btn_control btn_them;
        private Controls.btn_control btn_xoa;
        private Controls.btn_control btn_sua;
    }
}