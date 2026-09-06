using Init.Io.API.Models;
using Microsoft.EntityFrameworkCore;
using Init.Io.API.Data.Configuration;

namespace Init.Io.API.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new UserEntityTypeConfiguration().Configure(modelBuilder.Entity<User>());
    }

}
