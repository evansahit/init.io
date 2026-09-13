using Microsoft.EntityFrameworkCore;

using Init.Io.API.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Init.Io.API.Data.Configuration;

public class ContentBlockEntityTypeConfiguration : IEntityTypeConfiguration<ContentBlockEntity>
{
    public void Configure(EntityTypeBuilder<ContentBlockEntity> builder)
    {
        builder.ToTable("content_blocks");

        builder.Property(contentBlock => contentBlock.OrdinalPosition)
            .IsRequired();

        builder.Property(contentBlock => contentBlock.Type)
            .IsRequired();

        builder.Property(contentBlock => contentBlock.DataJson)
            .IsRequired()
            .HasColumnType("jsonb");

        builder.HasOne<SectionEntity>()
            .WithMany(section => section.ContentBlocks)
            .HasForeignKey(contentBlock => contentBlock.SectionId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}