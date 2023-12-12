using RapChieuPhim.Dao;
using RapChieuPhim.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Accord;
using Accord.Math;
using System.Data;
using Accord.IO;
using Accord.MachineLearning.DecisionTrees;
using Accord.Statistics.Filters;

namespace RapChieuPhim.Controllers
{
    public class HomeController : Controller
    {
        private PhimDao daoP = new PhimDao();
        Data dbl = new Data();
        private DataTable data;
        private DecisionTree tree = Serializer.Load<DecisionTree>(@"D:\GitHub\PhanMemBanVeXemPhim\RapChieuPhim\RapChieuPhim\Content\Upload\AI\id3.bin");

        public ActionResult Index()
        {
            
            var sothhich1 = Request.Form["showloai1"];
            var sothhich2 = Request.Form["showloai2"];
            var sothhich3 = Request.Form["showloai3"];

            if (sothhich1 != "Chọn Loại Phim" && sothhich1 != null)
            {
                if (data == null || data.Rows.Count < 1)
                {
                    data = new DataTable();
                    data.Columns.Add("sothich1", "sothich2", "sothich3", "output");
                    List<DataST> st = (from d in dbl.DataSTs select d).ToList<DataST>();

                    foreach (DataST i in st)
                    {
                        data.Rows.Add(i.sothich1, i.sothich2, i.sothich3, i.output);
                    }
                }

                var codebook = new Codification(data);

                string st1 = sothhich1.ToString();
                string st2 = sothhich2.ToString();
                string st3 = sothhich3.ToString();

                try
                {
                    int[] query = codebook.Transform(new[,]
                    {
                        { "sothich1", st1},
                        { "sothich2", st2},
                        { "sothich3", st3}
                    });

                    int predicted = tree.Decide(query);
                    string answer = codebook.Revert("output", predicted);

                    int ID = (from l in dbl.LoaiPhims where l.TenLoai == answer select new { l.Id }).FirstOrDefault().Id;
                    string id = ID.ToString();

                    List<Phim> listST = (from p in dbl.Phims where p.IdLoaiPhim.Contains(id.ToString()) select p).OrderByDescending(p => p.Id).ToList<Phim>();
                    
                    ViewData["GoiY"] = listST;
                    ViewData["gt"] = id;
                 }
                catch
                {
                    ViewData["GoiY"] = (from p in dbl.Phims where p.IdLoaiPhim.Contains("phim") select p).OrderByDescending(p => p.Id).ToList<Phim>();
                    ViewData["gt"] = 100;
                }
                
            }
            else
            {
                ViewData["GoiY"] = (from p in dbl.Phims where p.IdLoaiPhim.Contains("phim") select p).OrderByDescending(p => p.Id).ToList<Phim>();
                ViewData["gt"] = 1;
            }

            List<Phim> list = dbl.Phims.AsQueryable().Where(g => g.TinhTrang == true).OrderByDescending(g => g.Id).ToList();
            ViewData["TopView"] = list;
            List<Phim> listHD = dbl.Phims.AsQueryable().Where(g => g.TinhTrang == false).OrderByDescending(g => g.Id).ToList();
            ViewData["HanhDong"] = listHD;
            ViewData["loai"] = dbl.LoaiPhims.ToList();
            Data db = new Data();
            List<Ghe> lisssst = db.Ghes.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}