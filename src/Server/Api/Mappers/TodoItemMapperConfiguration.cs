using BitIosPwaSplashTest.Server.Api.Models.TodoItem;
using BitIosPwaSplashTest.Shared.Dtos.TodoItem;

namespace BitIosPwaSplashTest.Server.Api.Mappers;

public class TodoItemMapperConfiguration : Profile
{
    public TodoItemMapperConfiguration()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}
