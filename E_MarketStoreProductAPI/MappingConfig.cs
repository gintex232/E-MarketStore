using AutoMapper;
using E_MarketStoreProductAPI.Models;
using E_MarketStoreProductAPI.Models.DTO;

namespace E_MarketStoreProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            {
                Config.CreateMap<ProductDto, Product>();
            });
            return mappingConfig;
        }
    }
}
