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
      
        public ActionResult Hakkimizda()
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