using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class KullaniciIslemleri
    {

        public void KullaniciEkle(TKullanici kullanici)
        {

            TKullaniciYonetim.KullaniciListesi.Add(kullanici);
        }
         public void KullaniciSil(TKullanici kullanici)
        {

            TKullaniciYonetim.KullaniciListesi.Add(kullanici);
        }
         public void KullaniciGuncelle(TKullanici kullanici)
        {

            TKullaniciYonetim.KullaniciListesi.Add(kullanici);
        }




    }
}
