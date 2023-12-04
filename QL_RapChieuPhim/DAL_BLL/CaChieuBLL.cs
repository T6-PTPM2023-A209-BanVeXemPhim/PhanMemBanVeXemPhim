using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public  class CaChieuBLL
    {
       QUANLYRAPCHIEUPHIMDataContext qlcchieu = new QUANLYRAPCHIEUPHIMDataContext();
       public CaChieuBLL()
       {

       }
       public List<CaChieu> getCaChieu()
       {
           return qlcchieu.CaChieus.Select(cch => cch).ToList<CaChieu>();
       }
    }
}
