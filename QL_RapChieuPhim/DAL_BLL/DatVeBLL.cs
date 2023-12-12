using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DatVeBLL
    {
        QUANLYRAPCHIEUPHIMDataContext qldatve = new QUANLYRAPCHIEUPHIMDataContext();
        public DatVeBLL()
        {

        }
        public List<DatVe> getDatve()
        {
            return qldatve.DatVes.Select(p => p).ToList<DatVe>();
        }

        public void themDatVe(DatVe dve)
        {
            try
            {
                qldatve.DatVes.InsertOnSubmit(dve);
                qldatve.SubmitChanges();
            }
            catch
            {
                return;
            }

        }

        public dynamic Load_Ve_DT(DateTime n1, DateTime n2)
        {
            var DT = (from v in qldatve.DatVes where v.NgayDat >= n1 && v.NgayDat <= n2 select new { v.IDve, v.NgayDat, v.TongTien });
            return DT;
        }
    }
}
