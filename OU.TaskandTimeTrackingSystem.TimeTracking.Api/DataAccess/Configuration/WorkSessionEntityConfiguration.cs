using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.WorkSessions;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Configuration
{
    public class WorkSessionEntityConfiguration : IEntityTypeConfiguration<WorkSession>
    {
        public void Configure(EntityTypeBuilder<WorkSession> builder)
        {
            builder.Property(ws => ws.UserId)
               .IsRequired();

            builder.Property(ws => ws.Date)
                   .IsRequired()
                   .HasColumnType("date"); 

            builder.Property(ws => ws.TotalTrackedTime)
                   .IsRequired()
                   .HasConversion(
                       v => v.Ticks,
                       v => TimeSpan.FromTicks(v)
                   );

            builder.Property(ws => ws.CompletedTasks)
                   .IsRequired();
        }
    }
}
