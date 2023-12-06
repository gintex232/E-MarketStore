using System.ComponentModel.DataAnnotations;

namespace E_MarketStoreProductAPI.Models.DTO
{
    public record ProductDto(
        int ProductId,
        string Name,
        double Price,
        string Description,
        string CategoryName,
        string ImageUrl);
}
