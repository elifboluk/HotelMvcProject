using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProject.Models.Entity;

namespace OtelMvcProject.Controllers
{
    public class MisafirController : Controller
    {
        DbOtelEntities db = new DbOtelEntities();

        // GET: Misafir
        public ActionResult Index()
        {
            var misafirmail = (string)Session["Mail"];
            var misafirbilgi = db.TblYeniKayit.Where(x => x.Mail == misafirmail).ToList();
            return View(misafirbilgi);
        }

        public ActionResult Rezervasyonlarim()
        {
            var misafirmail = (string)Session["Mail"];
            ViewBag.a = misafirmail;
            var degerler = db.TblRezervasyon.Where(x => x.Misafir == 2).ToList();
            return View(degerler);
        }
    }
}