
using ASoft.BattleNet.Starcraft2.Models.Achievements;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Rewards
{
    public sealed class LegacyRewardsAnimation
    {
        [JsonConstructor]
        public LegacyRewardsAnimation(string title, string command, long id, Icon icon, long achievementId)
        {
            Title = title;
            Command = command;
            Id = id;
            Icon = icon;
            AchievementId = achievementId;
        }

        public string Title { get; }
        public string Command { get; }
        public long Id { get; }
        public Icon Icon { get; }
        public long AchievementId { get; }
    }
}
