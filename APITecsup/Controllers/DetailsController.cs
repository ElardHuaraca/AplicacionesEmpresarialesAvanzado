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
using APITecsup.Context;
using APITecsup.Models;
using APITecsup.Responses;

namespace APITecsup.Controllers
{
    public class DetailsController : ApiController
    {
        private ExampleContext db = new ExampleContext();

        // GET: api/Details
        public IQueryable<Detail> GetDetails()
        {
            return db.Details;
        }

        // GET: api/Details/5
        [ResponseType(typeof(Detail))]
        public IHttpActionResult GetDetail(string nroFactura)
        {
            List<DetailResponse> list;
            Invoice invoice = db.Invoices.Where(x => x.Number == nroFactura).First();
            List<Detail> details = db.Details.Where(x => x.InvoiceID == invoice.InvoiceID).ToList();
            if (details == null)
            {
                return NotFound();
            }
            list = new List<DetailResponse>();
            for (int i = 0; i < details.Count; i++)
            {
                list.Add(new DetailResponse
                {
                    Count = details[i].Count,
                    Price = details[i].Price,
                    SubTotal = details[i].SubTotal,
                    IGV = details[i].IGV,
                    Total = details[i].Total
                }); ;
            }
            return Ok(list);
        }

        // PUT: api/Details/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDetail(int id, Detail detail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != detail.DetailID)
            {
                return BadRequest();
            }

            db.Entry(detail).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetailExists(id))
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

        // POST: api/Details
        [ResponseType(typeof(Detail))]
        public IHttpActionResult PostDetail(Detail detail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Details.Add(detail);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = detail.DetailID }, detail);
        }

        // DELETE: api/Details/5
        [ResponseType(typeof(Detail))]
        public IHttpActionResult DeleteDetail(int id)
        {
            Detail detail = db.Details.Find(id);
            if (detail == null)
            {
                return NotFound();
            }

            db.Details.Remove(detail);
            db.SaveChanges();

            return Ok(detail);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DetailExists(int id)
        {
            return db.Details.Count(e => e.DetailID == id) > 0;
        }
    }
}