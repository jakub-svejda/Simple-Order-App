using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOrderApp.Models
{
    public class InvoiceModel
    {
        public int InvoiceNum { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateOfPayment { get; set; } = DateTime.Now.AddDays(14);
        public CustomerModel InvoicedTo { get; set; }
        public decimal TotalPrice { get; set; }
    }
}