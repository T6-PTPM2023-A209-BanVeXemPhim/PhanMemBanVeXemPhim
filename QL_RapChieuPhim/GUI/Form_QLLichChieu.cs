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
    public partial class Form_QLLichChieu : Form
    {
        PhimBLL dal_bll_phim = new PhimBLL();
        LichChieuBLL dal_bll_lichchieu = new LichChieuBLL();
        PhongBLL dal_bll_phong = new PhongBLL();
        SuatChieuBLL dal_bll_suatchieu = new SuatChieuBLL();
        PhimBLL phimbll = new PhimBLL();
        LichChieuBLL lichchieubll = new LichChieuBLL();
        PhongBLL phongbll = new PhongBLL();
        SuatChieuBLL suatchieubll = new SuatChieuBLL();


        int id_Phim = 0, id_Phong = 0;
        public Form_QLLichChieu()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void Form_QLLichChieu_Load(object sender, EventArgs e)
        {
            loadPhim_CaChieu_SuatChieu();
        }
        void loadPhim_CaChieu_SuatChieu()
        {
            dgvPhim.DataSource = dal_bll_phim.getPhim();
            dgvLichChieu.DataSource = dal_bll_lichchieu.getLichChieu();
            dgvPhong.DataSource = dal_bll_phong.getPhong();
            cboCaChieu.DataSource = dal_bll_suatchieu.getSuatChieu();
            cboCaChieu.DisplayMember = "IdSC";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (dtpNgayBatDau.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtpNgayBatDau, "Ngày bắt đầu phải lơn hơn ngày hiện tại 1 ngày");
            }
            else if(lbTenPhim.Text=="")
            {
                errorProvider1.SetError(lbTenPhim, "Vui lòng chọn phim");
               
            }
            else if (lbTenPhong.Text == "")
            {
                errorProvider1.SetError(lbTenPhong, "Vui lòng chọn phòng");
            }
            else if (cboCaChieu.Text=="")
            {
                errorProvider1.SetError(cboCaChieu, "Vui lòng chọn ca chiếu");
            }
            else if (cboCaChieu.Text == "")
            {
                errorProvider1.SetError(cboCaChieu, "Vui lòng chọn suất chiếu");
            }
            else if (txtTGBatDau.Text == "")
            {
                // thuc hien cau lenh
                errorProvider1.SetError(txtTGBatDau, "Vui lòng nhập giờ bắt đầu");
            }
            else if (txtTGKetThuc.Text == "")
            {
                errorProvider1.SetError(txtTGKetThuc, "Vui lòng nhập giờ kết thúc");
            }
            else{
               int cachieu=0;
                if(cboCaChieu.Text =="Sáng"){
                    cachieu = 1;
                }
                  if(cboCaChieu.Text =="Chiều"){
                    cachieu = 2;
                }else {
                    cachieu = 3;

                }

                LichChieu lichCnew = new LichChieu();
                lichCnew.NgayChieu = dtpNgayBatDau.Value;
                lichCnew.Thu = dtpNgayBatDau.Value.DayOfWeek.ToString();
                lichCnew.Phuthulc = 0;
                lichCnew.IdPhim = id_Phim;                
                lichCnew.IdCC = cachieu;
                lichCnew.IdSC = Convert.ToInt32(cboCaChieu.Text);
                lichCnew.GioBD = TimeSpan.Parse(txtTGBatDau.Text);
                lichCnew.GioKT = TimeSpan.Parse(txtTGKetThuc.Text);
                lichCnew.IdPhong = id_Phong;

                lichchieubll.themLichChieu(lichCnew);
                MessageBox.Show("Thêm mới lịch chiếu thành công");
                loadPhim_CaChieu_SuatChieu();
            }
        }

        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhim.CurrentCell.RowIndex;
            id_Phim = Convert.ToInt32(dgvPhim.Rows[r].Cells[0].Value.ToString());
            lbTenPhim.Text = dgvPhim.Rows[r].Cells[1].Value.ToString();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhong.CurrentCell.RowIndex;
            id_Phong = Convert.ToInt32(dgvPhong.Rows[r].Cells[0].Value.ToString());
            lbTenPhong.Text = dgvPhong.Rows[r].Cells[1].Value.ToString();
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
