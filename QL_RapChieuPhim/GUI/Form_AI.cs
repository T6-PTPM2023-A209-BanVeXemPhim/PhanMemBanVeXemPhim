using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;

namespace GUI
{
    public partial class Form_AI : Form
    {
        PhimBLL phimbll = new PhimBLL();
        machinelearningBLL mc = new machinelearningBLL();
        string file = @"D:\GitHub\PhanMemBanVeXemPhim\RapChieuPhim\RapChieuPhim\Content\Upload\AI\id3.bin";

        public Form_AI()
        {
            InitializeComponent();
        }

        private void Form_AI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = phimbll.Load_Data();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Leaning();
        }

        void Leaning()
        {
            List<DataST> dt = phimbll.Load_Data();
            if (mc.Lean(file, dt))
                MessageBox.Show("Lưu fiel Tree thành công");
            else
                MessageBox.Show("Lưu file thất bại");
        }
    }
}
