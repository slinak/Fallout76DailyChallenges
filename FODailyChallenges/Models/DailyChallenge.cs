using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace FODailyChallenges.Models;

public class DailyChallenge
{
    [Key]
    [DisplayName("Challenge ID")]
    public Guid ChallengeID { get; set; } = Guid.NewGuid();
    [DisplayName("Challenge Type")]
    public ChallengeType? ChallengeType { get; set; }
    [DisplayName("Challenge Text")]
    public string? ChallengeText { get; set; }
    public virtual ICollection<ChallengeResolution>? Resolutions { get; set; }

    public DailyChallenge() { }

    public DailyChallenge(Guid _challengeID) => ChallengeID = _challengeID;

    public DailyChallenge(ChallengeType _type, string _text)
    {
        ChallengeType = _type;
        ChallengeText = _text;
    }
}

public enum ChallengeType
{
    Action = 0,
    Location = 1,
}

