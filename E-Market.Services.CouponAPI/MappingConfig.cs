using AutoMapper;
using E_Market.Services.CouponAPI.Models;
using E_Market.Services.CouponAPI.Models.Dto;

namespace E_Market.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            {
                Config.CreateMap<CouponDto, Coupon>().ReverseMap();
                Config.CreateMap<Coupon, CouponDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
