using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class LoaiGheBLL
    {
       QUANLYRAPCHIEUPHIMDataContext qlloaiGhe = new QUANLYRAPCHIEUPHIMDataContext();
       public LoaiGheBLL()
       {

       }

       public List<LoaiGhe> getloaiGhe()
       {
           return qlloaiGhe.LoaiGhes.Select(v => v).ToList<LoaiGhe>();
       }

       public double getloaiGhe_theoIDGhe(int idl)
       {
           var a = qlloaiGhe.LoaiGhes.Where(v => v.Id == idl).Select(vs => vs.GiaGhe).FirstOrDefault();
           return a;
       }

    }
}
