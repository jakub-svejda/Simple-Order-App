using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderState.lib
{
    public class MongoDbDataAccess
    {
        private IMongoDatabase db;

        private const string table = "Orders";

        public MongoDbDataAccess()
        {
            var client = new MongoClient();
            db = client.GetDatabase("OrderState");
        }

        public List<T> LoadRecords<T>()
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(_ => true).ToList();
        }

        public void InsertRecord<T>(T record)
        {
            var collection = db.GetCollection<T>(table);

            collection.InsertOne(record);
        }
    }
}