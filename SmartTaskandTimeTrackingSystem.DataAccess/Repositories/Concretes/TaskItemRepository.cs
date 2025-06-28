using SmartTaskandTimeTrackingSystem.DataAccess.Context;
using SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Domain.Entities;

namespace SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Concretes
{
    public class TaskItemRepository : GenericRepository<TaskItem>, ITaskItemRepository
    {
        public TaskItemRepository(AppDbContext context) : base(context)
        {
        }
    }
}
