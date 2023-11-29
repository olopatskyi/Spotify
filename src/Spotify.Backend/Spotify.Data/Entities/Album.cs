using System.ComponentModel.DataAnnotations.Schema;

namespace Spotify.Data.Entities;

[Table("albums")]
public class Album
{
    public string Name { get; set; }

    public ICollection<string> SongsIds { get; set; }
}