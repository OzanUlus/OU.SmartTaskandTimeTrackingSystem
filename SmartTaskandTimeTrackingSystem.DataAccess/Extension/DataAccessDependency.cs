using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartTaskandTimeTrackingSystem.DataAccess.Context;
using SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Concretes;
using SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Interfaces;

namespace SmartTaskandTimeTrackingSystem.DataAccess.Extension
{
    public static class DataAccessDependency
    {
        public static IServiceCollection AddDataAccessDependency(this IServiceCollection services, string connectionString) 
        {

            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(connectionString);
            });


            services.AddScoped<ITaskItemRepository, TaskItemRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();





            return services;
        
        }
    }
}
