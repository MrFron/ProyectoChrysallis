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
    public class SocisController : ApiController
    {
        private ChrysallisEntities db = new ChrysallisEntities();

        [HttpGet]
        [Route("api/Socis/getSoci/{numTel}")]
        public IHttpActionResult getSociLogin(string numTel)
        {

            IHttpActionResult resultado;


            db.Configuration.LazyLoadingEnabled = false;

            Soci soci = (Soci) (from s in db.Soci where s.telefon.Equals(numTel) select s).FirstOrDefault();

            if (soci == null)
            {

                resultado = NotFound();

            }
            else
            {

                resultado = Ok(soci);
            }

            return resultado;

        }

        // GET: api/Socis
        public IQueryable<Soci> GetSoci()
        {
            return db.Soci;
        }

        // GET: api/Socis/5
        [ResponseType(typeof(Soci))]
        public IHttpActionResult GetSoci(int id)
        {
            Soci soci = db.Soci.Find(id);
            if (soci == null)
            {
                return NotFound();
            }

            return Ok(soci);
        }

        // PUT: api/Socis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSoci(int id, Soci soci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != soci.id)
            {
                return BadRequest();
            }

            db.Entry(soci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SociExists(id))
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

        // POST: api/Socis
        [ResponseType(typeof(Soci))]
        public IHttpActionResult PostSoci(Soci soci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Soci.Add(soci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = soci.id }, soci);
        }

        // DELETE: api/Socis/5
        [ResponseType(typeof(Soci))]
        public IHttpActionResult DeleteSoci(int id)
        {
            Soci soci = db.Soci.Find(id);
            if (soci == null)
            {
                return NotFound();
            }

            db.Soci.Remove(soci);
            db.SaveChanges();

            return Ok(soci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SociExists(int id)
        {
            return db.Soci.Count(e => e.id == id) > 0;
        }
    }
}