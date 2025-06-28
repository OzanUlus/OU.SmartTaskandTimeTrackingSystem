using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartTaskandTimeTrackingSystem.DataAccess.Context;

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








            return services;
        
        }
    }
}
