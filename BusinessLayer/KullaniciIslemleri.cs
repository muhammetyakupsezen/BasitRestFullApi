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
        public static List<TKullanici> KullaniciListesi2 = new List<TKullanici>();


        public TResult KullaniciEkle(TKullanici kullanici)
        {
            TResult result = new TResult();

            try
            {
                KullaniciListesi2.Add(kullanici);
                result.Message = "Kullanıcı basarıyla Kaydedildi";
                result.StatusCode = 200;
                result.Success = true;

                
            }
            catch (Exception ex)
            {

                result.Message = "Hata meydana geldi";
                result.StatusCode = -1001;
               
            }
            return result;

        }
         public TResult KullaniciSil(string Username)
        {
            TResult result = new TResult();

            try
            {
                var Kisi = (from d in KullaniciListesi2 where d.KullaniciAdi == Username select d).FirstOrDefault();

                if (Kisi != null)
                {
                    TKullaniciYonetim.KullaniciListesi.Remove(Kisi);

                    result.Success = true;
                    result.Message = "Kullanıcı başarıyla silindi";
                    result.StatusCode = 200;
                }
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "hata meydana geldi";
                result.StatusCode = -1002;

            }
            return result;
        }


        public TResult KullaniciListesi()
        {
            TResult result = new TResult();
            try
            {
                var Liste = (from d in KullaniciListesi2 select d).ToList();

                if (Liste != null)
                {
                    result.Success = true;
                    result.Message = "Listeleme başarılı";
                    result.StatusCode = 200;
                    result.Data.Add(Liste);
                }

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Listeleme başarısız";
                result.StatusCode = -1004;
            }
            return result;

        }  


         public TResult KullaniciGuncelle(string Username,TKullanici kullanici)
        {
            TResult result = new TResult();

            //var User = (from d in TKullaniciYonetim.KullaniciListesi where d.KullaniciAdi == Username select d).FirstOrDefault();


            //if (User != null)
            //{
            //    User.KullaniciAdi = kullanici.KullaniciAdi;
            //    User.Soyad = kullanici.Soyad;
            //    User.Sifre = kullanici.Sifre;
            //    User.Ad = kullanici.Ad;
            //}


            try
            {
                var index = KullaniciListesi2.FindIndex(t => t.KullaniciAdi == Username);

                if (index > -1)
                {
                    KullaniciListesi2[index].KullaniciAdi = kullanici.KullaniciAdi;
                    KullaniciListesi2[index].Soyad = kullanici.Soyad;
                    KullaniciListesi2[index].Ad = kullanici.Ad;
                    KullaniciListesi2[index].Sifre = kullanici.Sifre;


                    result.Success = true;
                    result.Message = "Kullanıcı bilgileri başarıyla güncellendi ";
                    result.StatusCode = 200;

                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Kullanıcı bilgileri güncellenemedi ";
                result.StatusCode = -1003;

            }
            return result;
        }


       
    }
}
