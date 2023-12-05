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
