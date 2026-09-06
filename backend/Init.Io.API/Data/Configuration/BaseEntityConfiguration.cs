using Init.Io.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Init.Io.API.Data.Configuration;

public class BaseEntityTypeConfiguration : IEntityTypeConfiguration<BaseEntity>
{
    public void Configure(EntityTypeBuilder<BaseEntity> builder)
    {
        builder.HasKey(baseEntity => baseEntity.Id);
        builder.Property(baseEntity => baseEntity.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(baseEntity => baseEntity.CreatedBy)
            .WithMany()
            .HasForeignKey(baseEntity => baseEntity.CreatedById)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(baseEntity => baseEntity.UpdatedBy)
            .WithMany()
            .HasForeignKey(baseEntity => baseEntity.UpdatedById)
            .OnDelete(DeleteBehavior.SetNull);

        builder.Property(baseEntity => baseEntity.CreatedAt);

        builder.Property(baseEntity => baseEntity.UpdatedAt);
    }
}