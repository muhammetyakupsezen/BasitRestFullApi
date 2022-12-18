using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KursAralıkOnSekizBasitRestFullApi.Controllers
{
    public class KullaniciController : ApiController
    {
        // ApiUrl = https://localhost:44335/api/
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            TResult result = new TResult();
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            result = kullaniciIslemleri.KullaniciListesi();

            var response = Request.CreateResponse<TResult>(HttpStatusCode.OK, result);

            return response;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Post(TKullanici kullanici)
        {
            TResult result = new TResult();
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();

            result = kullaniciIslemleri.KullaniciEkle(kullanici);

            var response = Request.CreateResponse<TResult>(HttpStatusCode.OK, result);

            return response;
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(string Username, TKullanici kullanici)
        {
            TResult result = new TResult();
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            result = kullaniciIslemleri.KullaniciGuncelle(Username, kullanici);

            var response = Request.CreateResponse<TResult>(HttpStatusCode.OK, result);

            return response;

        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(string Username)
        {
            TResult result = new TResult();
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            result = kullaniciIslemleri.KullaniciSil(Username);

            var response = Request.CreateResponse<TResult>(HttpStatusCode.OK, result);

            return response;
        }
    }
}