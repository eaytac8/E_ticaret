using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ayakkabi_Projesi.Controllers
{
    public class KurumsalController : Controller
    {
        // GET: Kurumsal
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Projelerimiz()
        {
            return View();
        }
    }
}