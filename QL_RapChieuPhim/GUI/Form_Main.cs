using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_Main : Form
    {
        public int IDTK = 1;
        Form frm;
        public Form_Main()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (IDTK != 1)
            {
                FindMenuPhanQuyen(menuStrip1.Items);
            }

        }

        void FindMenuPhanQuyen(ToolStripItemCollection Item)
        {
            foreach (ToolStripItem menu in Item)
            {
                if (menu is ToolStripMenuItem && ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {
                    FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Enabled = CheckAllMenuChillVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(IDTK.ToString(), menu.Tag) || string.Equals("0", menu.Tag))
                {
                    menu.Enabled = true;
                    menu.Visible = true;
                }
                else
                {
                    menu.Enabled = false;
                    menu.Visible = false;
                }
            }
        }

        bool CheckAllMenuChillVisible(ToolStripItemCollection mn)
        {
            foreach (ToolStripItem m in mn)
            {
                if (m is ToolStripMenuItem && m.Enabled)
                {
                    return true;
                }
                else if (m is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;
        }

        void OpenForm(Form f)
        {
            if (frm != null)
            {
                frm.Close();
            }
            frm = f;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm);
            panel1.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.frmQLTaiKhoan == null || Program.frmQLTaiKhoan.IsDisposed)
                Program.frmQLTaiKhoan = new Form_QLTaiKhoan();

            OpenForm(Program.frmQLTaiKhoan);
        }

        private void phimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.frmPhim == null || Program.frmPhim.IsDisposed)
                Program.frmPhim = new Form_QLPhim();

            OpenForm(Program.frmPhim);
        }

        private void thoatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.frmCreateTK == null || Program.frmCreateTK.IsDisposed)
                Program.frmCreateTK = new Form_CreateTK();

            Program.frmCreateTK.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.frmPhong == null || Program.frmPhong.IsDisposed)
                Program.frmPhong = new Form_Phong();

            OpenForm(Program.frmPhong);
        }
    }
}
