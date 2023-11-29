using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Spotify.Data.Entities.Abstractions;

public abstract class BaseEntity<TIdentifier>
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public virtual TIdentifier Id { get; set; }
}