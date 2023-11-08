using E_MarketStore.Web.Models;

namespace E_MarketStore.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequest);
        Task<ResponseDto?> RegisterAsync(RegisterRequestDto registerRequestDto);
        Task<ResponseDto?> AssignRoleAsync(RegisterRequestDto registerRequestDto);
    }
}
