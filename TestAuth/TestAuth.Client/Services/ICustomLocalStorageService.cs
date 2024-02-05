namespace TestAuth.Client.Services
{
    public interface ICustomLocalStorageService
    {
        Task SetItemAsync<T>(string key, T value);
        Task<T> GetItemAsync<T>(string key);
        Task RemoveItemAsync(string key);

    }
}
