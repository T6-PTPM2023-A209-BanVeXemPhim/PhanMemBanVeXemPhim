using System;
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
    }
}
