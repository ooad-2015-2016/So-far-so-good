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
    public class PoslodavacController : ApiController
    {
        private PoslodavacDBContext db = new PoslodavacDBContext();

        // GET: api/Poslodavac
        public IQueryable<Poslodavac> GetPoslodavci()
        {
            return db.Poslodavci;
        }

        // GET: api/Poslodavac/5
        [ResponseType(typeof(Poslodavac))]
        public async Task<IHttpActionResult> GetPoslodavac(int id)
        {
            Poslodavac poslodavac = await db.Poslodavci.FindAsync(id);
            if (poslodavac == null)
            {
                return NotFound();
            }

            return Ok(poslodavac);
        }

        // PUT: api/Poslodavac/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPoslodavac(int id, Poslodavac poslodavac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != poslodavac.ID)
            {
                return BadRequest();
            }

            db.Entry(poslodavac).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PoslodavacExists(id))
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

        // POST: api/Poslodavac
        [ResponseType(typeof(Poslodavac))]
        public async Task<IHttpActionResult> PostPoslodavac(Poslodavac poslodavac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Poslodavci.Add(poslodavac);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = poslodavac.ID }, poslodavac);
        }

        // DELETE: api/Poslodavac/5
        [ResponseType(typeof(Poslodavac))]
        public async Task<IHttpActionResult> DeletePoslodavac(int id)
        {
            Poslodavac poslodavac = await db.Poslodavci.FindAsync(id);
            if (poslodavac == null)
            {
                return NotFound();
            }

            db.Poslodavci.Remove(poslodavac);
            await db.SaveChangesAsync();

            return Ok(poslodavac);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PoslodavacExists(int id)
        {
            return db.Poslodavci.Count(e => e.ID == id) > 0;
        }
    }
}