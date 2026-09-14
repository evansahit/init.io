
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Init.Io.API.Models.Entity;

namespace Init.Io.API.Data.Configuration;

public class OnboardingFlowEntityTypeConfiguration : IEntityTypeConfiguration<OnboardingFlowEntity>
{
    public void Configure(EntityTypeBuilder<OnboardingFlowEntity> builder)
    {
        builder.ToTable("onboarding_flows");

        builder.Property(onboardingFlow => onboardingFlow.Title)
            .IsRequired()
            .HasMaxLength(EntityConfigConstants.ShortestMaxLength);

        builder.Property(organization => organization.Description)
            .HasMaxLength(EntityConfigConstants.LongestMaxLength);

        // todo evan: finish implementing   
        // builder.
    }
}