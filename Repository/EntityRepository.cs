using System.Threading;
using System.Threading.Tasks;
using Component.Domain;
using Component.Domain.Repository;
using Component.Mongo.Factories;
using MongoDB.Driver;

namespace Component.Mongo.Repository
{
    public class ThingRepository : IThingRepository
    {
        private readonly IMongoCollection<Thing> _thingCollection;

        public ThingRepository(IMongoCollectionFactory<Thing> mongoCollectionFactory)
        {
            _thingollection = mongoCollectionFactory.Get();
        }

        public async Task SaveAsync(Thing thing, CancellationToken token)
        {
            await _applicationCollection.InsertOneAsync(application, null, token);
        }

        public async Task SaveAsync(Thing thing)
        {
            await SaveAsync(application, CancellationToken.None);
        }
    }
}