using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongodb_projections
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            var db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");
            var docs = cars.Find(new BsonDocument()).Project("{_id: 0, price: 1}").ToList();

            docs.ForEach(doc => { Console.WriteLine(doc); });
        }
    }
}
