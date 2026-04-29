using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Migrations;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(7).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()//Sayfa Ortasındaki kartlar (En son yüklenen 3 blog)
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()//En Popüler 10 Blog
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()//En Beğendiklerimiz
        {
            var deger = c.Blogs.Where(x => x.Durum == Blog.BegeniDurum.Aktif).ToList();//Enum yapisi ile oluşturdumuz durumu 1 olanı getir
            return PartialView(deger);
        }
    }
}