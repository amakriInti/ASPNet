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
using Demo2_MVCWebApi;

namespace Demo2_MVCWebApi.Controllers
{
    public class RencontreController : ApiController
    {
        private FootContext db = new FootContext();

        // GET: api/Rencontre
        public IQueryable<Rencontre> GetRencontres()
        {
            return db.Rencontres;
        }

        // GET: api/Rencontre/5
        [ResponseType(typeof(Rencontre))]
        public IHttpActionResult GetRencontre(long id)
        {
            Rencontre rencontre = db.Rencontres.Find(id);
            if (rencontre == null)
            {
                return NotFound();
            }

            return Ok(rencontre);
        }

        // PUT: api/Rencontre/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRencontre(long id, Rencontre rencontre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rencontre.Id)
            {
                return BadRequest();
            }

            db.Entry(rencontre).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RencontreExists(id))
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

        // POST: api/Rencontre
        [ResponseType(typeof(Rencontre))]
        public IHttpActionResult PostRencontre(Rencontre rencontre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rencontres.Add(rencontre);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rencontre.Id }, rencontre);
        }

        // DELETE: api/Rencontre/5
        [ResponseType(typeof(Rencontre))]
        public IHttpActionResult DeleteRencontre(long id)
        {
            Rencontre rencontre = db.Rencontres.Find(id);
            if (rencontre == null)
            {
                return NotFound();
            }

            db.Rencontres.Remove(rencontre);
            db.SaveChanges();

            return Ok(rencontre);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RencontreExists(long id)
        {
            return db.Rencontres.Count(e => e.Id == id) > 0;
        }
    }
}