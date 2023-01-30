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
        
        public PartialViewResult Ekibimiz()
        {
            var ekiplistesi = db.TblEkibimiz.ToList();
            return PartialView(ekiplistesi);
        }
        
        public PartialViewResult PartialFooter()
        {
            var doluoda = db.TblOda.Where(x => x.Durum != 1).Count();
            ViewBag.d = doluoda;
            var bosoda = db.TblOda.Where(x => x.Durum == 1).Count();
            ViewBag.b = bosoda;
            return PartialView();
        }

        public PartialViewResult PartialSosyalMedya()
        {
            return PartialView();
        }
    }
}