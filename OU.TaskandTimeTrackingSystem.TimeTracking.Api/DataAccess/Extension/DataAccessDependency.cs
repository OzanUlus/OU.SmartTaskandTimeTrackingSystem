using Microsoft.EntityFrameworkCore;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Context;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Concretes;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Repositories.Interfaces;

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

            services.AddScoped<ITimeEntryRepository, TimeEntryRepository>();

            return services;
        }
    }
}
