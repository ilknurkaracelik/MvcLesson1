using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLesson1.Models
{
    public class UrunKategoriModel
    {
        public int UrunSayisi { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}