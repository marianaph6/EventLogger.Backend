using Application.Common.Utilities;
using Core.Entities;
using MongoDB.Driver;

namespace Infrastructure.Services.MongoDB
{
    public class Context : IContext
    {
        private static volatile Context _instance;
        private static readonly object SyncLock = new();
        private readonly IMongoDatabase _database;
        private readonly AppSettings _appSettings;

        public Context(string connectionString, string databaseName, AppSettings appSettings)
        {
            MongoClient mongoClient = new(connectionString);

            _database = mongoClient.GetDatabase(databaseName);
            _appSettings = appSettings;
        }

        public static Context GetMongoDatabase(string connectionString, string databaseName, AppSettings appSettings)
        {
            if (_instance is null)
                lock (SyncLock)
                {
                    _instance ??= new Context(connectionString, databaseName, appSettings);
                }

            return _instance;
        }

        public IMongoDatabase Database => _database;

        public IMongoCollection<EventLog> EventLog => _database.GetCollection<EventLog>(_appSettings.CollectionName);
    }
}