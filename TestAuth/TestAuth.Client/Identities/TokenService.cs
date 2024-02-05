
using Blazored.LocalStorage;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace TestAuth.Client.Identities
{
    public class TokenService
    {
        private readonly ILocalStorageService _localStorageService;

        public TokenService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        [JSInvokable]
        public async Task SaveToken(string token)
        {
            await _localStorageService.SetItemAsync("authToken", token);
        }
    }
}