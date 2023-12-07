using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class VeBLL
    {
        QUANLYRAPCHIEUPHIMDataContext qlve = new QUANLYRAPCHIEUPHIMDataContext();
        public VeBLL()
        {

        }
        public List<Ve> getVe()
        {
            return qlve.Ves.Select(v => v).ToList<Ve>();
        }

        // hàm thêm vé
        public void themVe(Ve ve)
        {
            try
            {
                qlve.Ves.InsertOnSubmit(ve);
                qlve.SubmitChanges();
            }
            catch
            {
                return;
            }

        }
    }
}
