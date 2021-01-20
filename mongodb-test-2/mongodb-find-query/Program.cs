using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongodb_find_query
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            var db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Gt("price", 30000) & builder.Lt("price", 55000);
            var docs = cars.Find(filter).ToList();

            docs.ForEach(doc => { Console.WriteLine(doc); });
        }
    }
}
