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
            this.thoatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhMụcQuảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tạoTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.doanhMụcQuảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1899, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatsToolStripMenuItem,
            this.tạoTàiKhoảnToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(101, 42);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // thoatsToolStripMenuItem
            // 
            this.thoatsToolStripMenuItem.Name = "thoatsToolStripMenuItem";
            this.thoatsToolStripMenuItem.Size = new System.Drawing.Size(176, 42);
            this.thoatsToolStripMenuItem.Text = "Thoát";
            this.thoatsToolStripMenuItem.Click += new System.EventHandler(this.thoatsToolStripMenuItem_Click);
            // 
            // doanhMụcQuảnLýToolStripMenuItem
            // 
            this.doanhMụcQuảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.phimToolStripMenuItem});
            this.doanhMụcQuảnLýToolStripMenuItem.Name = "doanhMụcQuảnLýToolStripMenuItem";
            this.doanhMụcQuảnLýToolStripMenuItem.Size = new System.Drawing.Size(282, 42);
            this.doanhMụcQuảnLýToolStripMenuItem.Text = "Doanh Mục Quản Lý";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(225, 42);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // phimToolStripMenuItem
            // 
            this.phimToolStripMenuItem.Name = "phimToolStripMenuItem";
            this.phimToolStripMenuItem.Size = new System.Drawing.Size(225, 42);
            this.phimToolStripMenuItem.Text = "Phim";
            this.phimToolStripMenuItem.Click += new System.EventHandler(this.phimToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1893, 989);
            this.panel1.TabIndex = 1;
            // 
            // tạoTàiKhoảnToolStripMenuItem
            // 
            this.tạoTàiKhoảnToolStripMenuItem.Name = "tạoTàiKhoảnToolStripMenuItem";
            this.tạoTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(278, 42);
            this.tạoTàiKhoảnToolStripMenuItem.Text = "Tạo Tài Khoản";
            this.tạoTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tạoTàiKhoảnToolStripMenuItem_Click);
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
    }
}