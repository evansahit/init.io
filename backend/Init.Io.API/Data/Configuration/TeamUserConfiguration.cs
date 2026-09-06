using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Init.Io.API.Models;

namespace Init.Io.API.Data.Configuration;

public class TeamUserEntityTypeConfiguration : IEntityTypeConfiguration<TeamUser>
{

    public void Configure(EntityTypeBuilder<TeamUser> builder)
    {
        builder.ToTable("team_users");

        builder.HasOne(teamUser => teamUser.User)
            .WithMany(user => user.TeamUsers)
            .HasForeignKey(teamUser => teamUser.UserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(teamUser => teamUser.Team)
            .WithMany(team => team.TeamUsers)
            .HasForeignKey(teamUser => teamUser.TeamId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(teamUser => teamUser.AssignedAt);

        builder.Property(teamUser => teamUser.Role)
            .IsRequired();

        // A User should only appear in a Team once.
        builder.HasIndex(teamUser => new
        {
            teamUser.TeamId,
            teamUser.UserId
        }).IsUnique();
    }
}