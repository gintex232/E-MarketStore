using E_MarketStore.Services.OrderAPI.Models.Dto;

namespace E_MarketStore.Services.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
