using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Init.Io.API.Models.Entity;

namespace Init.Io.API.Data.Configuration;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("users");

        builder.Property(user => user.Email)
            .IsRequired()
            .HasMaxLength(EntityConfigConstants.ShortMaxLength);
        builder.HasIndex(user => user.Email)
            .IsUnique();

        builder.Property(user => user.FirstName)
            .HasMaxLength(EntityConfigConstants.ShortestMaxLength);

        builder.Property(user => user.LastName)
            .HasMaxLength(EntityConfigConstants.ShortestMaxLength);

        builder.Property(user => user.ProfilePhotoUrl);

        builder.HasOne(user => user.Organization)
            .WithMany(organization => organization.Users)
            .HasForeignKey(user => user.OrganizationId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(user => user.Department)
            .WithMany(department => department.Users)
            .HasForeignKey(user => user.DepartmentId);

        // Team relation configuration is done in TeamUserConfiguration
    }
}