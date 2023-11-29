using System.ComponentModel.DataAnnotations.Schema;
using Spotify.Data.Entities.Abstractions;

namespace Spotify.Data.Entities;

[Table("users")]
public class User : IdentifiedEntity
{
    public string UserName { get; set; }

    public string Email { get; set; }

    public string AvatarUrl { get; set; }
}