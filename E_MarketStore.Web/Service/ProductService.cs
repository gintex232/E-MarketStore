using E_MarketStore.Web.Models;
using E_MarketStore.Web.Service.IService;
using E_MarketStore.Web.Utility;

namespace E_MarketStore.Web.Service
{
    public class ProductService : IProductService
    {
        private readonly IBaseService _baseService;
        public ProductService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateProductAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Enums.ApiType.POST,
                Data = productDto,
                Url = Enums.ProductAPIBase + "/api/product"
            });
        }

        public async Task<ResponseDto?> DeleteProductAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Enums.ApiType.DELETE,
                Url = Enums.ProductAPIBase + "/api/product/" + id
            });
        }

        public async Task<ResponseDto?> GetAllProductAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Enums.ApiType.GET,
                Url = Enums.ProductAPIBase + "/api/product"
            });
        }

        public async Task<ResponseDto?> GetProductByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Enums.ApiType.GET,
                Url = Enums.ProductAPIBase + "/api/product/" + id
            });
        }

        public async Task<ResponseDto?> UpdateProductAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Enums.ApiType.PUT,
                Data = productDto,
                Url = Enums.ProductAPIBase + "/api/product"
            });
        }
    }
}

