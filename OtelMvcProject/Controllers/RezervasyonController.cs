using OtelMvcProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtelMvcProject.Controllers
{
    public class RezervasyonController : Controller
    {
        DbOtelEntities db = new DbOtelEntities();
        
        // GET: Rezervasyon
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblRezervasyon p)
        {
            p.Durum = 15;
            db.TblRezervasyon.Add(p);
            db.SaveChanges();            
            return RedirectToAction("Rezervasyonlarim","Misafir");
        }
    }
}