using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ayakkabi_Projesi.Controllers
{
    public class MusteriHizmetleriController : Controller
    {
        // GET: MusteriHizmetleri
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult Sorulan_Sorular()
        {
            return View();
        }
        public ActionResult İade()
        {
            return View();
        }
        public ActionResult Gizlilik()
        {
            return View();
        }

    }
}