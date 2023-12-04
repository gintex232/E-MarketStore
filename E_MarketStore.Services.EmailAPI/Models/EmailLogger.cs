namespace E_MarketStore.Services.EmailAPI.Models
{
    //public class EmailLogger
    //{
    //}

    public record EmailLogger(
        int Id,
        string Email,
        string Message,
        DateTime? EmailSent);
}
