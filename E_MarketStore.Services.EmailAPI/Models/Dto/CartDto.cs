namespace E_MarketStore.Services.EmailAPI.Models.Dto
{
    public record CartDto(
        CartHeaderDto CartHeader,
        IEnumerable<CartDetailsDto>? CartDetails);
}
