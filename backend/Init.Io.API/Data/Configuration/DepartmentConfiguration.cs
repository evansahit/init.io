
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Init.Io.API.Models.Entity;

namespace Init.Io.API.Data.Configuration;

public class DepartmentEntityTypeConfiguration : IEntityTypeConfiguration<DepartmentEntity>
{
    public void Configure(EntityTypeBuilder<DepartmentEntity> builder)
    {
        builder.ToTable("departments");

        builder.Property(department => department.Name)
            .IsRequired()
            .HasMaxLength(EntityConfigConstants.ShortMaxLength);

        builder.Property(department => department.Description)
            .HasMaxLength(EntityConfigConstants.LongestMaxLength);

        builder.Property(department => department.LogoUrl);

        builder.HasOne<OrganizationEntity>()
            .WithMany(organization => organization.Departments)
            .HasForeignKey(department => department.OrganizationId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}