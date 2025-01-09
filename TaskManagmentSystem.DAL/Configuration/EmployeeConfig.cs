using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.DAL.Configuration;

public class EmployeeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasIndex(x => x.Name)
            .IsUnique();
        builder.HasIndex(x => x.Surname)
            .IsUnique();
        builder.Property(x => x.Name)
            .HasMaxLength(25);
        builder.Property(x => x.Surname)
            .HasMaxLength(35);
    }
}