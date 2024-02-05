using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using TestAuth.AuthenticationState;

namespace TestAuth.Services
{
    public class ServerAuthenticationStateService : IAuthenticationStateService
    {
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public ServerAuthenticationStateService(AuthenticationStateProvider authenticationStateProvider)
        {
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<ClaimsPrincipal> GetUserAsync()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            return authState.User;
        }
    }
}