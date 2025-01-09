using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.DAL.Configuration
{
    internal class AssignmentConfig : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasIndex(x => x.Title)
                .IsUnique();
            builder.HasIndex(x => x.Description)
                .IsUnique();
            builder.Property(x => x.Title)
                .HasMaxLength(64);
            builder.Property(x => x.Description)
                .HasMaxLength(256);
            builder
                .HasMany(x => x.Tags)
                .WithMany(y => y.Assignments);
        }
    }
}