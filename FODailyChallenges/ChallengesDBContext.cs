using Microsoft.EntityFrameworkCore;

namespace FODailyChallenges.Models;

public class ChallengesDBContext: DbContext
{
    public DbSet<DailyChallenge> Challenge { get; set; }
    public DbSet<ChallengeResolution> Resolution { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
    }
}