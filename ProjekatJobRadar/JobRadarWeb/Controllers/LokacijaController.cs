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
    public class LokacijaController : ApiController
    {
        private LokacijaDBContext db = new LokacijaDBContext();

        // GET: api/Lokacija
        public IQueryable<Lokacija> GetLokacije()
        {
            return db.Lokacije;
        }

        // GET: api/Lokacija/5
        [ResponseType(typeof(Lokacija))]
        public async Task<IHttpActionResult> GetLokacija(int id)
        {
            Lokacija lokacija = await db.Lokacije.FindAsync(id);
            if (lokacija == null)
            {
                return NotFound();
            }

            return Ok(lokacija);
        }

        // PUT: api/Lokacija/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLokacija(int id, Lokacija lokacija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lokacija.LokacijaId)
            {
                return BadRequest();
            }

            db.Entry(lokacija).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LokacijaExists(id))
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

        // POST: api/Lokacija
        [ResponseType(typeof(Lokacija))]
        public async Task<IHttpActionResult> PostLokacija(Lokacija lokacija)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Lokacije.Add(lokacija);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = lokacija.LokacijaId }, lokacija);
        }

        // DELETE: api/Lokacija/5
        [ResponseType(typeof(Lokacija))]
        public async Task<IHttpActionResult> DeleteLokacija(int id)
        {
            Lokacija lokacija = await db.Lokacije.FindAsync(id);
            if (lokacija == null)
            {
                return NotFound();
            }

            db.Lokacije.Remove(lokacija);
            await db.SaveChangesAsync();

            return Ok(lokacija);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LokacijaExists(int id)
        {
            return db.Lokacije.Count(e => e.LokacijaId == id) > 0;
        }
    }
}