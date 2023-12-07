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
    public partial class Form_Phong : Form
    {
        PhongBLL phong = new PhongBLL();
        bool s;

        public Form_Phong()
        {
            InitializeComponent();
            //CenterToScreen();
        }

        private void Form_Phong_Load(object sender, EventArgs e)
        {
            load_dtg();
        }

        void load_dtg()
        {
            dtg_phong.DataSource = phong.getPhong();
        }

        private void dtg_phong_SelectionChanged(object sender, EventArgs e)
        {
            int row = dtg_phong.CurrentCell.RowIndex;

            txt_tenp.Text = dtg_phong.Rows[row].Cells[1].Value.ToString();
            txt_slh.Text = dtg_phong.Rows[row].Cells[3].Value.ToString();
            txt_slg.Text = dtg_phong.Rows[row].Cells[4].Value.ToString();
            txt_mota.Text = dtg_phong.Rows[row].Cells[6].Value.ToString();
            Set_ButtunTrangThai(dtg_phong.Rows[row].Cells[5].Value.ToString());
        }

        void Set_ButtunTrangThai(string t)
        {
            if (t == "True")
            {
                btn_tinhtrang.Text = "Hoạt Động";
                btn_tinhtrang.BackColor = Color.Green;
            }
            else
            {
                btn_tinhtrang.Text = "Đóng Cửa";
                btn_tinhtrang.BackColor = Color.Red;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                txt_tenp.Text = "";
                txt_slh.Text = "";
                txt_slg.Text = "";
                txt_mota.Text = "";
                txt_tenp.Focus();
                btn_them.Text = "Lưu";
                s = true;
            }
            else
            {
                if (s)
                {
                    if (phong.Create_Phong(txt_tenp.Text, int.Parse(txt_slh.Text), int.Parse(txt_slg.Text), txt_mota.Text))
                        MessageBox.Show("Thanh Cong");
                    else
                        MessageBox.Show("That Bai");
                }
                else
                {
                    if (phong.Update_Phong(int.Parse(dtg_phong.Rows[dtg_phong.CurrentCell.RowIndex].Cells[0].Value.ToString()), txt_tenp.Text,
                        int.Parse(txt_slh.Text), int.Parse(txt_slg.Text), txt_mota.Text))
                        MessageBox.Show("Thanh Cong");
                    else
                        MessageBox.Show("That Bai");

                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn xóa tài khoản?", "Thông Báo", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if(phong.Delete_Phong(int.Parse(dtg_phong.Rows[dtg_phong.CurrentCell.RowIndex].Cells[0].Value.ToString())))
                    MessageBox.Show("Thanh Cong");
                else
                    MessageBox.Show("That Bai");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_tenp.Focus();
            s = false;
        }
    }
}
