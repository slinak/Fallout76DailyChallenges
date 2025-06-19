using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace FODailyChallenges.Models;

public class DailyChallenge
{
    [Key]
    [DisplayName("Challenge ID")]
    public Guid ChallengeID { get; set; }
    [DisplayName("Challenge Type")]
    public ChallengeType ChallengeType { get; set; }
    [DisplayName("Challenge Text")]
    public string? ChallengeText { get; set; }

    public DailyChallenge()
    {

    }

    public DailyChallenge(ChallengeType _type, string _text)
    {
        ChallengeID = Guid.NewGuid();
        ChallengeType = _type;
        ChallengeText = _text;
    }
}

public enum ChallengeType
{
    Action = 0,
    Location = 1,
}

