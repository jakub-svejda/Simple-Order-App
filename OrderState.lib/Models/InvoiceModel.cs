using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderState.lib.Models
{
    public class InvoiceModel
    {
        public string InvoiceNum { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateOfPayment { get; set; }
        public CustomerModel InvoicedTo { get; set; }
        public decimal TotalPrice { get; set; }
    }
}