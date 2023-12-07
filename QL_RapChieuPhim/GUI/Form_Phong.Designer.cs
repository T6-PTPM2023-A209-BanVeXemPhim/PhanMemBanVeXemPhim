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
            this.btn_tinhtrang = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_slg = new Controls.txtNumber();
            this.txt_slh = new Controls.txtNumber();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_phong
            // 
            this.dtg_phong.AllowUserToAddRows = false;
            this.dtg_phong.AllowUserToDeleteRows = false;
            this.dtg_phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_phong.Location = new System.Drawing.Point(12, 76);
            this.dtg_phong.Name = "dtg_phong";
            this.dtg_phong.ReadOnly = true;
            this.dtg_phong.RowTemplate.Height = 28;
            this.dtg_phong.Size = new System.Drawing.Size(1589, 277);
            this.dtg_phong.TabIndex = 0;
            this.dtg_phong.SelectionChanged += new System.EventHandler(this.dtg_phong_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng Chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Lượng ghế/hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tình trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mô Tả";
            // 
            // txt_tenp
            // 
            this.txt_tenp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenp.Location = new System.Drawing.Point(181, 383);
            this.txt_tenp.Name = "txt_tenp";
            this.txt_tenp.Size = new System.Drawing.Size(328, 35);
            this.txt_tenp.TabIndex = 7;
            // 
            // txt_mota
            // 
            this.txt_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mota.Location = new System.Drawing.Point(651, 480);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(492, 148);
            this.txt_mota.TabIndex = 8;
            this.txt_mota.Text = "";
            // 
            // btn_tinhtrang
            // 
            this.btn_tinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhtrang.Location = new System.Drawing.Point(700, 366);
            this.btn_tinhtrang.Name = "btn_tinhtrang";
            this.btn_tinhtrang.Size = new System.Drawing.Size(252, 68);
            this.btn_tinhtrang.TabIndex = 9;
            this.btn_tinhtrang.Text = "button1";
            this.btn_tinhtrang.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(33, 640);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(252, 48);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(317, 640);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(252, 48);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(601, 640);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(252, 48);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_slg
            // 
            this.txt_slg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slg.Location = new System.Drawing.Point(267, 565);
            this.txt_slg.Name = "txt_slg";
            this.txt_slg.Size = new System.Drawing.Size(242, 35);
            this.txt_slg.TabIndex = 11;
            // 
            // txt_slh
            // 
            this.txt_slh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slh.Location = new System.Drawing.Point(267, 473);
            this.txt_slh.Name = "txt_slh";
            this.txt_slh.Size = new System.Drawing.Size(242, 35);
            this.txt_slh.TabIndex = 10;
            // 
            // Form_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 700);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_slg);
            this.Controls.Add(this.txt_slh);
            this.Controls.Add(this.btn_tinhtrang);
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
        private System.Windows.Forms.Button btn_tinhtrang;
        private Controls.txtNumber txt_slh;
        private Controls.txtNumber txt_slg;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
    }
}