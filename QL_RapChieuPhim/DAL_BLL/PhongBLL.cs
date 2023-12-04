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
         public List<Phong> getPhong()
         {
             return qlphong.Phongs.Select(p => p).ToList<Phong>();
         }
    }
}
