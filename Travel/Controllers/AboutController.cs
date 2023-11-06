using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
    public class AboutController : Controller
    {
        // Veritabanı bağlantısı için bir Context nesnesi oluşturuyoruz.
        Context c = new Context();
        public ActionResult Index()
        {
            // Hakkımızda verilerini veritabanından almak için Context sınıfını kullanıyoruz.
            var degerler = c.Hakkımızdas.ToList();
            return View(degerler);    // Hakkımızda verilerini içeren bir görünümü döndürüyoruz.
        }
    }
}