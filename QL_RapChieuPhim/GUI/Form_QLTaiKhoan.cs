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
    public partial class Form_QLTaiKhoan : Form
    {
        TaiKhoanBLL taikhoan = new TaiKhoanBLL();
        QuyenBLL quyen = new QuyenBLL();
        ThongTinBLL thongtin = new ThongTinBLL();

        public Form_QLTaiKhoan()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            Load_Data();
            Load_Combobox();
            Load_NguoiDung();
            Set_Form(false);
            Set_Form1(false);
        }

        void Load_Data()
        {
            dtg_TK.DataSource = taikhoan.Get_TaiKhoan();
        }

        void Load_NguoiDung()
        {
            dtg_tt.DataSource = thongtin.Get_ThongTin();
        }

        void Load_NguoiDung(int ID)
        {
            dtg_tt.DataSource = thongtin.Get_ThongTin(ID);
        }

        void Load_Combobox()
        {
            cmb_quyen.DataSource = quyen.Get_Quyen();
            cmb_quyen.ValueMember = "Id";
            cmb_quyen.DisplayMember = "TenQuyen";

            cmb_gt.Items.Add("Nam");
            cmb_gt.Items.Add("Nữ");
        }

        void Set_ButtunTrangThai(string t)
        {
            if (t == "True")
            {
                btn_trangthai.Text = "Hoạt Động";
                btn_trangthai.BackColor = Color.Green;
            }
            else
            {
                btn_trangthai.Text = "Khóa";
                btn_trangthai.BackColor = Color.Red;
            }
        }

        void Set_Form(bool b)
        {
            txt_tendn.Enabled = b;
            txt_matkhau.Enabled = b;
            date_ngaydk.Enabled = b;
            cmb_quyen.Enabled = b;
        }

        void Set_Form1(bool b)
        {
            txt_hoten.Enabled = b;
            txt_diachi.Enabled = b;
            date_ngaysinh.Enabled = b;
            txt_email.Enabled = b;
            cmb_gt.Enabled = b;
        }

        private void dtg_TK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtg_TK.CurrentCell.RowIndex;

            txt_tendn.Text = dtg_TK.Rows[row].Cells[1].Value.ToString();
            txt_matkhau.Text = dtg_TK.Rows[row].Cells[2].Value.ToString();
            date_ngaydk.Text = dtg_TK.Rows[row].Cells[3].Value.ToString();
            Set_ButtunTrangThai(dtg_TK.Rows[row].Cells[4].Value.ToString());
            cmb_quyen.SelectedValue = dtg_TK.Rows[row].Cells[5].Value.ToString();

            Load_NguoiDung(int.Parse(dtg_TK.Rows[row].Cells[0].Value.ToString()));
        }

        private void cmb_quyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("s");
        }

        private void btn_trangthai_Click(object sender, EventArgs e)
        {
            int row = dtg_TK.CurrentCell.RowIndex;

            int Id = int.Parse(dtg_TK.Rows[row].Cells[0].Value.ToString());
            bool TrangThai = bool.Parse(dtg_TK.Rows[row].Cells[4].Value.ToString());

            if(taikhoan.Update_TaiKhoan_TrangThai(Id, !TrangThai))
            {
                if(TrangThai)
                    MessageBox.Show("Khóa tài khoản thành công");
                else
                    MessageBox.Show("Mở khóa tài khoản thành công");

                Load_Data();
            }
            else
            {
                MessageBox.Show("Thất bại");
                return;
            }
        }

        private void Form_QLTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                Set_Form(true);
                txt_tendn.Focus();
                btn_sua.Text = "Lưu";
                btn_xoa.Text = "Hủy";
            }
            else
            {
                int row = dtg_TK.CurrentCell.RowIndex;

                int Id = int.Parse(dtg_TK.Rows[row].Cells[0].Value.ToString());
                string tendn = txt_tendn.Text;
                string matkhau = txt_matkhau.Text;
                DateTime ngaydk = date_ngaydk.Value;
                string phanquyen = cmb_quyen.SelectedValue.ToString();

                if (taikhoan.Update_TaiKhoan(Id, tendn, matkhau, ngaydk, phanquyen))
                {
                    MessageBox.Show("Cập nhật thành công");
                    btn_sua.Text = "Sửa";
                    btn_xoa.Text = "Xóa";
                    Load_Data();
                    Set_Form(false);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                    return;
                }
                
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (btn_xoa.Text == "Hủy")
            {
                btn_sua.Text = "Sửa";
                Set_Form(false);
                btn_xoa.Text = "Xóa";
            }
            else
            {
                DialogResult d = MessageBox.Show("Bạn có muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    int ID = int.Parse(dtg_TK.Rows[dtg_TK.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    if (taikhoan.Delete_TaiKhoan(ID))
                    {
                        MessageBox.Show("Xóa tài khoản thành công");
                        Load_Data();
                    }
                    else
                        MessageBox.Show("Xóa tài khoản thất bại");
                }
                else
                    return;
            }
        }

        private void btn_tt_Click(object sender, EventArgs e)
        {
            Load_NguoiDung();
        }

        private void dtg_tt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtg_tt.CurrentCell.RowIndex;

            txt_hoten.Text = dtg_tt.Rows[row].Cells[1].Value.ToString();
            txt_diachi.Text = dtg_tt.Rows[row].Cells[2].Value.ToString();
            cmb_gt.SelectedItem = dtg_tt.Rows[row].Cells[3].Value.ToString();
            date_ngaysinh.Text = dtg_tt.Rows[row].Cells[4].Value.ToString();
            txt_email.Text = dtg_tt.Rows[row].Cells[5].Value.ToString();

        }

        private void btn_suatt_Click(object sender, EventArgs e)
        {
            if (btn_suatt.Text == "Sửa")
            {
                Set_Form(true);
                txt_tendn.Focus();
                txt_hoten.Focus();
                btn_suatt.Text = "Lưu";
            }
            else
            {

            }
        }


    }
}
