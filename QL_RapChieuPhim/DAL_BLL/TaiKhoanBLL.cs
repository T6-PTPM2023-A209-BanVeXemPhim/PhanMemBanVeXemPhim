﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class TaiKhoanBLL
    {
        QUANLYRAPCHIEUPHIMDataContext qlrcp = new QUANLYRAPCHIEUPHIMDataContext();
        public List<TaiKhoan> Check_TaiKhoan(string user, string pass)
        {
            return (from tk in qlrcp.TaiKhoans where tk.TenDangNhap == user && tk.MatKhau == pass select tk).ToList<TaiKhoan>();
        }

        public dynamic Get_TaiKhoan()
        {
            return from tk in qlrcp.TaiKhoans select new { tk.Id, tk.TenDangNhap, tk.MatKhau, tk.NgayDangKy, tk.TinhTrang, tk.PhanQuyen, tk.id_ThongTin };
        }

        public bool Update_TaiKhoan(int Id, string tentk, string matkhau, DateTime ngay, string quyen)
        {
            TaiKhoan tk = qlrcp.TaiKhoans.Where(t => t.Id == Id).FirstOrDefault();
            if (tk != null)
            {
                tk.TenDangNhap = tentk;
                tk.MatKhau = matkhau;
                tk.NgayDangKy = ngay;
                tk.PhanQuyen = quyen;

                qlrcp.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update_TaiKhoan_TrangThai(int Id, bool TrangThai)
        {
            TaiKhoan tk = qlrcp.TaiKhoans.Where(t => t.Id == Id).FirstOrDefault();
            if (tk != null)
            {
                tk.TinhTrang = TrangThai;

                qlrcp.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete_TaiKhoan(int Id)
        {
            TaiKhoan tk = qlrcp.TaiKhoans.Where(t => t.Id == Id).FirstOrDefault();
            if (tk != null)
            {
                qlrcp.TaiKhoans.DeleteOnSubmit(tk);
                qlrcp.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
