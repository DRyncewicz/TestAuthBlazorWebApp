using Microsoft.JSInterop;
using System.Text.Json;

namespace TestAuth.Client.Services
{
    public class CustomLocalStorageService : ICustomLocalStorageService
    {
        private readonly IJSRuntime _jsRuntime;

        public CustomLocalStorageService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task SetItemAsync<T>(string key, T value)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, JsonSerializer.Serialize(value));
        }

        public async Task<T> GetItemAsync<T>(string key)
        {
            var jsonString = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
            return jsonString is null ? default : JsonSerializer.Deserialize<T>(jsonString);
        }

        public async Task RemoveItemAsync(string key)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        }
    }
}