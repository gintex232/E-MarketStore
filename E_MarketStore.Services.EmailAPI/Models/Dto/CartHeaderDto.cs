namespace E_MarketStore.Services.EmailAPI.Models.Dto
{
    
    public record CartHeaderDto(
        int CartHeaderId,
        string? UserId,
        string? CouponCode,
        double Discount,
        double CartTotal,
        string? Name,
        string? Phone,
        string? Email);
}
