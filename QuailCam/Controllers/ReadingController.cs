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
using System.Web.Mvc;
using QuailCam.DAL;
using QuailCam.Models;

namespace QuailCam.Controllers
{
    public class ReadingController : ApiController
    {
        private QuailCamDbContext db = new QuailCamDbContext();

        // GET api/reading
        public IEnumerable<Reading> GetAllReadings()
        {
            return db.Readings;
        }

        // GET api/reading/5
        [ResponseType(typeof(Reading))]
        public IHttpActionResult GetReading(int id)
        {
            Reading reading = db.Readings.Find(id);
            if (reading == null)
            {
                return NotFound();
            }

            return Ok(reading);
        }

        // POST api/Reading
        [ResponseType(typeof(Reading))]
        public IHttpActionResult PostReading([Bind(Include = "RawReading")] Reading reading)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: is there some way to do this during construction? how does the entity framework actually construct these objects?
            reading.ConvertRawReading(); 
            db.Readings.Add(reading);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = reading.Id }, reading);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReadingExists(int id)
        {
            return db.Readings.Count(e => e.Id == id) > 0;
        }
    }
}