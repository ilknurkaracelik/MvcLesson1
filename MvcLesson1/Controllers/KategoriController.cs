using MvcLesson1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLesson1.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }

        public  PartialViewResult KategoriMenu()
        {

            List<Kategori> Kategoriler = new List<Kategori>()
            {
                new Kategori() { Id = 1, Ad = "Telefon" },
                new Kategori() { Id = 2, Ad = "TV" },
            };
            return PartialView("KategoriMenu", Kategoriler);
        }
    }
}