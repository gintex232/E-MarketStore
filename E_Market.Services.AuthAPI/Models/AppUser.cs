using Microsoft.AspNetCore.Identity;

namespace E_Market.Services.AuthAPI.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
