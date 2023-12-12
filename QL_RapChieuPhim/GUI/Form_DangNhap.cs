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
    public partial class Form_DangNhap : Form
    {
        public QL_TaiKhoan qltk = new QL_TaiKhoan();
        TaiKhoanBLL taikhoan = new TaiKhoanBLL();

        public Form_DangNhap()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        void DangNhap()
        {
            if (string.IsNullOrEmpty(txt_username.Text.Trim()))
            {
                MessageBox.Show("UserName không được để trống");
                txt_username.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_password.Text.Trim()))
            {
                MessageBox.Show("PassWord không được để trống");
                txt_password.Focus();
                return;
            }

            int kq = qltk.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();
            }
            else if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            else if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig();
            }
        }

        void ProcessLogin()
        {
            int kq = qltk.Check_TaiKhoan(txt_username.Text, txt_password.Text);
            if (kq == 0)
            {
                MessageBox.Show("Sai UserName hoặc PassWord");
            }
            else if (kq == 1)
            {
                MessageBox.Show("Tài khoản bị khóa");
            }
            else if (kq == 2)
            {
                int q = int.Parse(taikhoan.GetID_TaiKhoan(txt_username.Text, txt_password.Text).PhanQuyen);
                if (q != 5)
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    if (Program.frmMain == null || Program.frmMain.IsDisposed)
                    {
                        Program.frmMain = new Form_Main();
                    }
                    this.Visible = false;
                    Program.frmMain.IDTK = q;
                    Program.frmMain.Show();
                }
                else
                {
                    MessageBox.Show("Tài Khoản không có quyền vào hệ thống quản trị");
                    return;
                }
            }
        }

        void ProcessConfig()
        {
            if (Program.frmConfig == null || Program.frmConfig.IsDisposed)
            {
                Program.frmConfig = new Form_Config();
            }

            this.Visible = false;
            Program.frmConfig.Show();
        }

        private void chk_hmk_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hmk.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
    }
}
