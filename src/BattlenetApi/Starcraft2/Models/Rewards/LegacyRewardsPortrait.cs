
using ASoft.BattleNet.Starcraft2.Models.Achievements;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Rewards
{
    public sealed class LegacyRewardsPortrait
    {
        [JsonConstructor]
        public LegacyRewardsPortrait(string title, long id, Icon icon, long achievementId)
        {
            Title = title;
            Id = id;
            Icon = icon;
            AchievementId = achievementId;
        }

        public string Title { get; }
        public long Id { get; }
        public Icon Icon { get; }
        public long AchievementId { get; }
    }
}
