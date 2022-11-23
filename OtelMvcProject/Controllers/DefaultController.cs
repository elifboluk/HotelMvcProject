using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProject.Models.Entity;
namespace OtelMvcProject.Controllers
{
    public class DefaultController : Controller
    {
       DbOtelEntities db = new DbOtelEntities();
      
        public ActionResult Hakkimizda()
        {
            var veriler = db.TblHakkimda.ToList();
            return View(veriler);
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