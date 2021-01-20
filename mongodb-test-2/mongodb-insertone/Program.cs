using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongodb_insertone
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            var db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");
            var doc = new BsonDocument
            {
                {"name", "BMW"},
                {"price", 34621}
            };
            cars.InsertOne(doc);
        }
    }
}
