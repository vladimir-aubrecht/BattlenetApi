using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    [DebuggerDisplay("{Title}")]
    public class Achievement
    {
        public Achievement(string title, string description, string achievementId, string categoryId, int points, Icon icon)
        {
            Title = title;
            Description = description;
            AchievementId = achievementId;
            CategoryId = categoryId;
            Points = points;
            Icon = icon;
        }

        [JsonProperty("title")]
        public string Title { get; }
        [JsonProperty("description")]
        public string Description { get; }
        [JsonProperty("achievementId")]
        public string AchievementId { get; }
        [JsonProperty("categoryId")]
        public string CategoryId { get; }
        [JsonProperty("points")]
        public int Points { get; }
        [JsonProperty("icon")]
        public Icon Icon { get; }
    }
}
