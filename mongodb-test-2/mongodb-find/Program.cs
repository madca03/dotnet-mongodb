using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongodb_find
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");
            var filter = Builders<BsonDocument>.Filter.Eq("price", 29000);
            var doc = cars.Find(filter).FirstOrDefault();
            Console.WriteLine(doc.ToString());
        }
    }
}
