using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
  public  class DatVeBLL
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
    }
}
