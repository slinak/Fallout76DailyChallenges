using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FODailyChallenges.Models;

public class DailyChallenge
{
    [DisplayName("Challenge ID")]
    public string ChallengeID { get; set; }
    [DisplayName("Challenge Type")]
    public ChallengeType Type { get; set; }
    [DisplayName("Challenge Text")]
    public string? Text { get; set; }

    public DailyChallenge (ChallengeType _type, string _text)
    {
        ChallengeID = Guid.NewGuid ().ToString ();
        Type = _type;
        Text = _text;
    }
}

public enum ChallengeType
{
	Action = 0,
	Location = 1,
}