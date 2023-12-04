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
        public Form_Main()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Program.frmDangNhap.Visible = true;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void phimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frmPhim = new Form_QLPhim();
            Program.frmPhim.Visible = true;
        }
    }
}
