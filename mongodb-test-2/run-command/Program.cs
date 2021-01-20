using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace run_command
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = dbClient.GetDatabase("testdb");
            var command = new BsonDocument {{"dbstats", 1}};
            var result = db.RunCommand<BsonDocument>(command);
            Console.WriteLine(result.ToJson());
        }
    }
}
