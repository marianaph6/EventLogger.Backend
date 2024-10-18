using Core.Entities;
using MongoDB.Driver;

namespace Infrastructure.Services.MongoDB
{
    public interface IContext
    {
        IMongoDatabase Database { get; }
        IMongoCollection<EventLog> EventLog { get; }
    }
}