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
        public ActionResult Index(TblOnRezervasyon p)
        {
            var misafirmail = (string)Session["Mail"];
            // var misafirid = db.TblYeniKayit.Where(x => x.Mail == misafirmail).Select(x => x.ID).FirstOrDefault(); // Sadece sisteme giriş yapan kullanıcının verilerini getir.

            // p.Durum = 3005;
            // p.Misafir = misafirid;
            p.Mail = misafirmail;
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblOnRezervasyon.Add(p);
            db.SaveChanges();            
            return RedirectToAction("Rezervasyonlarim","Misafir");
        }
    }
}