using Mapster;
using SmartTaskandTimeTrackingSystem.Bussiness.Services;
using SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Concretes;
using SmartTaskandTimeTrackingSystem.Domain.Dtos.TaskItemDtos;
using SmartTaskandTimeTrackingSystem.Domain.Entities;
using SmartTaskandTimeTrackingSystem.Shared.Result;
using SmartTaskandTimeTrackingSystem.Shared.Services;

namespace SmartTaskandTimeTrackingSystem.Bussiness.Managers
{
    public class TaskItemManager(TaskItemRepository taskItemRepository, IdentityServiceFake identityServiceFake) : ITaskItemService
    {
        public async Task<IResult> AddTaskItemAsync(CreateTaskItemDto createTaskItemDto)
        {
            createTaskItemDto.UserId = identityServiceFake.GetUserId;
            var taskItem = createTaskItemDto.Adapt<TaskItem>();
            await taskItemRepository.CreateAsync(taskItem);
            return new SuccessResult("TaskItem created successfully.");
        }

        public async Task<IResult> DeleteTaskItemAsync(Guid taskItemId)
        {
            var taskItem = await taskItemRepository.GetByIdAsync(taskItemId);
            if (taskItem is null) return new ErrorResult("TaskItem not found.");
            await taskItemRepository.DeleteAsync(taskItem);
            return new SuccessResult("TaskItem deleted successfully.");
        }

        public async Task<IResult> GetAllTaskItemAsync()
        {
            var taskItems = await taskItemRepository.GetAllAsync();
            if (taskItems is null) return new ErrorResult("TaskItems not found.");
            var taskItemsDto = taskItems.Adapt<IEnumerable<ResultTaskItemDto>>();
            return new SuccessDataResult<IEnumerable<ResultTaskItemDto>>(taskItemsDto, "TaskItems listed successfully.");
        }

        public async Task<IResult> GetTaskItemAsync(Guid taskItemId)
        {
            var taskItem = await taskItemRepository.GetByIdAsync(taskItemId);
            if (taskItem is null) return new ErrorResult("TaskItem not found.");
            var taskItemDto = taskItem.Adapt<ResultTaskItemDto>();
            return new SuccessDataResult<ResultTaskItemDto>(taskItemDto, "TaskItem not found.");
        }

        public async Task<IResult> UpdateTaskItemAsync(UpdateTaskItemDto updateTaskItemDto)
        {
            var taskItem = await taskItemRepository.GetByIdAsync(updateTaskItemDto.Id);
            if (taskItem is null) return new ErrorResult("TaskItem not found.");
            taskItem.Id = updateTaskItemDto.Id;
            taskItem.Title = updateTaskItemDto.Title;
            taskItem.Description = updateTaskItemDto.Description;
            taskItem.TaskCode = updateTaskItemDto.TaskCode;
            taskItem.UserId = identityServiceFake.GetUserId;
            taskItem.CategoryId = updateTaskItemDto.CategoryId;
            await taskItemRepository.UpdateAsync(taskItem);
            return new SuccessResult("TaskItem updated successfully.");
        }
    }
}
