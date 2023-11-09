using E_Market.Services.AuthAPI.Models;

namespace E_Market.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(AppUser appUser, IEnumerable<string>roles);
    }
}
