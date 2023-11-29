using System.Threading.Tasks;
using FluentValidation.Results;
using Spotify.Framework.Contracts;
using Spotify.Framework.Http.Response;
using Spotify.Identity.Models.Request;

namespace Spotify.Identity.Managers.Abstractions;

public interface IUserManager
{
    Task<ServiceResponse<CreateResourceModelResponse, ValidationResult>> CreateAsync(CreateUserModelRequest request);
    
    
}