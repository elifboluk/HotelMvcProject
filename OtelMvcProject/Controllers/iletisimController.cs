﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProject.Models.Entity;

namespace OtelMvcProject.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        DbOtelEntities db = new DbOtelEntities();
        public ActionResult Index()
        {
            var bilgiler = db.Tbliletisim.ToList();
            return View(bilgiler);
        }
    }
}