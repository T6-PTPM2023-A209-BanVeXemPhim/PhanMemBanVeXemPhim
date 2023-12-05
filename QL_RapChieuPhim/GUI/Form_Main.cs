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
    }
}
