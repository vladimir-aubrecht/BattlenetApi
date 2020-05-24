
using ASoft.BattleNet.Starcraft2.Models.Achievements;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Rewards
{
    public sealed class LegacyRewardsSkin
    {
        [JsonConstructor]
        public LegacyRewardsSkin(string title, long id, Icon icon, string name, long achievementId)
        {
            Title = title;
            Id = id;
            Icon = icon;
            Name = name;
            AchievementId = achievementId;
        }

        public string Title { get; }
        public long Id { get; }
        public Icon Icon { get; }
        public string Name { get; }
        public long AchievementId { get; }
    }
}
