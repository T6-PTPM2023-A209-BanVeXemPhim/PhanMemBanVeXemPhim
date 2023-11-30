using DAL_BLL;
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
        public static bool flag;
        public Form_Main()
        {
            InitializeComponent();
            flag = false;
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult dr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
                e.Cancel = false;
            }
            else
            {
                flag = false;
            }
            Program.frmDangNhap.Visible = true;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void tshThoat_Click(object sender, EventArgs e)
        {
            flag = true;
            this.Close();
        }

        private void tshPhong_Click(object sender, EventArgs e)
        {
            frm_Phong p = new frm_Phong();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }
        public bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == formType.Name)
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }

        private void tshPhim_Click(object sender, EventArgs e)
        {
            frm_Phim p = new frm_Phim();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tshTheLoai_Click(object sender, EventArgs e)
        {
            frm_TheLoai p = new frm_TheLoai();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tshLich_Click(object sender, EventArgs e)
        {
            frm_LichChieu p = new frm_LichChieu();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tshNhanVien_Click(object sender, EventArgs e)
        {
            frm_QuanLyNhanVien p = new frm_QuanLyNhanVien();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tshKhachHang_Click(object sender, EventArgs e)
        {
            frm_QLKhachHang p = new frm_QLKhachHang();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tshVe_Click(object sender, EventArgs e)
        {
            frm_Ve p = new frm_Ve();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tskKhach_Click(object sender, EventArgs e)
        {
            frm_TimKiemKhachHang p = new frm_TimKiemKhachHang();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tstNhanvien_Click(object sender, EventArgs e)
        {
            frm_TimKiemNhanVien p = new frm_TimKiemNhanVien();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tstVe_Click(object sender, EventArgs e)
        {
            frm_TimKiemVe p = new frm_TimKiemVe();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tstLich_Click(object sender, EventArgs e)
        {
            frm_TimKiemPhim p = new frm_TimKiemPhim();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void timKiếmLichChiếuPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TimLichChieu p = new frm_TimLichChieu();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tskVe_Click(object sender, EventArgs e)
        {
            frm_ThongKeVeBan p = new frm_ThongKeVeBan();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }

        private void tskTien_Click(object sender, EventArgs e)
        {
            frm_ThongKeDoanhThu p = new frm_ThongKeDoanhThu();
            bool winTest = IsFormOpen(p.GetType());
            if (winTest == false)
            {
                p.MdiParent = this;
                p.Show();
            }
        }
    }
}
