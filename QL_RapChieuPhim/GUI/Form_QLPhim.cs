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
using System.IO;

namespace GUI
{
    public partial class Form_QLPhim : Form
    {
        string _fileName = "";
        int id_Phim = 0;
        OpenFileDialog open;
        PhimBLL phimbll = new PhimBLL();
        public Form_QLPhim()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form_QLPhim_Load(object sender, EventArgs e)
        {
            loadPhim();
           
        }
        private void loadPhim()
        {
            dgvPhim.DataSource = phimbll.getPhim();
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhim.CurrentCell.RowIndex;
            id_Phim = Convert.ToInt32(dgvPhim.Rows[r].Cells[0].Value.ToString());

            txtTenPhim.Text = dgvPhim.Rows[r].Cells[1].Value.ToString();
            _fileName = dgvPhim.Rows[r].Cells[2].Value.ToString();
            try
            {
                pictureBox1.Image = new Bitmap("D:\\Images_QLVP\\" + _fileName);
            }
            catch (Exception ex)
            {

            }
            txtThoiLuong.Text = dgvPhim.Rows[r].Cells[3].Value.ToString();
            txtMoTa.Text = dgvPhim.Rows[r].Cells[4].Value.ToString();
            cboTinhTrang.Text = dgvPhim.Rows[r].Cells[5].Value.ToString();
            txtLoaiPhim.Text = dgvPhim.Rows[r].Cells[6].Value.ToString();
            txtDienVien.Text = dgvPhim.Rows[r].Cells[7].Value.ToString();
            TxtDaoDien.Text = dgvPhim.Rows[r].Cells[8].Value.ToString();
            txtNgayCChieu.Text = dgvPhim.Rows[r].Cells[9].Value.ToString();
            txtNgayKT.Text = dgvPhim.Rows[r].Cells[10].Value.ToString();
            txtNamPhatHanh.Text = dgvPhim.Rows[r].Cells[11].Value.ToString();
            txtChatLuong.Text = dgvPhim.Rows[r].Cells[12].Value.ToString();
        }
        // hàm lưu ảnh vào thư mục
        private void savepicture(string _fileName)
        {
            // copy và lưu ảnh vào thư mục image
            File.Copy(open.FileName, Path.Combine("D:\\Images_QLVP\\" + _fileName), true);
        }

        // hàm xóa ảnh khỏi thư mực
        private void deletePicture(string _fileName)
        {
            if (File.Exists(Path.Combine("D:\\Images_QLVP\\", _fileName)))
            {
                File.Delete(Path.Combine("D:\\Images_QLVP\\", _fileName));
                MessageBox.Show("xóa ảnh thành công");

            }
            else
            {
                MessageBox.Show("Lỗi xóa ảnh");

            }
        }
        //hàm thêm phim
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (_fileName != "")
            {

                Phim phimnew = new Phim();

                phimnew.TenPhim = txtTenPhim.Text;
                phimnew.AnhPhim = _fileName;
                phimnew.ThoiLuong = Convert.ToInt32(txtThoiLuong.Text);
                phimnew.MoTa = txtMoTa.Text;
                phimnew.TinhTrang = bool.Parse(cboTinhTrang.Text);
                phimnew.IdLoaiPhim = txtLoaiPhim.Text;
                phimnew.DienVien = txtDienVien.Text;
                phimnew.DaoDien = TxtDaoDien.Text;
                phimnew.NgayCongChieu = Convert.ToDateTime(txtNgayCChieu.Text);
                phimnew.NgayKetThuc = Convert.ToDateTime(txtNgayKT.Text);
                phimnew.NamPhatHanh = txtNamPhatHanh.Text;
                phimnew.ChatLuong = txtChatLuong.Text;
                phimbll.themPhim(phimnew);

                savepicture(_fileName);
                MessageBox.Show("Thêm mới phim thành công");
                loadPhim();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình ảnh", "Thông báo", MessageBoxButtons.OK);
            }
           
        }
        // button đóng cửa sổ
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
            else return;
        }
        // button chọn hình ảnh phim
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Title = "Open Image";
            open.Filter = "Image files  (*.jpg ;*.gif; *.jpeg; *.bmp; *.png)|*.jpg; *.gif; *.jpeg; *.bmp; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open.FileName;

            }
            _fileName = Path.GetFileName(open.FileName);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn Xóa bộ phim này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                pictureBox1.Image = null;
                Phim xoaPhim = new Phim();
                xoaPhim.Id = id_Phim;
                phimbll.xoaPhim(xoaPhim);

                // hàm xóa ảnh bị lỗi
                // deletePicture(_fileName);

                loadPhim();
            }
            else return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn sửa thông tin phim này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {

                Phim suaPhim = new Phim();
                suaPhim.Id = id_Phim;
                suaPhim.TenPhim = txtTenPhim.Text;
                suaPhim.AnhPhim = _fileName;
                suaPhim.ThoiLuong = Convert.ToInt32(txtThoiLuong.Text);
                suaPhim.MoTa = txtMoTa.Text;
                suaPhim.TinhTrang = bool.Parse(cboTinhTrang.Text);
                suaPhim.IdLoaiPhim = txtLoaiPhim.Text;
                suaPhim.DienVien = txtDienVien.Text;
                suaPhim.DaoDien = TxtDaoDien.Text;
                suaPhim.NgayCongChieu = Convert.ToDateTime(txtNgayCChieu.Text);
                suaPhim.NgayKetThuc = Convert.ToDateTime(txtNgayKT.Text);
                suaPhim.NamPhatHanh = txtNamPhatHanh.Text;
                suaPhim.ChatLuong = txtChatLuong.Text;
                phimbll.suaPhim(suaPhim);


                loadPhim();
            }
            else return;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            loadPhim();
        }


       

    }
}
