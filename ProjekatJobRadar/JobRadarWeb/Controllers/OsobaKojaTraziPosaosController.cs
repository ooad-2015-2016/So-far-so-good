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
    public class OsobaKojaTraziPosaosController : ApiController
    {
        private OsobaKojaTraziPosaoDBContext db = new OsobaKojaTraziPosaoDBContext();

        // GET: api/OsobaKojaTraziPosaos
        public IQueryable<OsobaKojaTraziPosao> GetOsobeKojeTrazePosao()
        {
            return db.OsobeKojeTrazePosao;
        }

        // GET: api/OsobaKojaTraziPosaos/5
        [ResponseType(typeof(OsobaKojaTraziPosao))]
        public async Task<IHttpActionResult> GetOsobaKojaTraziPosao(int id)
        {
            OsobaKojaTraziPosao osobaKojaTraziPosao = await db.OsobeKojeTrazePosao.FindAsync(id);
            if (osobaKojaTraziPosao == null)
            {
                return NotFound();
            }

            return Ok(osobaKojaTraziPosao);
        }

        // PUT: api/OsobaKojaTraziPosaos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOsobaKojaTraziPosao(int id, OsobaKojaTraziPosao osobaKojaTraziPosao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != osobaKojaTraziPosao.ID)
            {
                return BadRequest();
            }

            db.Entry(osobaKojaTraziPosao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OsobaKojaTraziPosaoExists(id))
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

        // POST: api/OsobaKojaTraziPosaos
        [ResponseType(typeof(OsobaKojaTraziPosao))]
        public async Task<IHttpActionResult> PostOsobaKojaTraziPosao(OsobaKojaTraziPosao osobaKojaTraziPosao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OsobeKojeTrazePosao.Add(osobaKojaTraziPosao);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = osobaKojaTraziPosao.ID }, osobaKojaTraziPosao);
        }

        // DELETE: api/OsobaKojaTraziPosaos/5
        [ResponseType(typeof(OsobaKojaTraziPosao))]
        public async Task<IHttpActionResult> DeleteOsobaKojaTraziPosao(int id)
        {
            OsobaKojaTraziPosao osobaKojaTraziPosao = await db.OsobeKojeTrazePosao.FindAsync(id);
            if (osobaKojaTraziPosao == null)
            {
                return NotFound();
            }

            db.OsobeKojeTrazePosao.Remove(osobaKojaTraziPosao);
            await db.SaveChangesAsync();

            return Ok(osobaKojaTraziPosao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OsobaKojaTraziPosaoExists(int id)
        {
            return db.OsobeKojeTrazePosao.Count(e => e.ID == id) > 0;
        }
    }
}