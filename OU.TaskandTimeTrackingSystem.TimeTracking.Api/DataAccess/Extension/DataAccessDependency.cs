using Microsoft.EntityFrameworkCore;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Context;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Extension
{
    public static class DataAccessDependency
    {
        public static IServiceCollection AddDataAccessDependcy(this IServiceCollection services, string connectionString) 
        {
            services.AddDbContext<TimeTrackingContext>(opt =>
            {
                opt.UseNpgsql(connectionString);
            });



            return services;
        }
    }
}
