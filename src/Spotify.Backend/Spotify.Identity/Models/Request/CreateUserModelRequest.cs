namespace Spotify.Identity.Models.Request;

public class CreateUserModelRequest
{
    public string Email { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }
}