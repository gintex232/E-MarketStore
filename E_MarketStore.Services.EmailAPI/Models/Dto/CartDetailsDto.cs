namespace E_MarketStore.Services.EmailAPI.Models.Dto
{
    //public class CartDetailsDto
    //{
    //    public int CartDetaisId { get; set; }
    //    public int CartHeaderId { get; set; }
    //    public CartHeaderDto? CartHeader { get; set; }
    //    public int ProductId { get; set; }
    //    public ProductDto? Product { get; set; }
    //    public int Count { get; set; }
    //} 

    public record CartDetailsDto(
        int CartDetailsId,
        int CartHeaderId,
        CartHeaderDto? CartHeader,
        int ProductId,
        ProductDto? Product,
        int Count);
}
