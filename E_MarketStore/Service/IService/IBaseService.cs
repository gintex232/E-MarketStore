using E_MarketStore.Models;

namespace E_MarketStore.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
