using Microsoft.EntityFrameworkCore;

namespace FODailyChallenges.Models;

public class ChallengesDBContext : DbContext
{
    public DbSet<DailyChallenge> Challenge { get; set; }
    public DbSet<ChallengeResolution> Resolution { get; set; }

    public ChallengesDBContext(DbContextOptions<ChallengesDBContext> options) : base(options)
    {

    }
}