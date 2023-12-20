namespace E_MarketStore.Services.EmailAPI.Models.Dto
{
    public record CartDetailsDto(
        int CartDetailsId,
        int CartHeaderId,
        CartHeaderDto? CartHeader,
        int ProductId,
        ProductDto? Product,
        int Count);
}
