using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;






using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web.Http;

using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using PersonTracker.Services.Models;
//using EventoAplikacija.Service.Providers;
//using EventoAplikacija.Service.Results;

using PersonTracker.DataModel;



namespace PersonTracker.Services.Services
{
    [RoutePrefix("api/Nestali")]
    public class NestaliController : ApiController
    {
        [HttpPost]
        [Route("Register")]
        public IHttpActionResult Register(NestaliDO nestali)
        {
            using (var ctx = new PersonTrackerDBEntities())
            {
                Nestali n = new Nestali()
                {
                    idKorisnik=nestali.idKorisnik,
                    ime = nestali.ime,
                    prezime = nestali.prezime,
                };
                ctx.Nestali.Add(n);
                ctx.SaveChanges();
                return Ok();
            }
        }

    }
}