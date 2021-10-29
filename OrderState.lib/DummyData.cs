using OrderState.lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderState.lib
{
    public static class DummyData
    {
        public static List<OrderModel> CreateDummyData()
        {
            var output = new List<OrderModel>();

            for (int i = 0; i < 5; i++)
            {
                output.Add(new OrderModel
                {
                    Name = "test" + i,
                    Description = "test order" + i,
                    LocalUrl = @"C:\asdugfdsjk",
                    State = State.New,
                    OrderedBy = new ContactModel
                    {
                        Name = "TestContact",
                        City = "saaa",
                        Street = "daaa",
                        Cori = "1",
                        Cpop = "2",
                        DIC = "CZ000000",
                        IC = "0000000",
                        PSC = "00000"
                    }
                });
            }
            output.Add(new OrderModel
            {
                Name = "testa",
                Description = "test ordera",
                LocalUrl = @"C:\asdugfdsjk",
                State = State.Paid,
                OrderedBy = new ContactModel
                {
                    Name = "TestContact",
                    City = "saaa",
                    Street = "daaa",
                    Cori = "1",
                    Cpop = "2",
                    DIC = "CZ000000",
                    IC = "0000000",
                    PSC = "00000"
                }
            });

            return output;
        }
    }
}