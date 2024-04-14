using $ext_safeprojectname$.EFCore.DataContext.Entities;
using $ext_safeprojectname$.EFCore.DataContext.Models;

using Microsoft.EntityFrameworkCore;

namespace $ext_safeprojectname$.EFCore.DataContext;

public partial class ExampleDbContext : DbContext
{
    public virtual DbSet<ExampleEfModel> ExampleModels { get; set; }

    public ExampleDbContext(DbContextOptions<ExampleDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new ExampleEfModelEntityTypeConfiguration().Configure(modelBuilder.Entity<ExampleEfModel>());
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}