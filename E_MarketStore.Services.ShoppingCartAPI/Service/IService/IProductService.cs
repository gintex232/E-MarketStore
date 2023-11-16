using E_MarketStore.Services.ShoppingCartAPI.Models.DTO;

namespace E_MarketStore.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
