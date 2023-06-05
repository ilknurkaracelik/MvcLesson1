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
        [HttpGet] // Formu getirir
        public ActionResult UrunEkle()
        {
            return View();
        }

        [HttpPost]
        public  ActionResult UrunEkle (string UrunAdi,string UrunAciklama,double Fiyat,string Resim,bool Satistami)
        {
            Urun entity = new Urun();
            entity.UrunAdi = UrunAdi;
            entity.Aciklama = UrunAciklama;
            entity.Fiyat = Fiyat;
            entity.Resim = Resim;
            entity.Satistami = Satistami;

            Veritabani.ElemanEkle(entity);

            return View("UrunListe", Veritabani.Liste);
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