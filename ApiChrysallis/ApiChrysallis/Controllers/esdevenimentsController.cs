using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiChrysallis;

namespace ApiChrysallis.Controllers
{
    public class esdevenimentsController : ApiController
    {
        private ChrysallisEntities db = new ChrysallisEntities();

        [HttpGet]
        [Route("api/esdeveniments/esdAsistir/{numSoci}")]
        public IHttpActionResult getEventAsistir(int numSoci)
        {

            //IHttpActionResult resultado;


            db.Configuration.LazyLoadingEnabled = false;

            List<assistir> asistir = (from a in db.assistir.Include("esdeveniments")
                                      where a.id_soci == numSoci
                                      select a).ToList();

            return Ok(asistir);

            //if (asistir.Count == 0)
            //{

            //    resultado = NotFound();

            //}
            //else {

            //    resultado = Ok(asistir);

            //}

            //return resultado;

        }

        //[HttpGet]
        //[Route("api/esdeveniments/esdByComunitat/{comunitat}")]
        //public IHttpActionResult GetEsdevenimentByComunitat(int[] comunitat)
        //{

            


        //    db.Configuration.LazyLoadingEnabled = false;

        //    List<esdeveniments> evento = (from e in db.esdeveniments where e.id_comunitat == comunitat[0]
        //                                  || e.id_comunitat == comunitat[1]
        //                                  || e.id_comunitat == comunitat[2]
        //                                  || e.id_comunitat == comunitat[3]
        //                                  || e.id_comunitat == comunitat[4]
        //                                  || e.id_comunitat == comunitat[5]
        //                                  || e.id_comunitat == comunitat[7]
        //                                  select e).ToList();

        //    if (evento.Count == 0)
        //    {

        //        return NotFound();

        //    }
        //    else {

        //        return Ok(evento);
        //    }

            
        //}


        // GET: api/esdeveniments
        public IQueryable<esdeveniments> Getesdeveniments()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.esdeveniments;
        }

        // GET: api/esdeveniments/5
        [ResponseType(typeof(esdeveniments))]
        public IHttpActionResult Getesdeveniments(int id)
        {
            esdeveniments esdeveniments = db.esdeveniments.Find(id);
            if (esdeveniments == null)
            {
                return NotFound();
            }

            return Ok(esdeveniments);
        }

        // PUT: api/esdeveniments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putesdeveniments(int id, esdeveniments esdeveniments)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != esdeveniments.id)
            {
                return BadRequest();
            }

            db.Entry(esdeveniments).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!esdevenimentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/esdeveniments
        [ResponseType(typeof(esdeveniments))]
        public IHttpActionResult Postesdeveniments(esdeveniments esdeveniments)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.esdeveniments.Add(esdeveniments);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = esdeveniments.id }, esdeveniments);
        }

        // DELETE: api/esdeveniments/5
        [ResponseType(typeof(esdeveniments))]
        public IHttpActionResult Deleteesdeveniments(int id)
        {
            esdeveniments esdeveniments = db.esdeveniments.Find(id);
            if (esdeveniments == null)
            {
                return NotFound();
            }

            db.esdeveniments.Remove(esdeveniments);
            db.SaveChanges();

            return Ok(esdeveniments);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool esdevenimentsExists(int id)
        {
            return db.esdeveniments.Count(e => e.id == id) > 0;
        }
    }
}