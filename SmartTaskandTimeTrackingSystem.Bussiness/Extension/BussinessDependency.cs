using Microsoft.Extensions.DependencyInjection;
using SmartTaskandTimeTrackingSystem.Bussiness.Managers;
using SmartTaskandTimeTrackingSystem.Bussiness.Services;

namespace SmartTaskandTimeTrackingSystem.Bussiness.Extension
{
    public static class BussinessDependency
    {
        public static IServiceCollection AddBussinessDependency(this IServiceCollection services) 
        {
            services.AddScoped<ICategoryService,CategoryManager>();
            //services.AddScoped<ITaskItemService,TaskItemManager>();


            return services;
        }
    }
}
