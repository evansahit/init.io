using Microsoft.EntityFrameworkCore;

using Init.Io.API.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Init.Io.API.Data.Configuration;

public class SectionEntityTypeConfiguration : IEntityTypeConfiguration<SectionEntity>
{
    public void Configure(EntityTypeBuilder<SectionEntity> builder)
    {
        builder.ToTable("sections");

        builder.Property(section => section.Title)
            .HasMaxLength(EntityConfigConstants.TitleMaxLength)
            .IsRequired();

        builder.Property(section => section.OrdinalPosition)
            .IsRequired();

        builder.HasOne<OnboardingFlowEntity>()
            .WithMany(flow => flow.Sections)
            .HasForeignKey(section => section.OnboardingFlowId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}