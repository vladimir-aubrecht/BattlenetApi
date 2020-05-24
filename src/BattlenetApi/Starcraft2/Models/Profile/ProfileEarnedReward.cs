
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileEarnedReward
    {
        [JsonConstructor]
        public ProfileEarnedReward(long rewardId, bool selected, long achievementId, string category)
        {
            RewardId = rewardId;
            Selected = selected;
            AchievementId = achievementId;
            Category = category;
        }

        public long RewardId { get; }
        public bool Selected { get; }
        public long AchievementId { get; }
        public string Category { get; }
    }

}
