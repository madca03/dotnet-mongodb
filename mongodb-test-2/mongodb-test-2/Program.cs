using System;
using MongoDB.Driver;

namespace mongodb_test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases are:");

            foreach (var item in dbList)
                Console.WriteLine(item);
        }
    }
}
