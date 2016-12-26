
using PersonTracker.DataModel;
using PersonTracker.Services.Models;
using PersonTracker.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PersonTracker.Services.Controllers
{
    [EnableCors("*", "*", "PUT, POST")]
    [RoutePrefix("api/Pretraga")]
    public class PretragaController : ApiController
    {
        [HttpGet]
        [Route("Pretrazi")]
        public IHttpActionResult Pretrazi(String parametarPretrage)
        {
            List<NestaliDO> listaNestalih = new List<NestaliDO>();
            try
            {
                using (var ctx = new PersonTrackerDBEntities())
                {
                    NestaliController nestContr = new NestaliController();
                    foreach (var item in ctx.Nestali.Where(model => model.Ime.ToLower().Contains(parametarPretrage) ||
                    model.Prezime.ToLower().Contains(parametarPretrage)))
                    {
                        NestaliDO nestali = new NestaliDO
                        {
                            idNestali = item.idNestali,
                            Ime = item.Ime,
                            Prezime = item.Prezime,
                            DatumNestanka = item.DatumNestanka,
                            Fotografija = item.Fotografija,
                            MjestoNestanka = item.MjestoNestanka,
                            GodinaRodenja = item.GodinaRodjenja,
                            listaKomentara = nestContr.DobaviKomentare(item.idNestali),

                        };
                        listaNestalih.Add(nestali);
                    }
                }
                return Ok(listaNestalih);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}