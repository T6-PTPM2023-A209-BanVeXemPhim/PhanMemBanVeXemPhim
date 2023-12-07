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
    public partial class Form_CreateTK : Form
    {
        QuyenBLL quyen = new QuyenBLL();
        TaiKhoanBLL taikhoan = new TaiKhoanBLL();
        ThongTinBLL thongtin = new ThongTinBLL();
        public Form_CreateTK()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_CreateTK_Load(object sender, EventArgs e)
        {
            Load_Combobox();
            txt_hoten.Focus();
        }

        void Load_Combobox()
        {
            cmb_quyen.DataSource = quyen.Get_Quyen();
            cmb_quyen.ValueMember = "Id";
            cmb_quyen.DisplayMember = "TenQuyen";

            cmb_gt.Items.Add("Nam");
            cmb_gt.Items.Add("Nữ");
            cmb_gt.SelectedIndex = 0;
        }

        bool Check_Rong(string Hoten, string DiaChi, string Email, string MatKhau)
        {
            
            if (string.IsNullOrEmpty(Hoten))
            {
                txt_hoten.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(DiaChi))
            {
                txt_diachi.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(Email))
            {
                txt_email.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(MatKhau))
            {
                txt_matkhau.Focus();
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Hoten = txt_hoten.Text;
            string DiaChi = txt_diachi.Text;
            string Email = txt_email.Text;
            string MatKhau = txt_matkhau.Text;
            string Gt = cmb_gt.SelectedItem.ToString();
            DateTime NgaySinh = date_ngaysinh.Value;
            string IDQuyen = cmb_quyen.SelectedValue.ToString();

            if (Check_Rong(Hoten, DiaChi, Email, MatKhau))
            {
                if (thongtin.Create_ThongTin(Hoten, DiaChi, Gt, NgaySinh, Email))
                {
                    int IDThongTin = thongtin.Get_MaxID();
                    if (taikhoan.Create_TaiKhoan(Email, MatKhau, IDQuyen, IDThongTin))
                    {
                        MessageBox.Show("Tạo tài khoản thành công");
                    }
                    else
                        MessageBox.Show("Tạo tài khoản thất bại");
                }
                else
                {
                    MessageBox.Show("Thông tin sai");
                }
            }
            else
                MessageBox.Show("Chưa điền đầy đủ thông tin");
        }



    }
}
