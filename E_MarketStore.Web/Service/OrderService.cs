using E_MarketStore.Web.Models;
using E_MarketStore.Web.Service.IService;
using E_MarketStore.Web.Utility;

namespace E_MarketStore.Web.Service
{
    public class OrderService : IOrderService
    {
        private readonly IBaseService _baseService;

        public OrderService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateOrder(CartDto cartDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Enums.ApiType.POST,
                Data = cartDto,
                Url = Enums.OrderAPIBase + "/api/order/CreateOrder"
            });
        }
    }
}
