﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace SimpleOrderApp.Models
{
    public class CustomerModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Cpop { get; set; }
        public string Cori { get; set; }
        public string PSC { get; set; }
        public string IC { get; set; }
        public string DIC { get; set; }
    }
}