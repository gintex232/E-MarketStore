using E_MarketStore.Services.EmailAPI.Message;
using E_MarketStore.Services.EmailAPI.Models.Dto;
using System.Text;

namespace E_MarketStore.Services.EmailAPI.Services
{
    public class EmailService : IEmailService
    {
        private DbContextOptions<AppDbContext> _dbOptions;

        public EmailService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public async Task EmailCartAndLog(CartDto cartDto)
        {
            StringBuilder message = new StringBuilder();

            message.AppendLine("<br/>Cart Email Requested");
            message.AppendLine("<br/>Total" + cartDto.CartHeader.CartTotal);
            message.Append("<br/>");
            message.Append("<ul>");
            foreach(var item in cartDto.CartDetails)
            {
                message.Append("<li>");
                message.Append(item.Product.Name + " x " + item.Count);
                message.Append("</li>");
            }
            message.Append("</ul>");

            await LogAndEmail(message.ToString(), cartDto.CartHeader.Email);
        }

        public Task LogOrderPlaced(RewardsMessage rewardsDto)
        {
            throw new NotImplementedException();
        }

        public Task RegisterUserEmailAndLog(string email)
        {
            throw new NotImplementedException();
        }
    }
}
