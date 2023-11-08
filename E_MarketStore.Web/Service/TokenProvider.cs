using E_MarketStore.Web.Service.IService;
using E_MarketStore.Web.Utility;

namespace E_MarketStore.Web.Service
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public TokenProvider(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public void ClearToken()
        {
            _contextAccessor.HttpContext?.Response.Cookies.Delete(Enums.TokenCookie);
        }

        public string? GetToken()
        {
            string? token = null;

            bool? hasToken  = _contextAccessor.HttpContext?.Request.Cookies.TryGetValue(Enums.TokenCookie, out token);

            return hasToken is true ? token : null;
        }

        public void SetToken(string token)
        {
            _contextAccessor.HttpContext?.Response.Cookies.Append(Enums.TokenCookie, token);
        }
    }
}
