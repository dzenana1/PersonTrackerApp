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
using System.Web.Http.Cors;

namespace PersonTracker.Services.Services
{
    [EnableCors("*", "*", "PUT, POST")]
    [RoutePrefix("api/Nestali")]
    public class NestaliController : ApiController
    {
        [HttpPost]
        [Route("Register")]        
        public IHttpActionResult Register(NestaliDO nestali)
        {
            try {       
            using (var ctx = new PersonTrackerDBEntities())
            {
                    Nestali n = new Nestali()
                    {
                        idNestali = nestali.idNestali,
                        ime = nestali.ime,
                        prezime = nestali.prezime,
                        godinaRodenja = nestali.godinaRodenja,
                        // fotografija=nestali.fotografija,
                        //datumNestanka=nestali.datumNestanka,
                        mjestoNestanka = nestali.mjestoNestanka,
                        idKorisnik = nestali.idKorisnik,
                        //spol=nestali.spol,
                        komentar = nestali.komentar,
                        visina = nestali.komentar,
                        tezina = nestali.tezina,
                        Korisnik =new Korisnik(){
                            idKorisnik=nestali.Korisnik.idKorisnik,
                            ime=nestali.Korisnik.ime,
                            prezime = nestali.Korisnik.prezime,
                            email = nestali.Korisnik.email,
                            brojTelefona = nestali.Korisnik.brojTelefona,
                        }
                    };
                ctx.Nestali.Add(n);
                ctx.SaveChanges();
                return Ok();
            }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}