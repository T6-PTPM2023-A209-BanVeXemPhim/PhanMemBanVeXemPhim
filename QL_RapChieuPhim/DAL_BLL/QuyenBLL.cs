using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class QuyenBLL
    {
        QUANLYRAPCHIEUPHIMDataContext qlrcp = new QUANLYRAPCHIEUPHIMDataContext();

        public QuyenBLL()
        {

        }

        public List<Quyen> Get_Quyen()
        {
            return (from q in qlrcp.Quyens select q).ToList<Quyen>();
        }
    }
}
