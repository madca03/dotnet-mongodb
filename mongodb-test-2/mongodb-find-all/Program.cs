using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongodb_find_all
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = dbClient.GetDatabase("testdb");

            var cars = db.GetCollection<BsonDocument>("cars");
            var documents = cars.Find(new BsonDocument()).ToList();

            foreach (var doc in documents)
                Console.WriteLine(doc.ToString());
        }
    }
}
