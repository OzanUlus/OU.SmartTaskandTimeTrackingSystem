using Microsoft.EntityFrameworkCore;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry;
using System.Reflection;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Context
{
    public class TimeTrackingContext : DbContext
    {
        public TimeTrackingContext(DbContextOptions<TimeTrackingContext> options) : base(options)
        {
        }


        public DbSet<BreakPeriod> BreakPeriods { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
