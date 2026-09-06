using Microsoft.EntityFrameworkCore;
using Init.Io.API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Init.Io.API.Data.Configuration;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.Property(user => user.Email)
            .IsRequired();
        builder.HasIndex(user => user.Email)
            .IsUnique();

        builder.Property(user => user.FirstName);

        builder.Property(user => user.LastName);

        builder.Property(user => user.ProfilePhotoUrl);

        builder.Property(user => user.ProfilePhotoUrl);

        builder.HasOne(user => user.Organization)
            .WithMany(organization => organization.Users)
            .HasForeignKey(user => user.OrganizationId)
            .IsRequired();

        // Team relation configuration is done in TeamUserConfiguration
    }
}