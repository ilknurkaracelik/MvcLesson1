using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLesson1.Models
{
    public static class Veritabani
    {
        private static List<Urun> _liste;

        static Veritabani()
        {
            _liste = new List<Urun>()
            {
                new Urun(){ UrunId=1,UrunAdi="Iphone",Aciklama="İyi",Fiyat=3000,Satistami=true,Resim="1.jpg"},
                new Urun(){ UrunId=2,UrunAdi="Iphone7",Aciklama="İyi",Fiyat=5000,Satistami=true,Resim="2.jpg"},
                new Urun(){ UrunId=3,UrunAdi="Iphone8",Aciklama="ehh",Fiyat=2000,Satistami=false,Resim="3.jpg"},
                new Urun(){ UrunId=4,UrunAdi="Iphone9",Aciklama="kötü",Fiyat=9000,Satistami=true,Resim="4.jpg"}
            };
        }

        public static List<Urun> Liste
        {
            get { return _liste; }
        }
    
        public static void ElemanEkle(Urun entity)
        {
            _liste.Add(entity);
        }
        //Urun entity =Veritabani.UrunDetay(5)
        public static Urun UrunDetay(int urunid)
        {
            Urun entity = null;
            foreach (var urun in _liste)
            {
                if(urun.UrunId==urunid)
                {
                    entity = urun;
                }
            }
            return entity;
        }
    }
}