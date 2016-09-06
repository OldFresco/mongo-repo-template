using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;

namespace Component.Mongo.Conventions
{
    public static class MongoConfiguration
    {
        public static void Configure()
        {
            var conventionPack = new ConventionPack
            {
                new CamelCaseElementNameConvention(),
                new IgnoreIfNullConvention(true),
                new IgnoreExtraElementsConvention(true),
                new EnumRepresentationConvention(BsonType.String)
            };

            ConventionRegistry.Register("MongoConventions", conventionPack, t => t.Namespace != null && (t.Namespace.StartsWith("Component.Domain")));
        }
    }
}