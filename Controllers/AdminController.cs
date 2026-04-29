using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context c = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var blog = c.Blogs.Find(id);
            c.Blogs.Remove(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var blog = c.Blogs.Find(id);
            return View("BlogGetir", blog);
        }

        public ActionResult BlogGuncelle(Blog p)
        {
            var blog = c.Blogs.Find(p.ID);
            blog.Baslik = p.Baslik;
            blog.Tarih = p.Tarih;
            blog.Aciklama = p.Aciklama;
            blog.BlogImage = p.BlogImage;
            blog.Durum = p.Durum;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var yorumlar = c.yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var yorum = c.yorumlars.Find(id);
            c.yorumlars.Remove(yorum);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var yorum = c.yorumlars.Find(id);
            return View("YorumGetir", yorum);
        }

        public ActionResult YorumGuncelle(Yorumlar p)
        {
            var yorum = c.yorumlars.Find(p.ID);
            yorum.KullaniciAdi = p.KullaniciAdi;
            yorum.Mail = p.Mail;
            yorum.Yorum = p.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}