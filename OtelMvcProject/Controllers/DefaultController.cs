using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtelMvcProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult AnaSayfa()
        {
            return View();
        }

        public ActionResult Hakkımızda()
        {
            return View();
        }

        public ActionResult Hizmetler()
        {
            return View();
        }

        public ActionResult iletişim()
        {
            return View();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialSosyalMedya()
        {
            return PartialView();
        }
    }
}