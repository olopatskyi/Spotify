using MongoDB.Driver;

namespace Spotify.Data.Abstractions;

public interface IMongoContext
{
    IMongoDatabase Database { get; }

    Task MigrateAsync();
}