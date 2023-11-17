using E_MarketStore.Web.Models;
using E_MarketStore.Web.Service.IService;

namespace E_MarketStore.Web.Service
{
    public class CartService : ICartService
    {
        public Task<ResponseDto?> ApplyCouponAsync(CartDto cartDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetCartByUserIdAsync(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> RemoveFromCartAsync(int cartDetailsId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpsertCartAsync(CartDto cartDto)
        {
            throw new NotImplementedException();
        }
    }
}
