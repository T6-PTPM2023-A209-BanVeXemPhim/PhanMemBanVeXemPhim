using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   public class GheBLL
    {
        
            QUANLYRAPCHIEUPHIMDataContext qlghe = new QUANLYRAPCHIEUPHIMDataContext();
            public GheBLL()
            {

            }

            public List<Ghe> getGhe_theoPhong(int phong)
            {
        
        
                return qlghe.Ghes.Where(gh => gh.Id_phong == phong).ToList<Ghe>();
            }
        
    }
}
