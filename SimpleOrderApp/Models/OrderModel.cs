using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOrderApp.Models
{
    public class OrderModel
    {
        public bool IsEditing { get; set; } = false;
        public ObjectId Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Hourly rate
        /// </summary>
        public decimal? Rate { get; set; } = 400;

        /// <summary>
        /// Order creation date
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Date of upload to the customer
        /// </summary>
        public DateTime? DateUploaded { get; set; }

        /// <summary>
        /// State of the order
        /// </summary>
        public State State { get; set; } = State.New;

        /// <summary>
        /// Collection of jobs done on the order
        /// </summary>
        public List<JobModel> Jobs { get; set; } = new();

        /// <summary>
        /// Url where the data from customer are stored
        /// </summary>
        public string DataUrl { get; set; }

        /// <summary>
        /// Url of the local project
        /// </summary>
        public string LocalProjectUrl { get; set; }

        /// <summary>
        /// Url of the uploaded result
        /// </summary>
        public string ResultUrl { get; set; }

        /// <summary>
        /// Order invoice
        /// </summary>
        public InvoiceModel Invoice { get; set; }

        /// <summary>
        /// Invoice creation date
        /// </summary>
        public DateTime? DateInvoiced { get; set; }

        /// <summary>
        /// Calculates total price to be invoiced.
        /// </summary>
        /// <returns>Total price - 0 if order has no jobs or hour rate.</returns>
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
                    total += (decimal)item.Hours * Rate.Value;
                }

                return total;
            }
        }

        /// <summary>
        /// Calculates total hours spent on the order
        /// </summary>
        /// <returns></returns>
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