using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Configuration
{
    public class BreakPeriodEntityConfiguration : IEntityTypeConfiguration<BreakPeriod>
    {
        public void Configure(EntityTypeBuilder<BreakPeriod> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(bp => bp.Id).HasMaxLength(16);
            builder.Property(bp => bp.TimeEntryId).HasMaxLength(16);
            builder.Property(bp => bp.StartTime).IsRequired();

            builder.HasOne(bp => bp.TimeEntry)
                   .WithMany(t => t.BreakPeriods)
                   .HasForeignKey(bp => bp.TimeEntryId);
        }
    }
}
