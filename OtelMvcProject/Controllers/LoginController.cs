using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OtelMvcProject.Models.Entity;

namespace OtelMvcProject.Controllers
{
    public class LoginController : Controller
    {
        DbOtelEntities db = new DbOtelEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblYeniKayit p)
        {
            var bilgiler = db.TblYeniKayit.FirstOrDefault(x=> x.Mail == p.Mail && x.Sifre == p.Sifre);
            if (bilgiler != null)
            {
                //giriş
                FormsAuthentication.SetAuthCookie(bilgiler.Mail, false);
                Session["Mail"] = bilgiler.Mail.ToString(); // Session:oturum, oturum değerimiz mail olacak.
                return RedirectToAction("Index","AnaSayfa");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }

    // FirstOrDefault : Sadece bir tane kayıt seçme durumlarında kullanılan bir entitylinq metodudur.
}