using Component.Mongo.Configuration;
using Component.Mongo.Conventions;
using MongoDB.Driver;

namespace Component.Mongo.Factories
{
    public class MongoCollectionFactory<T> : IMongoCollectionFactory<T>
    {
        private readonly IMongoDatabase _database;

        public MongoCollectionFactory(IMongoSettings mongoSettings)
        {
            var url = MongoUrl.Create(mongoSettings.ConnectionString);

            var client = new MongoClient(url);

            _database = client.GetDatabase(url.DatabaseName);
        }

        public IMongoCollection<T> Get()
        {
            return _database.GetCollection<T>(CollectionNamingConvention.GetName(typeof(T).Name));
        }
    }
}