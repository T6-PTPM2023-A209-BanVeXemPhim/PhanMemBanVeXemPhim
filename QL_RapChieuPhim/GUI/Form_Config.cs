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
    public partial class Form_Config : Form
    {
        QL_TaiKhoan qltk = new QL_TaiKhoan();

        public Form_Config()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            qltk.SaveConfig(cmb_server.Text, txt_user.Text, txt_pass.Text, cmb_database.Text);
            DialogResult t = MessageBox.Show("Lưu chuỗi kết nối thành công!!\nQuay lại trang đăng nhập??", "Thông Báo", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                this.Dispose();
                Program.frmDangNhap.qltk = new QL_TaiKhoan();
                Program.frmDangNhap.Visible = true;
            }
            else
                return;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Program.frmDangNhap.Visible = true;
        }

        private void cmb_server_DropDown(object sender, EventArgs e)
        {
            cmb_server.DataSource = qltk.GetServerName();
            cmb_server.DisplayMember = "ServerName";
        }

        private void cmb_database_DropDown(object sender, EventArgs e)
        {
            DataTable dt = qltk.GetDbName(cmb_server.Text, txt_user.Text, txt_pass.Text);
            if (dt != null)
            {
                cmb_database.DataSource = dt;
                cmb_database.DisplayMember = "name";
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin tài khoản!!!");
            }
        }

        private void Form_Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Program.frmDangNhap.Visible = true;
        }


    }
}
