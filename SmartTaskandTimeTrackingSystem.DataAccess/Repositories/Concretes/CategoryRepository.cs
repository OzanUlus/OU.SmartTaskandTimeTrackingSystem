using SmartTaskandTimeTrackingSystem.DataAccess.Context;
using SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Domain.Entities;

namespace SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Concretes
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
