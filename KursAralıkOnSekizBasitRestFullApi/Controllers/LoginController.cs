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
    public class LoginController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Post(string Username,string Password)
        {
            TResult result = new TResult();
            LoginIslemleri loginIslemleri = new LoginIslemleri();
           result = loginIslemleri.Login(Username, Password);

          var response =  Request.CreateResponse<TResult>(HttpStatusCode.OK, result);

            return response;

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}