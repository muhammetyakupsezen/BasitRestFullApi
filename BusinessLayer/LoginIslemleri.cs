using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoginIslemleri
    {
        public TResult Login(string Username , string Password)
        {
            TResult result = new TResult();

            try
            {
                var Kisi = (from d in TKullaniciYonetim.KullaniciListesi where d.KullaniciAdi == Username && d.Sifre == Password select d).SingleOrDefault();
                if (Kisi != null )
                {
                    result.Success = true;
                    result.Message = "giriş başarılı";
                    result.StatusCode = 200;
                    
                }

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "giriş başarısız";
                result.StatusCode = -1005;
            }

            return result;
        }


    }
}
