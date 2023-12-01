namespace E_MarketStore.Services.EmailAPI.Models.Dto
{
    //public class CartDto
    //{
    //}

    public record CartDto(
        CartHeaderDto CartHeader,
        IEnumerable<CartDetailsDto>? CartDetails);
}
