using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Configuration
{
    public class ReminderEntityConfiguration : IEntityTypeConfiguration<Reminder>
    {
        public void Configure(EntityTypeBuilder<Reminder> builder)
        {
            builder.ToTable("Reminders");

            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.TimeEntry)
                   .WithOne() 
                   .HasForeignKey<Reminder>(r => r.TimeEntryId)
                   .OnDelete(DeleteBehavior.Cascade); 

            builder.Property(r => r.ReminderTime)
                   .IsRequired();

            builder.Property(r => r.IsSent)
                   .HasDefaultValue(false);
        }
    }
}
