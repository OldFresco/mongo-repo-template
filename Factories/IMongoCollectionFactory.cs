using MongoDB.Driver;

namespace Component.Mongo.Factories
{
    public interface IMongoCollectionFactory<T>
    {
        IMongoCollection<T> Get();
    }
}