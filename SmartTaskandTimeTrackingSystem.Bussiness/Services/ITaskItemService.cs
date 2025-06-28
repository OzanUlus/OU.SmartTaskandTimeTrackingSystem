using SmartTaskandTimeTrackingSystem.Domain.Dtos.TaskItemDtos;
using SmartTaskandTimeTrackingSystem.Shared.Result;

namespace SmartTaskandTimeTrackingSystem.Bussiness.Services
{
    public interface ITaskItemService
    {
        Task<IResult> GetTaskItemAsync(Guid taskItemId);
        Task<IResult> GetAllTaskItemAsync();
        Task<IResult> AddTaskItemAsync(CreateTaskItemDto createTaskItemDto);
        Task<IResult> DeleteTaskItemAsync(Guid taskItemId);
        Task<IResult> UpdateTaskItemAsync(UpdateTaskItemDto updateTaskItemDto);
    }
}
