using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class PhimBLL
    {
       QUANLYRAPCHIEUPHIMDataContext qlphim = new QUANLYRAPCHIEUPHIMDataContext();
        public PhimBLL()
       {

       }
       public List<Phim> getPhim()
       {
           return qlphim.Phims.Select(ph => ph).ToList<Phim>();
       }

       // hàm thêm phim
       public void themPhim(Phim phim)
       {
           try
           {
               qlphim.Phims.InsertOnSubmit(phim);
               qlphim.SubmitChanges();
           }
           catch
           {
               return;
           }

       }

       // hàm xóa phim
       public void xoaPhim (Phim phim)
       {
           try
           {
               Phim xphim = qlphim.Phims.Where(p => p.Id == phim.Id).FirstOrDefault();
               qlphim.Phims.DeleteOnSubmit(xphim);
               qlphim.SubmitChanges();
           }
           catch (Exception ex)
           {

           }
       }
       
       // hàm sửa phim
       public void suaPhim(Phim phim)
       {
           Phim sPhim = qlphim.Phims.Where(p => p.Id == phim.Id).FirstOrDefault();
           if (sPhim != null)
           {
               sPhim.TenPhim = phim.TenPhim;
               sPhim.AnhPhim = phim.AnhPhim;
               sPhim.ThoiLuong = phim.ThoiLuong;
               sPhim.MoTa =    phim.MoTa;
               sPhim.TinhTrang = phim.TinhTrang;
               sPhim.IdLoaiPhim = phim.IdLoaiPhim;
               sPhim.DienVien = phim.DienVien;
               sPhim.DaoDien = phim.DaoDien;
               sPhim.NgayCongChieu = phim.NgayCongChieu;
               sPhim.NgayKetThuc = phim.NgayKetThuc;
               sPhim.NamPhatHanh = phim.NamPhatHanh;
               sPhim.ChatLuong = phim.ChatLuong;
               qlphim.SubmitChanges();
              
           }
          
       }

       public List<DataST> Load_Data()
       {
           return (from d in qlphim.DataSTs select d).ToList<DataST>();
       }
    }
}
