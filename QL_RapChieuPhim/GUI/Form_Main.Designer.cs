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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhMụcQuảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchChiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.véToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.doanhMụcQuảnLýToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1899, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoTàiKhoảnToolStripMenuItem,
            this.aIToolStripMenuItem,
            this.thoatsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(101, 42);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tạoTàiKhoảnToolStripMenuItem
            // 
            this.tạoTàiKhoảnToolStripMenuItem.Name = "tạoTàiKhoảnToolStripMenuItem";
            this.tạoTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(278, 42);
            this.tạoTàiKhoảnToolStripMenuItem.Tag = "1";
            this.tạoTàiKhoảnToolStripMenuItem.Text = "Tạo Tài Khoản";
            this.tạoTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tạoTàiKhoảnToolStripMenuItem_Click);
            // 
            // thoatsToolStripMenuItem
            // 
            this.thoatsToolStripMenuItem.Name = "thoatsToolStripMenuItem";
            this.thoatsToolStripMenuItem.Size = new System.Drawing.Size(278, 42);
            this.thoatsToolStripMenuItem.Tag = "0";
            this.thoatsToolStripMenuItem.Text = "Thoát";
            this.thoatsToolStripMenuItem.Click += new System.EventHandler(this.thoatsToolStripMenuItem_Click);
            // 
            // doanhMụcQuảnLýToolStripMenuItem
            // 
            this.doanhMụcQuảnLýToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan;
            this.doanhMụcQuảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.phimToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.lịchChiếuToolStripMenuItem,
            this.véToolStripMenuItem});
            this.doanhMụcQuảnLýToolStripMenuItem.Name = "doanhMụcQuảnLýToolStripMenuItem";
            this.doanhMụcQuảnLýToolStripMenuItem.Size = new System.Drawing.Size(282, 42);
            this.doanhMụcQuảnLýToolStripMenuItem.Text = "Doanh Mục Quản Lý";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(234, 42);
            this.tàiKhoảnToolStripMenuItem.Tag = "1";
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // phimToolStripMenuItem
            // 
            this.phimToolStripMenuItem.Name = "phimToolStripMenuItem";
            this.phimToolStripMenuItem.Size = new System.Drawing.Size(234, 42);
            this.phimToolStripMenuItem.Tag = "3";
            this.phimToolStripMenuItem.Text = "Phim";
            this.phimToolStripMenuItem.Click += new System.EventHandler(this.phimToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(234, 42);
            this.phòngToolStripMenuItem.Tag = "4";
            this.phòngToolStripMenuItem.Text = "Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // lịchChiếuToolStripMenuItem
            // 
            this.lịchChiếuToolStripMenuItem.Name = "lịchChiếuToolStripMenuItem";
            this.lịchChiếuToolStripMenuItem.Size = new System.Drawing.Size(234, 42);
            this.lịchChiếuToolStripMenuItem.Tag = "3";
            this.lịchChiếuToolStripMenuItem.Text = "Lịch Chiếu";
            this.lịchChiếuToolStripMenuItem.Click += new System.EventHandler(this.lịchChiếuToolStripMenuItem_Click);
            // 
            // véToolStripMenuItem
            // 
            this.véToolStripMenuItem.Name = "véToolStripMenuItem";
            this.véToolStripMenuItem.Size = new System.Drawing.Size(234, 42);
            this.véToolStripMenuItem.Tag = "3";
            this.véToolStripMenuItem.Text = "Vé";
            this.véToolStripMenuItem.Click += new System.EventHandler(this.véToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(166, 42);
            this.doanhThuToolStripMenuItem.Tag = "2";
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1893, 989);
            this.panel1.TabIndex = 1;
            // 
            // aIToolStripMenuItem
            // 
            this.aIToolStripMenuItem.Name = "aIToolStripMenuItem";
            this.aIToolStripMenuItem.Size = new System.Drawing.Size(278, 42);
            this.aIToolStripMenuItem.Tag = "1";
            this.aIToolStripMenuItem.Text = "AI";
            this.aIToolStripMenuItem.Click += new System.EventHandler(this.aIToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1899, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem thoatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhMụcQuảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchChiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem véToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aIToolStripMenuItem;
    }
}