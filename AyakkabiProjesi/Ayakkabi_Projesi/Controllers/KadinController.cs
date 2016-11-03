using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ayakkabi_Projesi.Data;

namespace Ayakkabi_Projesi.Controllers
{
    public class KadinController : Controller
    {
        Data.ayakkabiEntities db = new Data.ayakkabiEntities();
        public ActionResult Index()
        {
            return View(db.Ayakkabis.ToList());
        }
   
        public ActionResult Bot()
        {
            return View(db.Ayakkabis.ToList());
        }
        public ActionResult Cizme()
        {
            return View(db.Ayakkabis.ToList());
        }
        public ActionResult Babet()
        {
            return View(db.Ayakkabis.ToList());
        }
        public ActionResult Spor()
        {
            return View(db.Ayakkabis.ToList());
        }
        public ActionResult Terlik()
        {
            return View(db.Ayakkabis.ToList());
        }
        public ActionResult Topuklu()
        {
            return View(db.Ayakkabis.ToList());
        }
    }
}