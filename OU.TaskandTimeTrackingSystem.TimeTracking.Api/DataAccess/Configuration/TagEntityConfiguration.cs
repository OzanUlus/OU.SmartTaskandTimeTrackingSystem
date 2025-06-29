using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Tags;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Configuration
{
    public class TagEntityConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(64);

            
        }
    }
}
