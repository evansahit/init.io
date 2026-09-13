
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Init.Io.API.Models.Entity;

namespace Init.Io.API.Data.Configuration;

public class OrganizationEntityTypeConfiguration : IEntityTypeConfiguration<OrganizationEntity>
{
    public void Configure(EntityTypeBuilder<OrganizationEntity> builder)
    {
        builder.ToTable("organizations");

        builder.Property(team => team.Name)
            .IsRequired()
            .HasMaxLength(EntityConfigConstants.TitleMaxLength);

        builder.Property(team => team.Description);

        builder.Property(team => team.LogoUrl);
    }
}