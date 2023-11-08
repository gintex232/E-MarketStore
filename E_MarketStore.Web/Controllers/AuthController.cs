using E_MarketStore.Web.Models;
using E_MarketStore.Service.IService;
using Microsoft.AspNetCore.Mvc;
using E_MarketStore.Web.Utility;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_MarketStore.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new();
            return View(loginRequestDto);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var roleList = new List<SelectListItem>()
            {
                new SelectListItem{Text=Enums.RoleAdmin, Value=Enums.RoleAdmin},
                new SelectListItem{Text=Enums.RoleCustomer, Value=Enums.RoleCustomer}
            };
            ViewBag.RoleList = roleList;
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
