using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartTaskandTimeTrackingSystem.Domain.Entities;

namespace SmartTaskandTimeTrackingSystem.DataAccess.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).ValueGeneratedNever();

            builder.Property(c => c.CategoryName).IsRequired()
                                                 .HasMaxLength(128);

            builder.Property(c => c.CategoryCode).HasMaxLength(32);

            builder.HasMany(c => c.TaskItems)
                   .WithOne(ti => ti.Category)
                   .HasForeignKey(ti => ti.CategoryId);
        }
    }
}
