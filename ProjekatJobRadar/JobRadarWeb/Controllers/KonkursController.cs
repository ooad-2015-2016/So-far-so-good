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
    public class KonkursController : ApiController
    {
        private KonkursDBContext db = new KonkursDBContext();

        // GET: api/Konkurs
        public IQueryable<Konkurs> GetKonkursi()
        {
            return db.Konkursi;
        }

        // GET: api/Konkurs/5
        [ResponseType(typeof(Konkurs))]
        public async Task<IHttpActionResult> GetKonkurs(int id)
        {
            Konkurs konkurs = await db.Konkursi.FindAsync(id);
            if (konkurs == null)
            {
                return NotFound();
            }

            return Ok(konkurs);
        }

        // PUT: api/Konkurs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutKonkurs(int id, Konkurs konkurs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != konkurs.ID)
            {
                return BadRequest();
            }

            db.Entry(konkurs).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KonkursExists(id))
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

        // POST: api/Konkurs
        [ResponseType(typeof(Konkurs))]
        public async Task<IHttpActionResult> PostKonkurs(Konkurs konkurs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Konkursi.Add(konkurs);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = konkurs.ID }, konkurs);
        }

        // DELETE: api/Konkurs/5
        [ResponseType(typeof(Konkurs))]
        public async Task<IHttpActionResult> DeleteKonkurs(int id)
        {
            Konkurs konkurs = await db.Konkursi.FindAsync(id);
            if (konkurs == null)
            {
                return NotFound();
            }

            db.Konkursi.Remove(konkurs);
            await db.SaveChangesAsync();

            return Ok(konkurs);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KonkursExists(int id)
        {
            return db.Konkursi.Count(e => e.ID == id) > 0;
        }
    }
}