using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ayakkabi_Projesi.Data;

namespace Ayakkabi_Projesi.Controllers
{
    public class HomeController : Controller
    {
        Data.ayakkabiEntities db = new Data.ayakkabiEntities();

        public ActionResult Index()
        {
            ViewBag.Ayakkabilar = db.Ayakkabis.ToList();
            ViewBag.indirimdekiler = db.Indirims.Take(4).ToList();
            ViewBag.gununfirsati = db.Ayakkabis.ToList();
            ViewBag.onerilenler = db.Ayakkabis.ToList();
            ViewBag.soneklenenler = db.Ayakkabis.OrderByDescending(x => x.AyakkabiID).Take(4).ToList();
            ViewBag.Sliderim = db.Sliders.ToList();
           
            return View();
        }
        public ActionResult Detay(int detayid)
        {
            ViewBag.Detayimiz = db.Ayakkabis.Where(x=>x.AyakkabiID==detayid).ToList();
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