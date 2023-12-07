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
        Form frm;
        public Form_Main()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

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

        private void lịchChiếuPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (Program.frmQLLC == null || Program.frmPhim.IsDisposed)
                Program.frmQLLC = new Form_QLLichChieu();

            OpenForm(Program.frmQLLC);

        }
    }
}
