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
            cboSuatChieu.DataSource = dal_bll_suatchieu.getSuatChieu();
            cboSuatChieu.DisplayMember = "TenSuat";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (dtpNgayBatDau.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtpNgayBatDau, "Ngày bắt đầu phải lơn hơn ngày hiện tại 1 ngày");
            }
            else
            {
                // thuc hien cau lenh

            }
        }


    }
}
