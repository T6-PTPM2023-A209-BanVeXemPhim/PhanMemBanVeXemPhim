using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class LichChieuBLL
    {
        QUANLYRAPCHIEUPHIMDataContext qlLichChieu = new QUANLYRAPCHIEUPHIMDataContext();
        public LichChieuBLL()
        {

        }

        public List<LichChieu> getLichChieu()
        {
            return qlLichChieu.LichChieus.Select(lc => lc).ToList<LichChieu>();
        }
        public void themLichChieu(LichChieu sc)
        {
            try
            {
                qlLichChieu.LichChieus.InsertOnSubmit(sc);
                qlLichChieu.SubmitChanges();
            }
            catch
            {
                return;
            }

        }
        public List<LichChieu> getLichChieu_theoNgay(int idphim, DateTime dt)
        {
            return qlLichChieu.LichChieus.Where(lc => lc.IdPhim == idphim && lc.NgayChieu.Day == dt.Day && lc.NgayChieu.Month == dt.Month).ToList<LichChieu>();
        }
    }
}
