using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderState.lib.Models
{
    public class OrderModel
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ContactModel OrderedBy { get; set; }
        public RateModel Rate { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUplaoded { get; set; }
        public OrderState State { get; set; } = OrderState.New;
        public List<JobModel> Jobs { get; set; }
        public string LocalUrl { get; set; }
        public string ExternalUrl { get; set; }
        public InvoiceModel Invoice { get; set; }
        public DateTime? DateInvoiced { get; set; }
    }
}