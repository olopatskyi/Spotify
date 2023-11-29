using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Spotify.Data.Entities.Abstractions;
using Spotify.Data.Enums;

namespace Spotify.Data.Entities;

[Table("songs")]
public class Song : IdentifiedEntity
{
    public string Title { get; set; }
    
    public string ArtistId { get; set; }
    
    public string AlbumId { get; set; }
    
    public long StreamingCount { get; set; }

    public string ResourceUrl { get; set; }
    
    public DateTime ReleaseDate { get; set; }

    [BsonRepresentation(BsonType.String)]
    public Genre Genre { get; set; }
}