using E_MarketStore.Services.EmailAPI.Message;
using E_MarketStore.Services.EmailAPI.Models.Dto;

namespace E_MarketStore.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
