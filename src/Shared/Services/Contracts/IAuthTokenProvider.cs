namespace BitIosPwaSplashTest.Shared.Services.Contracts;

public interface IAuthTokenProvider
{
    Task<string?> GetAcccessTokenAsync();
}
