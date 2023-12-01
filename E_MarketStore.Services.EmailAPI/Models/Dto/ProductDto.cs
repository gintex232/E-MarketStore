namespace E_MarketStore.Services.EmailAPI.Models.Dto
{
    //public class ProductDto
    //{
    //    public int ProductId { get; set; }

    //}

    public record ProductDto(
        int ProductId,
        string Name,
        double Price,
        string Description,
        string CategoryName,
        string ImageUrl,
        int Count);
}
