using Microsoft.EntityFrameworkCore;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.DAL.Context;

public class SqlContext : DbContext
{
    public SqlContext(DbContextOptions options) : base(options) { }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Assignment> Assignments { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
