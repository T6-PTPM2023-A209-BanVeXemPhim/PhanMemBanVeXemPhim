namespace GUI
{
    partial class Form_QLVe
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvLichChieu = new System.Windows.Forms.DataGridView();
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.lbTenPhim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.lbTimeBD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbIdPhong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTimeKT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChonGhe = new System.Windows.Forms.Button();
            this.dgvGhe = new System.Windows.Forms.DataGridView();
            this.lbGhe = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.cboTk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dgvDatVe = new System.Windows.Forms.DataGridView();
            this.btnThemVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatVe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(267, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(182, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 28);
            this.btnSua.TabIndex = 122;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(97, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 28);
            this.btnXoa.TabIndex = 121;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgvLichChieu
            // 
            this.dgvLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieu.Location = new System.Drawing.Point(491, 60);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.Size = new System.Drawing.Size(713, 152);
            this.dgvLichChieu.TabIndex = 125;
            this.dgvLichChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichChieu_CellClick);
            // 
            // dgvPhim
            // 
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhim.Location = new System.Drawing.Point(12, 60);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.Size = new System.Drawing.Size(473, 152);
            this.dgvPhim.TabIndex = 124;
            this.dgvPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellClick);
            // 
            // lbTenPhim
            // 
            this.lbTenPhim.AutoSize = true;
            this.lbTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhim.Location = new System.Drawing.Point(99, 237);
            this.lbTenPhim.Name = "lbTenPhim";
            this.lbTenPhim.Size = new System.Drawing.Size(74, 20);
            this.lbTenPhim.TabIndex = 130;
            this.lbTenPhim.Text = "Tên phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 129;
            this.label3.Text = "Tên phim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 132;
            this.label1.Text = "ngày chiếu:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(103, 277);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(146, 26);
            this.dtpNgayBatDau.TabIndex = 131;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(295, 269);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 28);
            this.btnTim.TabIndex = 133;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lbTimeBD
            // 
            this.lbTimeBD.AutoSize = true;
            this.lbTimeBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeBD.Location = new System.Drawing.Point(547, 266);
            this.lbTimeBD.Name = "lbTimeBD";
            this.lbTimeBD.Size = new System.Drawing.Size(34, 20);
            this.lbTimeBD.TabIndex = 135;
            this.lbTimeBD.Text = "Giờ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 134;
            this.label4.Text = "Giờ bắt đầu:";
            // 
            // lbIdPhong
            // 
            this.lbIdPhong.AutoSize = true;
            this.lbIdPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPhong.Location = new System.Drawing.Point(710, 266);
            this.lbIdPhong.Name = "lbIdPhong";
            this.lbIdPhong.Size = new System.Drawing.Size(54, 20);
            this.lbIdPhong.TabIndex = 137;
            this.lbIdPhong.Text = "phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(631, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 136;
            this.label5.Text = "Id Phòng";
            // 
            // lbTimeKT
            // 
            this.lbTimeKT.AutoSize = true;
            this.lbTimeKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeKT.Location = new System.Drawing.Point(541, 306);
            this.lbTimeKT.Name = "lbTimeKT";
            this.lbTimeKT.Size = new System.Drawing.Size(34, 20);
            this.lbTimeKT.TabIndex = 139;
            this.lbTimeKT.Text = "Giờ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 138;
            this.label6.Text = "Giờ kết thúc:";
            // 
            // btnChonGhe
            // 
            this.btnChonGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonGhe.Location = new System.Drawing.Point(635, 298);
            this.btnChonGhe.Name = "btnChonGhe";
            this.btnChonGhe.Size = new System.Drawing.Size(106, 28);
            this.btnChonGhe.TabIndex = 140;
            this.btnChonGhe.Text = "Chọn ghế";
            this.btnChonGhe.UseVisualStyleBackColor = true;
            this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);
            // 
            // dgvGhe
            // 
            this.dgvGhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGhe.Location = new System.Drawing.Point(12, 344);
            this.dgvGhe.Name = "dgvGhe";
            this.dgvGhe.Size = new System.Drawing.Size(563, 219);
            this.dgvGhe.TabIndex = 141;
            this.dgvGhe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGhe_CellClick);
            // 
            // lbGhe
            // 
            this.lbGhe.AutoSize = true;
            this.lbGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhe.Location = new System.Drawing.Point(945, 276);
            this.lbGhe.Name = "lbGhe";
            this.lbGhe.Size = new System.Drawing.Size(40, 20);
            this.lbGhe.TabIndex = 144;
            this.lbGhe.Text = "Ghế";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(868, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 143;
            this.label7.Text = "Tên ghế:";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(945, 320);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(30, 20);
            this.lbGia.TabIndex = 146;
            this.lbGia.Text = "giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(868, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 145;
            this.label8.Text = "Giá vé:";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 28);
            this.btnThem.TabIndex = 120;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvVe
            // 
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Location = new System.Drawing.Point(635, 358);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.Size = new System.Drawing.Size(569, 152);
            this.dgvVe.TabIndex = 148;
            this.dgvVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVe_CellClick);
            // 
            // cboTk
            // 
            this.cboTk.FormattingEnabled = true;
            this.cboTk.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboTk.Location = new System.Drawing.Point(864, 239);
            this.cboTk.Name = "cboTk";
            this.cboTk.Size = new System.Drawing.Size(121, 21);
            this.cboTk.TabIndex = 149;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(774, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 150;
            this.label2.Text = "Tài Khoản:";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(766, 554);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(236, 28);
            this.btnXacNhan.TabIndex = 151;
            this.btnXacNhan.Text = "Xác nhận thanh toán";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dgvDatVe
            // 
            this.dgvDatVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatVe.Location = new System.Drawing.Point(12, 395);
            this.dgvDatVe.Name = "dgvDatVe";
            this.dgvDatVe.Size = new System.Drawing.Size(587, 236);
            this.dgvDatVe.TabIndex = 152;
            // 
            // btnThemVe
            // 
            this.btnThemVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVe.Location = new System.Drawing.Point(1075, 298);
            this.btnThemVe.Name = "btnThemVe";
            this.btnThemVe.Size = new System.Drawing.Size(129, 28);
            this.btnThemVe.TabIndex = 153;
            this.btnThemVe.Text = "ThemVe";
            this.btnThemVe.UseVisualStyleBackColor = true;
            this.btnThemVe.Click += new System.EventHandler(this.btnThemVe_Click);
            // 
            // Form_QLVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 643);
            this.Controls.Add(this.btnThemVe);
            this.Controls.Add(this.dgvDatVe);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTk);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbGhe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvGhe);
            this.Controls.Add(this.btnChonGhe);
            this.Controls.Add(this.lbTimeKT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbIdPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTimeBD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.lbTenPhim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLichChieu);
            this.Controls.Add(this.dgvPhim);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "Form_QLVe";
            this.Text = "Form_QLVe";
            this.Load += new System.EventHandler(this.Form_QLVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvLichChieu;
        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.Label lbTenPhim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lbTimeBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbIdPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTimeKT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.DataGridView dgvGhe;
        private System.Windows.Forms.Label lbGhe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.ComboBox cboTk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dgvDatVe;
        private System.Windows.Forms.Button btnThemVe;
    }
}