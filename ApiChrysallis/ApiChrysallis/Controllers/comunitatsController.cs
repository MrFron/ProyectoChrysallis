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
    public class comunitatsController : ApiController
    {
        private ChrysallisEntities db = new ChrysallisEntities();


        [HttpPost]
        [Route("api/comunitats/esdeveniments/")]
        public IHttpActionResult GetComunitatsEsdeveniments(List<int> idComunitats) {

            IHttpActionResult resultado;

            db.Configuration.LazyLoadingEnabled = false;

            List<comunitats> comunitats =
                (from c in db.comunitats.Include("esdeveniments")
                 where idComunitats.Contains(c.id)
                 select c).ToList();

            if (comunitats == null)
            {


                return NotFound();

            }
            else {

                return Ok(comunitats);

            }



        }

        // GET: api/comunitats
        public IQueryable<comunitats> Getcomunitats()
        {
            return db.comunitats;
        }

        // GET: api/comunitats/5
        [ResponseType(typeof(comunitats))]
        public IHttpActionResult Getcomunitats(int id)
        {
            comunitats comunitats = db.comunitats.Find(id);
            if (comunitats == null)
            {
                return NotFound();
            }

            return Ok(comunitats);
        }

        // PUT: api/comunitats/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putcomunitats(int id, comunitats comunitats)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comunitats.id)
            {
                return BadRequest();
            }

            db.Entry(comunitats).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!comunitatsExists(id))
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

        // POST: api/comunitats
        [ResponseType(typeof(comunitats))]
        public IHttpActionResult Postcomunitats(comunitats comunitats)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.comunitats.Add(comunitats);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = comunitats.id }, comunitats);
        }

        // DELETE: api/comunitats/5
        [ResponseType(typeof(comunitats))]
        public IHttpActionResult Deletecomunitats(int id)
        {
            comunitats comunitats = db.comunitats.Find(id);
            if (comunitats == null)
            {
                return NotFound();
            }

            db.comunitats.Remove(comunitats);
            db.SaveChanges();

            return Ok(comunitats);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool comunitatsExists(int id)
        {
            return db.comunitats.Count(e => e.id == id) > 0;
        }
    }
}