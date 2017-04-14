using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerInvoiceSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Specs { get; set; }
        public bool Completed { get; set; }
        public bool Invoiced { get; set; }
        public enum Status
        {
            InProgress,
            Invoiced,
            Paid,
            Cancelled,
            Refunded
        }
        public Status OrderStatus { get; set; }
        public int CustomerId { get; set; }
    }
}