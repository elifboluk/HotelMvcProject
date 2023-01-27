using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OtelMvcProject.Models.Entity;

namespace OtelMvcProject.Controllers
{
    [Authorize]
    public class MisafirController : Controller
    {
        DbOtelEntities db = new DbOtelEntities();

        // GET: Misafir
        public ActionResult Index()
        {
            var misafirmail = (string)Session["Mail"];
            var misafirbilgi = db.TblYeniKayit.Where(x => x.Mail == misafirmail).FirstOrDefault(); // Sadece sisteme giriş yapan kullanıcının verilerini getir.
            return View(misafirbilgi);
        }

        public ActionResult Rezervasyonlarim()
        {
            var misafirmail = (string)Session["Mail"];
            //ViewBag.a = misafirmail;
            var misafirid = db.TblYeniKayit.Where(x => x.Mail == misafirmail).Select(y => y.ID).FirstOrDefault();
            //ViewBag.a = misafirid;
            var degerler = db.TblRezervasyon.Where(x => x.Misafir == misafirid).ToList();
            return View(degerler);
        }

        public ActionResult MisafirBilgiGuncelle(TblYeniKayit p)
        {
            var misafir = db.TblYeniKayit.Find(p.ID);
            misafir.AdSoyad = p.AdSoyad;
            misafir.Sifre = p.Sifre;
            misafir.Telefon = p.Telefon;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "AnaSayfa"); 
        }

        public ActionResult GelenMesajlar() 
        {
            var misafirmail = (string)Session["Mail"];
            var mesajlar = db.TblMesaj2.Where(x => x.Alici == misafirmail).ToList();
            return View(mesajlar);
        }
    }
}

// FirstOrDefault: Sadece bir tane kayıt seçme durumlarında kullanılan bir entitylinq metodudur.