
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Init.Io.API.Models.Entity;

namespace Init.Io.API.Data.Configuration;

public class TeamEntityTypeConfiguration : IEntityTypeConfiguration<TeamEntity>
{
    public void Configure(EntityTypeBuilder<TeamEntity> builder)
    {
        builder.ToTable("teams");

        builder.Property(team => team.Name)
            .IsRequired()
            .HasMaxLength(EntityConfigConstants.ShortestMaxLength);

        // Team names are unique within Organizations.
        // But team names are not unique in general.
        builder.HasIndex(team => new
        {
            team.OrganizationId,
            team.Name
        }).IsUnique();

        builder.Property(team => team.Description)
            .HasMaxLength(EntityConfigConstants.LongestMaxLength);

        builder.Property(team => team.LogoUrl)
            .HasMaxLength(EntityConfigConstants.LongestMaxLength);

        builder.HasOne(team => team.Organization)
            .WithMany(organization => organization.Teams)
            .HasForeignKey(team => team.OrganizationId)
            .IsRequired();

        // User relation configuration is done in TeamUserConfiguration

    }
}