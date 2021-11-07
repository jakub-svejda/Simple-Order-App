using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOrderApp
{
    public class MongoDbDataAccess
    {
        private IMongoDatabase db;

        //private const string table = "Orders";

        public MongoDbDataAccess()
        {
            var client = new MongoClient();
            db = client.GetDatabase("SimpleOrderApp");
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(_ => true).ToList();
        }

        public T LoadRecordById<T>(string table, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);

            //https://youtu.be/69WBy4MHYUw
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find<T>(filter).FirstOrDefault();
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);

            collection.InsertOne(record);
        }

        public void UpdateRecord<T>(string table, T record, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);

            //https://youtu.be/69WBy4MHYUw
            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                record,
                new ReplaceOptions { IsUpsert = true }
            );
        }
    }
}