using GameCityApi.Models;
using System.Threading.Tasks;

namespace GameCityApi.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User> Authenticate(Google.Apis.Auth.GoogleJsonWebSignature.Payload payload);
    }
}
