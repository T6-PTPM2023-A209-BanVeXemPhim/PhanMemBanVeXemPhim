namespace GUI
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tskTien = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tskVe = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiếmLichChiếuPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstLich = new System.Windows.Forms.ToolStripMenuItem();
            this.tstVe = new System.Windows.Forms.ToolStripMenuItem();
            this.tstNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.tskKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.tstKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tshThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tshKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tshNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tshLich = new System.Windows.Forms.ToolStripMenuItem();
            this.tshTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.tshPhim = new System.Windows.Forms.ToolStripMenuItem();
            this.tshPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tshVe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tskTien
            // 
            this.tskTien.Image = ((System.Drawing.Image)(resources.GetObject("tskTien.Image")));
            this.tskTien.Name = "tskTien";
            this.tskTien.Size = new System.Drawing.Size(250, 28);
            this.tskTien.Text = "Thống kê doanh thu";
            this.tskTien.Click += new System.EventHandler(this.tskTien_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tskVe,
            this.tskTien});
            this.thốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem.Image")));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(115, 27);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // tskVe
            // 
            this.tskVe.Image = ((System.Drawing.Image)(resources.GetObject("tskVe.Image")));
            this.tskVe.Name = "tskVe";
            this.tskVe.Size = new System.Drawing.Size(250, 28);
            this.tskVe.Text = "Thống kê vé bán ra";
            this.tskVe.Click += new System.EventHandler(this.tskVe_Click);
            // 
            // timKiếmLichChiếuPhimToolStripMenuItem
            // 
            this.timKiếmLichChiếuPhimToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("timKiếmLichChiếuPhimToolStripMenuItem.Image")));
            this.timKiếmLichChiếuPhimToolStripMenuItem.Name = "timKiếmLichChiếuPhimToolStripMenuItem";
            this.timKiếmLichChiếuPhimToolStripMenuItem.Size = new System.Drawing.Size(333, 28);
            this.timKiếmLichChiếuPhimToolStripMenuItem.Text = "Tim kiếm lịch chiếu phim";
            this.timKiếmLichChiếuPhimToolStripMenuItem.Click += new System.EventHandler(this.timKiếmLichChiếuPhimToolStripMenuItem_Click);
            // 
            // tstLich
            // 
            this.tstLich.Image = ((System.Drawing.Image)(resources.GetObject("tstLich.Image")));
            this.tstLich.Name = "tstLich";
            this.tstLich.Size = new System.Drawing.Size(333, 28);
            this.tstLich.Text = "Tìm kiếm phim";
            this.tstLich.Click += new System.EventHandler(this.tstLich_Click);
            // 
            // tstVe
            // 
            this.tstVe.Image = ((System.Drawing.Image)(resources.GetObject("tstVe.Image")));
            this.tstVe.Name = "tstVe";
            this.tstVe.Size = new System.Drawing.Size(333, 28);
            this.tstVe.Text = "Tìm vé đã bán";
            this.tstVe.Click += new System.EventHandler(this.tstVe_Click);
            // 
            // tstNhanvien
            // 
            this.tstNhanvien.Image = ((System.Drawing.Image)(resources.GetObject("tstNhanvien.Image")));
            this.tstNhanvien.Name = "tstNhanvien";
            this.tstNhanvien.Size = new System.Drawing.Size(333, 28);
            this.tstNhanvien.Text = "Tìm kiếm thông tin nhân viên";
            this.tstNhanvien.Click += new System.EventHandler(this.tstNhanvien_Click);
            // 
            // tskKhach
            // 
            this.tskKhach.Image = ((System.Drawing.Image)(resources.GetObject("tskKhach.Image")));
            this.tskKhach.Name = "tskKhach";
            this.tskKhach.Size = new System.Drawing.Size(333, 28);
            this.tskKhach.Text = "Tìm kiếm thông tin khách hàng";
            this.tskKhach.Click += new System.EventHandler(this.tskKhach_Click);
            // 
            // tstKhachHang
            // 
            this.tstKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tskKhach,
            this.tstNhanvien,
            this.tstVe,
            this.tstLich,
            this.timKiếmLichChiếuPhimToolStripMenuItem});
            this.tstKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("tstKhachHang.Image")));
            this.tstKhachHang.Name = "tstKhachHang";
            this.tstKhachHang.Size = new System.Drawing.Size(100, 27);
            this.tstKhachHang.Text = "Tra cứu";
            // 
            // tshThoat
            // 
            this.tshThoat.Image = ((System.Drawing.Image)(resources.GetObject("tshThoat.Image")));
            this.tshThoat.Name = "tshThoat";
            this.tshThoat.Size = new System.Drawing.Size(224, 28);
            this.tshThoat.Text = "Thoát!";
            this.tshThoat.Click += new System.EventHandler(this.tshThoat_Click);
            // 
            // tshKhachHang
            // 
            this.tshKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("tshKhachHang.Image")));
            this.tshKhachHang.Name = "tshKhachHang";
            this.tshKhachHang.Size = new System.Drawing.Size(224, 28);
            this.tshKhachHang.Text = "Khách hàng";
            this.tshKhachHang.Click += new System.EventHandler(this.tshKhachHang_Click);
            // 
            // tshNhanVien
            // 
            this.tshNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("tshNhanVien.Image")));
            this.tshNhanVien.Name = "tshNhanVien";
            this.tshNhanVien.Size = new System.Drawing.Size(224, 28);
            this.tshNhanVien.Text = "Nhân viên";
            this.tshNhanVien.Click += new System.EventHandler(this.tshNhanVien_Click);
            // 
            // tshLich
            // 
            this.tshLich.Image = ((System.Drawing.Image)(resources.GetObject("tshLich.Image")));
            this.tshLich.Name = "tshLich";
            this.tshLich.Size = new System.Drawing.Size(224, 28);
            this.tshLich.Text = "Lịch chiếu phim";
            this.tshLich.Click += new System.EventHandler(this.tshLich_Click);
            // 
            // tshTheLoai
            // 
            this.tshTheLoai.Image = ((System.Drawing.Image)(resources.GetObject("tshTheLoai.Image")));
            this.tshTheLoai.Name = "tshTheLoai";
            this.tshTheLoai.Size = new System.Drawing.Size(224, 28);
            this.tshTheLoai.Text = "Thể loại";
            this.tshTheLoai.Click += new System.EventHandler(this.tshTheLoai_Click);
            // 
            // tshPhim
            // 
            this.tshPhim.Image = ((System.Drawing.Image)(resources.GetObject("tshPhim.Image")));
            this.tshPhim.Name = "tshPhim";
            this.tshPhim.Size = new System.Drawing.Size(224, 28);
            this.tshPhim.Text = "Phim";
            this.tshPhim.Click += new System.EventHandler(this.tshPhim_Click);
            // 
            // tshPhong
            // 
            this.tshPhong.Image = ((System.Drawing.Image)(resources.GetObject("tshPhong.Image")));
            this.tshPhong.Name = "tshPhong";
            this.tshPhong.Size = new System.Drawing.Size(224, 28);
            this.tshPhong.Text = "Phòng";
            this.tshPhong.Click += new System.EventHandler(this.tshPhong_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tshPhong,
            this.tshPhim,
            this.tshTheLoai,
            this.tshLich,
            this.tshNhanVien,
            this.tshKhachHang,
            this.tshVe,
            this.tshThoat});
            this.hệThốngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hệThốngToolStripMenuItem.Image")));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tshVe
            // 
            this.tshVe.Image = ((System.Drawing.Image)(resources.GetObject("tshVe.Image")));
            this.tshVe.Name = "tshVe";
            this.tshVe.Size = new System.Drawing.Size(224, 28);
            this.tshVe.Text = "Vé";
            this.tshVe.Click += new System.EventHandler(this.tshVe_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.tstKhachHang,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1099, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 555);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Quản lý rạp chiếu phim";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tskTien;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tskVe;
        private System.Windows.Forms.ToolStripMenuItem timKiếmLichChiếuPhimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstLich;
        private System.Windows.Forms.ToolStripMenuItem tstVe;
        private System.Windows.Forms.ToolStripMenuItem tstNhanvien;
        private System.Windows.Forms.ToolStripMenuItem tskKhach;
        private System.Windows.Forms.ToolStripMenuItem tstKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tshThoat;
        private System.Windows.Forms.ToolStripMenuItem tshKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tshNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tshLich;
        private System.Windows.Forms.ToolStripMenuItem tshTheLoai;
        private System.Windows.Forms.ToolStripMenuItem tshPhim;
        private System.Windows.Forms.ToolStripMenuItem tshPhong;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tshVe;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}