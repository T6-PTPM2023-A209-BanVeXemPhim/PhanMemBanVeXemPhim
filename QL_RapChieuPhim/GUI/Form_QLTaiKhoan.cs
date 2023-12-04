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

        public Form_QLTaiKhoan()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            Load_Data();
            Load_Combobox();
            Set_Form(false);
        }

        void Load_Data()
        {
            dtg_TK.DataSource = taikhoan.Get_TaiKhoan();
        }

        void Load_Combobox()
        {
            cmb_quyen.DataSource = quyen.Get_Quyen();
            cmb_quyen.ValueMember = "Id";
            cmb_quyen.DisplayMember = "TenQuyen";
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

        private void dtg_TK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtg_TK.CurrentCell.RowIndex;

            txt_tendn.Text = dtg_TK.Rows[row].Cells[1].Value.ToString();
            txt_matkhau.Text = dtg_TK.Rows[row].Cells[2].Value.ToString();
            date_ngaydk.Text = dtg_TK.Rows[row].Cells[3].Value.ToString();
            Set_ButtunTrangThai(dtg_TK.Rows[row].Cells[4].Value.ToString());
            cmb_quyen.SelectedValue = dtg_TK.Rows[row].Cells[5].Value.ToString();
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

        }


    }
}
