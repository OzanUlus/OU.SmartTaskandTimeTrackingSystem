using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Configuration
{
    public class TimeEntryEntityConfiguration : IEntityTypeConfiguration<TimeEntry>
    {
        public void Configure(EntityTypeBuilder<TimeEntry> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.UserId).IsRequired()
                                           .HasMaxLength(16);

            builder.Property(t => t.TaskId).IsRequired()
                                          .HasMaxLength(16);

            builder.Property(t => t.StartTime).IsRequired();

            builder.Property(t => t.Note).HasMaxLength(255);
                                         
        }
    }
}
