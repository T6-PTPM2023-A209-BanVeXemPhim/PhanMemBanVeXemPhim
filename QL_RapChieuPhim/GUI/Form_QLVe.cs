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
    public partial class Form_QLVe : Form
    {
        PhimBLL phimbll = new PhimBLL();
        LichChieuBLL lichChieubll = new LichChieuBLL();
        VeBLL vebll = new VeBLL();
        GheBLL ghebll = new GheBLL();
        LoaiGheBLL loaighebll = new LoaiGheBLL();
        TaiKhoanBLL tkbll = new TaiKhoanBLL();
        DatVeBLL datvebll = new DatVeBLL();

        int id_Phim = 0, id_ghe = 0, id_lichChieu =0;
        string iddatve;
        public Form_QLVe()
        {

            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            load_lichchieu(id_Phim, dtpNgayBatDau.Value);

        }

        private void Form_QLVe_Load(object sender, EventArgs e)
        {
            load_Phim();
            dgvDatVe.Visible = false;

        }
        // hàm load phim
        private void load_Phim()
        {
            dgvPhim.DataSource = phimbll.getPhim();
            cboTk.DataSource = tkbll.Get_TaiKhoan();
           
            cboTk.DisplayMember = "Id";

        }

        // hàm load lich chiếu theo id phim và ngày được chọn
        private void load_lichchieu(int idphim, DateTime day)
        {
            dgvLichChieu.DataSource = lichChieubll.getLichChieu_theoNgay(idphim, day);
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhim.CurrentCell.RowIndex;
            id_Phim = Convert.ToInt32(dgvPhim.Rows[r].Cells[0].Value.ToString());

            lbTenPhim.Text = dgvPhim.Rows[r].Cells[1].Value.ToString();
        }

        private void dgvLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int r = dgvLichChieu.CurrentCell.RowIndex;

           id_lichChieu =Convert.ToInt32( dgvLichChieu.Rows[r].Cells[0].Value.ToString());

            lbTimeBD.Text = dgvLichChieu.Rows[r].Cells[7].Value.ToString();
            lbTimeKT.Text = dgvLichChieu.Rows[r].Cells[8].Value.ToString();
            lbIdPhong.Text = dgvLichChieu.Rows[r].Cells[9].Value.ToString();
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
           
            dgvGhe.DataSource = ghebll.getGhe_theoPhong(Convert.ToInt32(lbIdPhong.Text));
           
        }

        private void dgvGhe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvGhe.CurrentCell.RowIndex;
            lbGhe.Text = dgvGhe.Rows[r].Cells[4].Value.ToString();
            id_ghe =Convert.ToInt32(  dgvGhe.Rows[r].Cells[0].Value.ToString());
            lbGia.Text = loaighebll.getloaiGhe_theoIDGhe(Convert.ToInt32(dgvGhe.Rows[r].Cells[1].Value)).ToString();
        }

        private void btnDatTamThoi_Click(object sender, EventArgs e)
        {
            
        }
        private void loadVe()
        {
            dgvVe.DataSource = vebll.getVe();
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            try
            {
            DatVe dve = new DatVe();
            dve.IDTK = Convert.ToInt32(cboTk.Text);
            dve.IDve = iddatve;
            dve.NgayDat = DateTime.UtcNow.Date;
            dve.TongTien = Convert.ToInt32(lbGia.Text);

            datvebll.themDatVe(dve);
            MessageBox.Show("Thanh toán thành công");

           dgvDatVe.DataSource= datvebll.getDatve();
            }catch(Exception){
            MessageBox.Show("Thanh toán thất bại");

            }

  
        }

        private void btnThemVe_Click(object sender, EventArgs e)
        {

            try
            {
            Ve ves1 = new Ve();
            ves1.IdTaiKhoan = Convert.ToInt32(cboTk.Text);
            ves1.IdPhim = id_Phim;
            ves1.IdGhe = id_ghe;
            ves1.NgayDat = dtpNgayBatDau.Value;
            ves1.GiaVe = Convert.ToDecimal(lbGia.Text);
            ves1.Soluong = 1;
            ves1.IdLC = id_lichChieu;

            ves1.TinhTrang = 0;
            vebll.themVe(ves1);
            MessageBox.Show("Thêm mới vé thành công");

            dgvGhe.Visible = false;
            dgvDatVe.Visible = true;
            loadVe();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới vé thất bại");

            }
          

        }

        private void dgvVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvVe.CurrentCell.RowIndex;
            iddatve = dgvVe.Rows[r].Cells[0].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            DialogResult a = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
            else return;
        }
    }
}
