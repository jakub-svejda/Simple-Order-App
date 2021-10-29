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
        public bool IsEditing { get; set; } = false;
        public ObjectId Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public ContactModel OrderedBy { get; set; }
        public RateModel Rate { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUplaoded { get; set; }
        public State State { get; set; } = State.New;
        public List<JobModel> Jobs { get; set; }
        public string LocalUrl { get; set; }
        public string ExternalUrl { get; set; }
        public InvoiceModel Invoice { get; set; }
        public DateTime? DateInvoiced { get; set; }

        /// <summary>
        /// Calculates total price to be invoiced.
        /// </summary>
        /// <returns>Total price, 0 if order has no jobs or hour rate.</returns>
        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            if (Jobs is null || Rate is null)
            {
                return 0;
            }
            else
            {
                foreach (var item in Jobs)
                {
                    total += item.Hours * Rate.Rate;
                }

                return total;
            }
        }
    }
}