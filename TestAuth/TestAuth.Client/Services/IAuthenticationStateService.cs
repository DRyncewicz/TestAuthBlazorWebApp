using System.Security.Claims;

namespace TestAuth.AuthenticationState
{
    public interface IAuthenticationStateService
    {
        Task<ClaimsPrincipal> GetUserAsync();
    }
}
