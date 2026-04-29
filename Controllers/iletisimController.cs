using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim

        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MesajEkle(iletisim par)
        {
            c.iletisims.Add(par);
            c.SaveChanges();
            return View("Index");
        }
    }
}