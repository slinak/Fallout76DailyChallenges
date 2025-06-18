using System.ComponentModel;

namespace FODailyChallenges.Models;
public class ChallengeResolution
{
    public string ResolutionID { get; set; }
    public string? ChallengeID { get; set; }
    public string Location { get; set; }
    [DisplayName("An estimation of the quantity that can be found at the location")]
    public ResolutionQuantity Quantity { get; set; }

    public ChallengeResolution(string _challengeID, string _location, ResolutionQuantity _quantity)
    {
        ResolutionID = Guid.NewGuid().ToString();
        ChallengeID = _challengeID;
        Location = _location;
        Quantity = _quantity;
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