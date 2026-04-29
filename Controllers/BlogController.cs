using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
using PagedList;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        BlogYorum by = new BlogYorum();

        Context c = new Context();

        public ActionResult Index(int sayfa = 1)
        {
            //var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList().ToPagedList(sayfa, 2);
            by.SonBloglar = c.Blogs.OrderByDescending(x => x.ID).Take(4).ToList();
            by.SonYorumlar = c.yorumlars.OrderByDescending(x => x.ID).Take(4).ToList();
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.BlogDetay = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.yorumlars.Where(x => x.Blogid == id).ToList();
            by.SonBloglar = c.Blogs.OrderByDescending(x => x.ID).Take(4).ToList();
            by.SonYorumlar = c.yorumlars.OrderByDescending(x => x.ID).Take(4).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.ID = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yorumlar)
        {
            c.yorumlars.Add(yorumlar);
            c.SaveChanges();
            return PartialView();
        }
    }
}