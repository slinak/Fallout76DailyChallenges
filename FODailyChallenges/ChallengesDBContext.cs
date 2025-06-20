using Microsoft.EntityFrameworkCore;

namespace FODailyChallenges.Models;

public class ChallengesDBContext : DbContext
{
    public DbSet<DailyChallenge> Challenges { get; set; }
    public DbSet<ChallengeResolution> Resolutions { get; set; }
    public ChallengesDBContext(DbContextOptions<ChallengesDBContext> options) : base(options) { }
}