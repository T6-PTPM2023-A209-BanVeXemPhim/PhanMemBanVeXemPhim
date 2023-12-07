using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class PhongBLL
    {
        QUANLYRAPCHIEUPHIMDataContext qlphong = new QUANLYRAPCHIEUPHIMDataContext();
        public PhongBLL()
        {

        }
        public dynamic getPhong()
        {
            return (from p in qlphong.Phongs select p);
        }

        public bool Create_Phong(string ten, int slh, int slg, string mota)
        {
            try
            {
                Phong p = new Phong();
                p.TenPhong = ten;
                p.SoluongHang = slh;
                p.Soluongghemoihang = slg;
                p.SoLuong = slg * slh;
                p.TrinhTrang = true;
                p.MoTa = mota;

                qlphong.Phongs.InsertOnSubmit(p);
                qlphong.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update_Phong(int ID, string ten, int slh, int slg, string mota)
        {
            Phong p = qlphong.Phongs.Where(t => t.Id == ID).FirstOrDefault();
            if (p != null)
            {
                p.TenPhong = ten;
                p.SoluongHang = slh;
                p.Soluongghemoihang = slg;
                p.SoLuong = slh * slg;

                qlphong.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update_PhongTT(int ID, bool tt)
        {
            Phong p = qlphong.Phongs.Where(t => t.Id == ID).FirstOrDefault();
            if (p != null)
            {
                p.TrinhTrang = tt;

                qlphong.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Delete_Phong(int ID)
        {
            Phong p = qlphong.Phongs.Where(t => t.Id == ID).FirstOrDefault();
            if (p != null)
            {
                qlphong.Phongs.DeleteOnSubmit(p);
                qlphong.SubmitChanges();
                return true;
            }
            else
                return false;
        }
    }
}
