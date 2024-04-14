using Example.EFCore.DataContext.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Example.EFCore.DataContext.Entities;

public class ExampleEfModelEntityTypeConfiguration : IEntityTypeConfiguration<ExampleEfModel>
{
    public void Configure(EntityTypeBuilder<ExampleEfModel> builder)
    {
        builder.HasNoKey();
        builder.Property(e => e.Name)
            .HasMaxLength(100)
            .IsUnicode(false);
    }
}