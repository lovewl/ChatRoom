using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoom
{
    public class MongoDBHelper
    {
        private MongoClient priClient;
        private IMongoDatabase priDatabase;
        public MongoDBHelper() { if (priClient == null) priClient = new MongoClient("mongodb://localhost:27017"); }
        public IMongoDatabase GetDatabase(string dbName) => priClient.GetDatabase(dbName);
        public IMongoCollection<BsonDocument> GetCollection(string dbName, string cName) => GetDatabase(dbName).GetCollection<BsonDocument>(cName);
    }
}
