using AdoNetYazılım22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNetYazılım22.Controllers
{
   
    public class KullanıcıController : Controller
    {
        OtoServisDBEntities db2 = new OtoServisDBEntities();    

        [HttpGet] // Kullanıcı ekle sayfası yüklenirken get çalışıyor
        public ActionResult KullanıcıEkle()
        {
            return View();
        }

        [HttpPost] // input butonun basıldıgında burası çalışıyor
        public ActionResult KullanıcıEkle(kullanici eklenenkullanıcı) 
        {
            db2.kullanicis.Add(eklenenkullanıcı);
            db2.SaveChanges();
            return View();
        }
    }
}