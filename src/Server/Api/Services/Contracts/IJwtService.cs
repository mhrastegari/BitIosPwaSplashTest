using BitIosPwaSplashTest.Server.Api.Models.Account;
using BitIosPwaSplashTest.Shared.Dtos.Account;

namespace BitIosPwaSplashTest.Server.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
