
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Init.Io.API.Models.Entity;

namespace Init.Io.API.Data.Configuration;

public class OrganizationEntityTypeConfiguration : IEntityTypeConfiguration<OrganizationEntity>
{
    public void Configure(EntityTypeBuilder<OrganizationEntity> builder)
    {
        builder.ToTable("organizations");

        builder.Property(organization => organization.Name)
            .IsRequired()
            .HasMaxLength(EntityConfigConstants.ShortMaxLength);

        builder.Property(organization => organization.Description)
            .HasMaxLength(EntityConfigConstants.LongestMaxLength);

        builder.Property(organization => organization.LogoUrl);
    }
}