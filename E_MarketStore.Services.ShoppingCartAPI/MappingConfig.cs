using AutoMapper;
using E_MarketStore.Services.ShoppingCartAPI.Models;
using E_MarketStore.Services.ShoppingCartAPI.Models.DTO;

namespace E_MarketStore.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            {
                Config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                Config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
