using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITecsup.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Number { get; set; }
        public double Total { get; set; }
        public List<Detail> Details { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

    }
}