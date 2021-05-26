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
    public class assistirsController : ApiController
    {
        private ChrysallisEntities db = new ChrysallisEntities();

        
        


        // GET: api/assistirs
        public IQueryable<assistir> Getassistir()
        {
            return db.assistir;
        }

        // GET: api/assistirs/5
        [ResponseType(typeof(assistir))]
        public IHttpActionResult Getassistir(int id)
        {
            assistir assistir = db.assistir.Find(id);
            if (assistir == null)
            {
                return NotFound();
            }

            return Ok(assistir);
        }

        // PUT: api/assistirs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putassistir(int id, assistir assistir)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != assistir.id_soci)
            {
                return BadRequest();
            }

            db.Entry(assistir).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!assistirExists(id))
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

        // POST: api/assistirs
        [ResponseType(typeof(assistir))]
        public IHttpActionResult Postassistir(assistir assistir)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.assistir.Add(assistir);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (assistirExists(assistir.id_soci))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = assistir.id_soci }, assistir);
        }

        // DELETE: api/assistirs/5
        [ResponseType(typeof(assistir))]
        public IHttpActionResult Deleteassistir(int id)
        {
            assistir assistir = db.assistir.Find(id);
            if (assistir == null)
            {
                return NotFound();
            }

            db.assistir.Remove(assistir);
            db.SaveChanges();

            return Ok(assistir);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool assistirExists(int id)
        {
            return db.assistir.Count(e => e.id_soci == id) > 0;
        }
    }
}