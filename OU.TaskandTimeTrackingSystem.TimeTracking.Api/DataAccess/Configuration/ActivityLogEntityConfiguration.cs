using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.ActivityLogs;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Configuration
{
    public class ActivityLogEntityConfiguration : IEntityTypeConfiguration<ActivityLog>
    {
        public void Configure(EntityTypeBuilder<ActivityLog> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserId)
                   .IsRequired();

            builder.Property(x => x.Action)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Description)
                   .HasMaxLength(500);

            builder.Property(x => x.CreatedAt)
                   .IsRequired();
        }
    }
}
