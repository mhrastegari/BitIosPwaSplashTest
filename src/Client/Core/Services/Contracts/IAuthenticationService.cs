using BitIosPwaSplashTest.Shared.Dtos.Account;

namespace BitIosPwaSplashTest.Client.Core.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
