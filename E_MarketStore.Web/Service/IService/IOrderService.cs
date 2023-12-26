using E_MarketStore.Web.Models;

namespace E_MarketStore.Web.Service.IService
{
    public interface IOrderService
    {
        Task<ResponseDto?> CreateOrder(CartDto cartDto);
    }
}
