﻿using SimpleOrderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOrderApp
{
    public static class DummyData
    {
        private static readonly MongoDbDataAccess _da = new MongoDbDataAccess();

        public static void CreateDummyData()
        {
            var output = new List<OrderModel>();

            var customer = new CustomerModel
            {
                Name = "TestContact",
                City = "saaa",
                Street = "daaa",
                Cori = "1",
                Cpop = "2",
                DIC = "CZ000000",
                IC = "0000000",
                PSC = "00000"
            };

            _da.InsertRecord<CustomerModel>("Customers", customer);

            var customer2 = new CustomerModel
            {
                Name = "TestContact2",
                City = "saaa",
                Street = "daaa",
                Cori = "1",
                Cpop = "2",
                DIC = "CZ000000",
                IC = "0000000",
                PSC = "00000"
            };

            _da.InsertRecord<CustomerModel>("Customers", customer2);

            for (int i = 0; i < 5; i++)
            {
                output.Add(new OrderModel
                {
                    Name = "test" + i,
                    Description = "test order" + i,
                    LocalProjectUrl = @"C:\asdugfdsjk",
                    State = State.New,
                    CustomerId = customer.Id
                });
            }
            output.Add(new OrderModel
            {
                Name = "testa",
                Description = "test ordera",
                LocalProjectUrl = @"C:\asdugfdsjk",
                State = State.Paid,
                CustomerId = customer2.Id
            });

            foreach (var item in output)
            {
                _da.InsertRecord<OrderModel>("Orders", item);
            }
        }
    }
}