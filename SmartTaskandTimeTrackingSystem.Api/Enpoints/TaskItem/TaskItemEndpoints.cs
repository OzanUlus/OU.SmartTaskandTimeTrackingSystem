using Microsoft.AspNetCore.Mvc;
using SmartTaskandTimeTrackingSystem.Bussiness.Services;
using SmartTaskandTimeTrackingSystem.Domain.Dtos.CategoryDtos;
using SmartTaskandTimeTrackingSystem.Domain.Dtos.TaskItemDtos;
using SmartTaskandTimeTrackingSystem.Shared.Filters;

namespace SmartTaskandTimeTrackingSystem.Api.Enpoints.TaskItem
{
    public static class TaskItemEndpoints
    {
        public static RouteGroupBuilder CreateTaskItemGroupItemEndpoint(this RouteGroupBuilder group)
        {

             group.MapPost("/", async ([FromBody] CreateTaskItemDto createTakItemDto, ITaskItemService taskItemService) => (await taskItemService.AddTaskItemAsync(createTakItemDto))).WithName("CreateTaskItem").AddEndpointFilter<ValidationFilter<CreateTaskItemDto>>();

            return group;


        }

        public static RouteGroupBuilder GetAllTaskItemsGroupItemEndpoint(this RouteGroupBuilder group)
        {

             group.MapGet("/", async (ITaskItemService taskItemService) => (await taskItemService.GetAllTaskItemAsync())).WithName("GetAllTaskItems");

            return group;


        }

        public static RouteGroupBuilder GetByIdTaskItemGroupItemEndpoint(this RouteGroupBuilder group)
        {

             group.MapGet("/{id:guid}", async (ITaskItemService taskItemService, Guid id) => (await taskItemService.GetTaskItemAsync(id))).WithName("GetByIdTaskItem");

            return group;


        }

        public static RouteGroupBuilder DeleteTaskItemGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapDelete("/{id:guid}", async (ITaskItemService taskItemService, Guid id) => (await taskItemService.DeleteTaskItemAsync(id))).WithName("DeleteTaskItem");

            return group;


        }

        public static RouteGroupBuilder UpdateTaskItemGroupItemEndpoint(this RouteGroupBuilder group)
        {

            group.MapPut("/", async ([FromBody] UpdateTaskItemDto updateTakItemDto, ITaskItemService taskItemService) => (await taskItemService.UpdateTaskItemAsync(updateTakItemDto))).WithName("UpdateTaskItem").AddEndpointFilter<ValidationFilter<UpdateTaskItemDto>>();

            return group;


        }

    }
}
