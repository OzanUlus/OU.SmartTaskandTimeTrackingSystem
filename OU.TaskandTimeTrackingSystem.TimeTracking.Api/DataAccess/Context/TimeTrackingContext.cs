using Microsoft.EntityFrameworkCore;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.ActivityLogs;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.ManuelTimeAdjustments;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Tags;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.WorkSessions;
using System.Reflection;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Context
{
    public class TimeTrackingContext : DbContext
    {
        public TimeTrackingContext(DbContextOptions<TimeTrackingContext> options) : base(options)
        {
        }

        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<BreakPeriod> BreakPeriods { get; set; }
        public DbSet<ManuelTimeAdjustment> ManuelTimeAdjustments { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }
        public DbSet<WorkSession> WorkSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
