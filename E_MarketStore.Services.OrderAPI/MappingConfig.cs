using AutoMapper;
using E_MarketStore.Services.OrderAPI.Models;
using E_MarketStore.Services.OrderAPI.Models.Dto;

namespace E_MarketStore.Services.OrderAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            {
                Config.CreateMap<OrderHeaderDto, CartHeaderDto>()
                .ForMember(destination=>destination.CartTotal, u=>u.MapFrom(src=>src.OrderTotal)).ReverseMap();

                Config.CreateMap<CartDetailsDto, OrderDetailsDto>()
                .ForMember(destination => destination.ProductName, u => u.MapFrom(src => src.Product.Name))
                .ForMember(destination => destination.Price, u => u.MapFrom(src => src.Product.Price));

                Config.CreateMap<OrderDetailsDto, CartDetailsDto>();

                Config.CreateMap<OrderHeader,  OrderHeaderDto>().ReverseMap();
                Config.CreateMap<OrderDetailsDto, OrderDetails>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
