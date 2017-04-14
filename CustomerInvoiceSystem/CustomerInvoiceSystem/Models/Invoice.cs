using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerInvoiceSystem.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Order> Orders { get; set; }
        public string Description { get; set; }
        public bool Sent;
        public DateTime DateSent { get; set; }
        public bool Paid { get; set; }
        public DateTime DatePaid { get; set; }
        public int CustomerId { get; set; }
    }
}