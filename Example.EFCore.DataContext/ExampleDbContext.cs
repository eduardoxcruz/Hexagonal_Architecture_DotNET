﻿using Example.EFCore.DataContext.Entities;
using Example.EFCore.DataContext.Models;

using Microsoft.EntityFrameworkCore;

namespace Example.EFCore.DataContext;

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