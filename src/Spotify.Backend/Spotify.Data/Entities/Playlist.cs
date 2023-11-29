using System.ComponentModel.DataAnnotations.Schema;
using Spotify.Data.Entities.Abstractions;

namespace Spotify.Data.Entities;

[Table("playlists")]
public class Playlist : IdentifiedEntity
{
    public string Name { get; set; }

    public DateTime ReleaseDate{ get; set; }
    
    public ICollection<string> SongsIds { get; set; }
}