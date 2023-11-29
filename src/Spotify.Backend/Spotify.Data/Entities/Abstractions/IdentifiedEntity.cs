namespace Spotify.Data.Entities.Abstractions;

public abstract class IdentifiedEntity : BaseEntity<string>
{
    public override string Id => Guid.NewGuid().ToString();
}