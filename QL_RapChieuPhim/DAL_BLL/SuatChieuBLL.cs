using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public  class SuatChieuBLL
    {
       
       QUANLYRAPCHIEUPHIMDataContext qlsuatChieu = new QUANLYRAPCHIEUPHIMDataContext();
       public SuatChieuBLL()
       {

       }

       public List<Suatchieu> getSuatChieu()
       {
           return qlsuatChieu.Suatchieus.Select(sc => sc).ToList<Suatchieu>();
       }
    }
}
