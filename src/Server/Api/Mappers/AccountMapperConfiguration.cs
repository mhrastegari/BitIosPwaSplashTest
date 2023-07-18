using BitIosPwaSplashTest.Server.Api.Models.Account;
using BitIosPwaSplashTest.Shared.Dtos.Account;

namespace BitIosPwaSplashTest.Server.Api.Mappers;

public class AccountMapperConfiguration : Profile
{
    public AccountMapperConfiguration()
    {
        CreateMap<Role, RoleDto>().ReverseMap();

        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, EditUserDto>().ReverseMap();
        CreateMap<User, SignUpRequestDto>()
            .ReverseMap();
    }
}
