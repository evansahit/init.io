using Microsoft.EntityFrameworkCore;
using Init.Io.API.Models.Entity;

namespace Init.Io.API.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<OrganizationEntity> Organizations => Set<OrganizationEntity>();
    public DbSet<TeamEntity> Teams => Set<TeamEntity>();
    public DbSet<UserEntity> Users => Set<UserEntity>();
    public DbSet<TeamUserEntity> TeamUsers => Set<TeamUserEntity>();
    public DbSet<OnboardingFlowEntity> OnboardingFlows => Set<OnboardingFlowEntity>();
    public DbSet<SectionEntity> Sections => Set<SectionEntity>();
    public DbSet<ContentBlockEntity> ContentBlocks => Set<ContentBlockEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(ApplicationDbContext).Assembly);
    }

}
