using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongodb_delete
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            var db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");
            var filter = Builders<BsonDocument>.Filter.Eq("name", "BMW");
            cars.DeleteOne(filter);
        }
    }
}
