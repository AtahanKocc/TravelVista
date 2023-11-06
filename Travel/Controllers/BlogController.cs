using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using Travel.Models.Sınıflar;

namespace Travel.Controllers
{
    public class BlogController : Controller
    {
        // Veritabanı bağlantısı için bir Context nesnesi oluşturuyoruz.
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        // Index() adlı metot, BlogController sınıfının bir aksiyonudur ve varsayılan HTTP GET isteğiyle çağrılır.
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();  // Tüm blogları veritabanından almak için Context sınıfını kullanıyoruz.
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList(); // en son olan 2 blogu al
            return View(by);
        }
        public ActionResult BlogDetay(int id) {
           // var blogbul = c.Blogs.Where(x => x.ID==id).ToList(); // Belirli bir blogun kimliğine göre veritabanından blogu seçmek için LINQ sorgusu kullanıyoruz.
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList(); // dışardan gonderdigimiz id gonder
            by.Deger2 = c.yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
    }
}