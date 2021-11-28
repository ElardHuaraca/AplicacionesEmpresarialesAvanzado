using APITecsup.Context;
using APITecsup.Models;
using APITecsup.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APITecsup.Controllers
{
    public class InvoicesController : ApiController
    {
        private ExampleContext db = new ExampleContext();

        [HttpPost]
        public InvoiceResponse Insert(Invoice request)
        {
            request.CreatedOn = DateTime.Now;
            for (int i = 0; i < request.Details.Count; i++)
            {
                request.Details[i].IGV = request.Details[i].SubTotal * 0.18;
                request.Details[i].Total = request.Details[i].SubTotal + request.Details[i].IGV;
                request.Total = request.Total + request.Details[i].Total;
            }
            db.Invoices.Add(request);
            db.SaveChanges();
            var response = new InvoiceResponse
            {
                Number = request.Number,
                Total = request.Total,
                CustomerName = db.Customers.Find(request.CustomerID).FirstName
            };
            return response;
        }

        [HttpGet]
        public List<InvoiceResponseV2> GetByPrice(int MinPrice, int MaxPrice)
        {
            var invoices = db.Invoices.
                Where(x => x.Total > MinPrice && x.Total < MaxPrice)
                .ToList();

            var response = (from c in invoices
                            select new InvoiceResponseV2
                            {
                                Number = c.Number,
                                Total = c.Total
                            }).ToList();
            return response;
        }

    }
}
