using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongodb_updateone
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            var db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");
            var filter = Builders<BsonDocument>.Filter.Eq("name", "Audi");
            var update = Builders<BsonDocument>.Update.Set("price", 52000);
            update = update.Set("name", "AudiMod");
            cars.UpdateOne(filter, update);
        }
    }
}
