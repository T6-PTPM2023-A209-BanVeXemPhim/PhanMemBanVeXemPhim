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
    public partial class Form_DoanhThu : Form
    {
        DatVeBLL datvevbll = new DatVeBLL();

        public Form_DoanhThu()
        {
            InitializeComponent();
        }

        private void txt_nbd_ValueChanged(object sender, EventArgs e)
        {
            DateTime n1 = DateTime.Parse(txt_nbd.Text);
            DateTime n2 = DateTime.Parse(txt_nkt.Text);

            load_dtg_dt(n1, n2);
        }

        void load_dtg_dt(DateTime n1, DateTime n2)
        {
            dtg_dt.DataSource = datvevbll.Load_Ve_DT(n1, n2);
            TongTien();
        }

        void TongTien()
        {
            int Tong = 0;
            for (int i = 0; i < dtg_dt.RowCount; i++)
            {
                Tong += Convert.ToInt32(dtg_dt.Rows[i].Cells[2].Value);
            }

            label_tt.Text = Tong.ToString() + " VNĐ";
        }
    }
}
