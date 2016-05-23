using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using JobRadarWeb.Models;

namespace JobRadarWeb.Controllers
{
    public class OglasavanjeController : ApiController
    {
        private OglasavanjeDBContext db = new OglasavanjeDBContext();

        // GET: api/Oglasavanje
        public IQueryable<Oglasavanje> GetOglasavanja()
        {
            return db.Oglasavanja;
        }

        // GET: api/Oglasavanje/5
        [ResponseType(typeof(Oglasavanje))]
        public async Task<IHttpActionResult> GetOglasavanje(int id)
        {
            Oglasavanje oglasavanje = await db.Oglasavanja.FindAsync(id);
            if (oglasavanje == null)
            {
                return NotFound();
            }

            return Ok(oglasavanje);
        }

        // PUT: api/Oglasavanje/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOglasavanje(int id, Oglasavanje oglasavanje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oglasavanje.ID)
            {
                return BadRequest();
            }

            db.Entry(oglasavanje).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OglasavanjeExists(id))
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

        // POST: api/Oglasavanje
        [ResponseType(typeof(Oglasavanje))]
        public async Task<IHttpActionResult> PostOglasavanje(Oglasavanje oglasavanje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Oglasavanja.Add(oglasavanje);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = oglasavanje.ID }, oglasavanje);
        }

        // DELETE: api/Oglasavanje/5
        [ResponseType(typeof(Oglasavanje))]
        public async Task<IHttpActionResult> DeleteOglasavanje(int id)
        {
            Oglasavanje oglasavanje = await db.Oglasavanja.FindAsync(id);
            if (oglasavanje == null)
            {
                return NotFound();
            }

            db.Oglasavanja.Remove(oglasavanje);
            await db.SaveChangesAsync();

            return Ok(oglasavanje);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OglasavanjeExists(int id)
        {
            return db.Oglasavanja.Count(e => e.ID == id) > 0;
        }
    }
}