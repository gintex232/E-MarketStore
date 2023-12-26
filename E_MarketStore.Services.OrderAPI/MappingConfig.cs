using AutoMapper;


namespace E_MarketStore.Services.OrderAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            {
                
            });
            return mappingConfig;
        }
    }
}
