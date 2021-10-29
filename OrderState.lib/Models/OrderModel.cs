using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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

        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerId { get; set; }

        public RateModel Rate { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUploaded { get; set; }
        public State State { get; set; } = State.New;
        public List<JobModel> Jobs { get; set; } = new();
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
                    total += (decimal)item.Hours * Rate.Rate;
                }

                return total;
            }
        }

        public double CalculateTotalHours()
        {
            if (Jobs is null)
            {
                return 0;
            }
            else
            {
                double total = 0;
                foreach (var item in Jobs)
                {
                    total += item.Hours;
                }
                return total;
            }
        }
    }
}