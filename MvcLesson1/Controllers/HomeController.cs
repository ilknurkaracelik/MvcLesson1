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
            //string[] kurslar = { "Mvc", "c#", "asp.net" };
            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){ UrunId=1,UrunAdi="Iphone",Aciklama="İyi",Fiyat=3000,Satistami=true},
                new Urun(){ UrunId=2,UrunAdi="Iphone7",Aciklama="İyi",Fiyat=5000,Satistami=true},
                new Urun(){ UrunId=3,UrunAdi="Iphone8",Aciklama="ehh",Fiyat=2000,Satistami=false},
                new Urun(){ UrunId=4,UrunAdi="Iphone9",Aciklama="kötü",Fiyat=9000,Satistami=true}
            };






            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = urunler.Count();
            model.Urunler = urunler;

            ViewBag.UrunSayisi = urunler.Count;

            return View(model);
        }




        public ActionResult Services()
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