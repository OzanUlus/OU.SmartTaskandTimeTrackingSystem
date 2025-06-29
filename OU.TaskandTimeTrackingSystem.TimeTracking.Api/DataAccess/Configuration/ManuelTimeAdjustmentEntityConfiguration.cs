using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.ManuelTimeAdjustments;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Configuration
{
    public class ManuelTimeAdjustmentEntityConfiguration : IEntityTypeConfiguration<ManuelTimeAdjustment>
    {
        public void Configure(EntityTypeBuilder<ManuelTimeAdjustment> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.UserId).HasMaxLength(16);

            builder.Property(m => m.RelatedTimeEntryId).HasMaxLength(16);

            builder.Property(m => m.AdjustmentDate).IsRequired();

            builder.Property(m => m.Duration).IsRequired();

            builder.Property(m => m.Reason).IsRequired().HasMaxLength(256);
        }
    }
}
