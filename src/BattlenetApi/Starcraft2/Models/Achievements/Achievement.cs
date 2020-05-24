using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Achievements
{
    [DebuggerDisplay("{Title}")]
    public sealed class Achievement
    {
        [JsonConstructor]
        public Achievement(string title, string description, long achievementId, long categoryId, int points, Icon icon)
        {
            Title = title;
            Description = description;
            AchievementId = achievementId;
            CategoryId = categoryId;
            Points = points;
            Icon = icon;
        }

        public string Title { get; }
        public string Description { get; }
        public long AchievementId { get; }
        public long CategoryId { get; }
        public int Points { get; }
        public Icon Icon { get; }
    }
}
