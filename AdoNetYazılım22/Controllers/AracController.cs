using AdoNetYazılım22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNetYazılım22.Controllers
{
    public class AracController : Controller
    {
        OtoServisDBEntities db = new OtoServisDBEntities();

        [HttpGet]
        public ActionResult AraclarıYukle()
        {
            List<araclar> arac_listesi = db.araclars.ToList();
            return View(arac_listesi);
        }


        [HttpGet] // http get sayfa yüklendiginde çalışıyor.
        public ActionResult AracEkle()
        {
            return View();
        }

        [HttpPost] // diger taraftan submit tuşuna basıldıgında post çalışır
        public ActionResult AracEkle(araclar eklenen_arac)
        {
            db.araclars.Add(eklenen_arac);
            db.SaveChanges();
            return View();
        }
    }
}