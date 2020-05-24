
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacyAchievement
    {
        [JsonConstructor]
        public ProfileLegacyAchievement(long achievementId, int completionDate)
        {
            AchievementId = achievementId;
            CompletionDate = completionDate;
        }

        public long AchievementId { get; }
        public int CompletionDate { get; }
    }

}
