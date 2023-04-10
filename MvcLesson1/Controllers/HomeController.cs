using MvcLesson1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLesson1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {


            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = Veritabani.Liste.Where(i=>i.Satistami==true).Count();
            model.Urunler = Veritabani.Liste.Where(i => i.Satistami == true).ToList();

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var urun= Veritabani.Liste.Where(i => i.UrunId == id).FirstOrDefault();
            return View(urun);
        }

        public ActionResult Services()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Faq()
        {
            return View();
        }
    }
}