using Hydrogen.Settings;

namespace Component.Mongo.Configuration
{
    public class MongoSettings : IMongoSettings
    {
        public MongoSettings(ISettingsProvider settingsProvider)
        {
            ConnectionString = settingsProvider.ConnectionString("Component.Mongo");
        }

        public string ConnectionString { get; }
    }
}