using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartTaskandTimeTrackingSystem.Domain.Entities;

namespace SmartTaskandTimeTrackingSystem.DataAccess.Configurations
{
    public class TaskItemEntityConfiguration : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.HasKey(ti => ti.Id);
            builder.Property(ti => ti.Id).ValueGeneratedNever();

            builder.Property(ti => ti.Title).IsRequired()
                                            .HasMaxLength(255);

            builder.Property(ti => ti.Description).IsRequired()
                                                  .HasMaxLength(512);

            builder.Property(ti => ti.TaskCode).HasMaxLength(32);

            builder.Property(ti => ti.UserId).IsRequired()
                                             .HasMaxLength(16);

            builder.Property(ti => ti.CategoryId).IsRequired()
                                                 .HasMaxLength(16);
        }
    }
}
