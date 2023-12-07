namespace GUI
{
    partial class Form_QLLichChieu
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
            this.components = new System.ComponentModel.Container();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvLichChieu = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboCaChieu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenPhim = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSuatChieu = new System.Windows.Forms.ComboBox();
            this.txtTGBatDau = new System.Windows.Forms.TextBox();
            this.txtTGKetThuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(542, 357);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayBatDau.TabIndex = 123;
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(8, 279);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(398, 130);
            this.dgvPhong.TabIndex = 122;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // dgvLichChieu
            // 
            this.dgvLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieu.Location = new System.Drawing.Point(542, 43);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.Size = new System.Drawing.Size(693, 230);
            this.dgvLichChieu.TabIndex = 120;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(263, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 28);
            this.btnClose.TabIndex = 119;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(178, 9);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 28);
            this.btnSua.TabIndex = 118;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(93, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 28);
            this.btnXoa.TabIndex = 117;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(8, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 28);
            this.btnThem.TabIndex = 116;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvPhim
            // 
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhim.Location = new System.Drawing.Point(8, 43);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.Size = new System.Drawing.Size(528, 230);
            this.dgvPhim.TabIndex = 115;
            this.dgvPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cboCaChieu
            // 
            this.cboCaChieu.FormattingEnabled = true;
            this.cboCaChieu.Location = new System.Drawing.Point(542, 400);
            this.cboCaChieu.Name = "cboCaChieu";
            this.cboCaChieu.Size = new System.Drawing.Size(150, 21);
            this.cboCaChieu.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 125;
            this.label1.Text = "ngày chiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "ca chiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 127;
            this.label3.Text = "Tên phim:";
            // 
            // lbTenPhim
            // 
            this.lbTenPhim.AutoSize = true;
            this.lbTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhim.Location = new System.Drawing.Point(538, 302);
            this.lbTenPhim.Name = "lbTenPhim";
            this.lbTenPhim.Size = new System.Drawing.Size(74, 20);
            this.lbTenPhim.TabIndex = 128;
            this.lbTenPhim.Text = "Tên phim";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhong.Location = new System.Drawing.Point(999, 332);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(85, 20);
            this.lbTenPhong.TabIndex = 130;
            this.lbTenPhong.Text = "Tên phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(908, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "Tên phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 131;
            this.label4.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            this.cboSuatChieu.FormattingEnabled = true;
            this.cboSuatChieu.Items.AddRange(new object[] {
            "Sáng",
            "Chiều",
            "Tối"});
            this.cboSuatChieu.Location = new System.Drawing.Point(548, 434);
            this.cboSuatChieu.Name = "cboSuatChieu";
            this.cboSuatChieu.Size = new System.Drawing.Size(150, 21);
            this.cboSuatChieu.TabIndex = 132;
            // 
            // txtTGBatDau
            // 
            this.txtTGBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGBatDau.Location = new System.Drawing.Point(985, 395);
            this.txtTGBatDau.Name = "txtTGBatDau";
            this.txtTGBatDau.Size = new System.Drawing.Size(149, 26);
            this.txtTGBatDau.TabIndex = 133;
            // 
            // txtTGKetThuc
            // 
            this.txtTGKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGKetThuc.Location = new System.Drawing.Point(985, 434);
            this.txtTGKetThuc.Name = "txtTGKetThuc";
            this.txtTGKetThuc.Size = new System.Drawing.Size(149, 26);
            this.txtTGKetThuc.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(833, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 135;
            this.label6.Text = "Thời gian bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(833, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 136;
            this.label7.Text = "Thời gian kết thúc";
            // 
            // Form_QLLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 548);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTGKetThuc);
            this.Controls.Add(this.txtTGBatDau);
            this.Controls.Add(this.cboSuatChieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTenPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTenPhim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCaChieu);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.dgvLichChieu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPhim);
            this.Name = "Form_QLLichChieu";
            this.Text = "Form_QLLichChieu";
            this.Load += new System.EventHandler(this.Form_QLLichChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvLichChieu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPhim;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboCaChieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenPhim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTGKetThuc;
        private System.Windows.Forms.TextBox txtTGBatDau;
    }
}