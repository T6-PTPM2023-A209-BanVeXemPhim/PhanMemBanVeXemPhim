using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class ThongTinBLL
    {
        QUANLYRAPCHIEUPHIMDataContext qlrcp = new QUANLYRAPCHIEUPHIMDataContext();

        public ThongTinBLL()
        {

        }

        public List<ThongTin> Get_ThongTin()
        {
            return (from tt in qlrcp.ThongTins select tt).ToList<ThongTin>();
        }

        public List<ThongTin> Get_ThongTin(int ID)
        {
            return (from tt in qlrcp.ThongTins where tt.ThongTin_id == ID select tt).ToList<ThongTin>();
        }

        public bool Create_ThongTin(string TenND, string DiaChi, string GioiTinh, DateTime NgaySinh, string Email)
        {
            try
            {
                ThongTin thongtin = new ThongTin();
                thongtin.TenNguoiDung = TenND;
                thongtin.DiaChi = DiaChi;
                thongtin.GioiTinh = GioiTinh;
                thongtin.NgaySinh = NgaySinh;
                thongtin.Email = Email;

                qlrcp.ThongTins.InsertOnSubmit(thongtin);
                qlrcp.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Get_MaxID()
        {
            return qlrcp.ThongTins.Max(t => t.ThongTin_id);
        }

        public bool Update_ThongTin(int ID, string HoTen, string DiaChi, string GioiTinh, DateTime Ngay, string Email)
        {
            ThongTin tt = qlrcp.ThongTins.Where(t => t.ThongTin_id == ID).FirstOrDefault();
            if (tt != null)
            {
                tt.TenNguoiDung = HoTen;
                tt.DiaChi = DiaChi;
                tt.GioiTinh = GioiTinh;
                tt.NgaySinh = Ngay;
                tt.Email = Email;

                qlrcp.SubmitChanges();

                return true;
            }
            else
                return false;
        }

        public bool Delete_ThongTin(int ID)
        {
            ThongTin tt = qlrcp.ThongTins.Where(t => t.ThongTin_id == ID).FirstOrDefault();

            if (tt != null)
            {
                qlrcp.ThongTins.DeleteOnSubmit(tt);
                qlrcp.SubmitChanges();
                return true;
            }
            else
                return false;
        }
    }
}
