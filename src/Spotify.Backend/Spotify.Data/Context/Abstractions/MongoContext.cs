using System.Reflection;
using MongoDB.Driver;
using Spotify.Data.Configurations;

namespace Spotify.Data.Abstractions;

public abstract class MongoContext : IMongoContext
{
    public IMongoDatabase Database { get; }

    protected MongoContext(MongoDbContextOptions options)
    {
        var client = new MongoClient(options.ConnectionString);
        Database = client.GetDatabase(options.Database);
        InitializeCollections();
    }

    private void InitializeCollections()
    {
        var getCollectionMethod = typeof(IMongoDatabase).GetMethod("GetCollection");
        foreach (var propertyInfo in GetType().GetProperties()
                     .Where(p => p.PropertyType.IsGenericType &&
                                 p.PropertyType.GetGenericTypeDefinition() == typeof(IMongoCollection<>)))
        {
            if (getCollectionMethod == null)
            {
                throw new NullReferenceException("GetCollection method not found");
            }

            if (!propertyInfo.CanWrite) continue;
            var genericArgument = propertyInfo.PropertyType.GetGenericArguments()[0];
            var collectionName = genericArgument.Name.ToLower() + "s";
            var genericMethod = getCollectionMethod.MakeGenericMethod(genericArgument);
            var collection = genericMethod.Invoke(Database, new object[] { collectionName, null });
            propertyInfo.SetValue(this, collection);
            Console.WriteLine($"{propertyInfo.Name} => {collectionName}");
        }
    }

    public virtual Task MigrateAsync()
    {
        Console.WriteLine("Applying migration...");
        
        Console.WriteLine("Migration applied successfully");
        return Task.CompletedTask;
    }
}