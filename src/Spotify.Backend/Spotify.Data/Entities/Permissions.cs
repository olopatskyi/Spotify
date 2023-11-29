using System.ComponentModel.DataAnnotations.Schema;
using Spotify.Data.Entities.Abstractions;

namespace Spotify.Data.Entities;

[Table("user_permissions")]
public class UserPermissions : IdentifiedEntity
{
    public string UserId { get; set; }
    
    public IDictionary<string, string> Permissions { get; set; }
}