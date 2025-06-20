using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FODailyChallenges.Models;
public class ChallengeResolution
{
    [Key]
    public Guid ResolutionID { get; set; } = Guid.NewGuid();
    public string? ResolutionLocation { get; set; }
    [DisplayName("An estimation of the quantity that can be found at the location")]
    public ResolutionQuantity? ResolutionQuantity { get; set; }
    public DailyChallenge? DailyChallenge{ get; set; }

    public ChallengeResolution() { }

    public ChallengeResolution(Guid _challengeID) => DailyChallenge = new DailyChallenge(_challengeID);

    public ChallengeResolution(string _location, ResolutionQuantity _quantity)
    {
        ResolutionLocation = _location;
        ResolutionQuantity = _quantity;
    }
}

public enum ResolutionQuantity
{
    [Description("None probably won't be used")]
    None = 0,
    [Description("One is 1")]
    One = 1,
    [Description("Some is like 2-4ish")]
    Some = 2,
    [Description("Lots is 5+")]
    Lots = 3,
}