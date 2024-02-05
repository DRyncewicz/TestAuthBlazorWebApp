namespace TestAuth.Client.Services
{
    public interface IAuthenticationData
    {
        Task SaveTokenAsync(string token);
    }
}