using System.Diagnostics;
using System.Text.Json.Serialization;

namespace ASoft.BattleNet.Starcraft2.Models
{
    [DebuggerDisplay("{Title}")]
    public class Achievement
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("achievementId")]
        public string AchievementId { get; set; }
        [JsonPropertyName("categoryId")]
        public string CategoryId { get; set; }
        [JsonPropertyName("points")]
        public int Points { get; set; }
        [JsonPropertyName("icon")]
        public Icon Icon { get; set; }
    }
}
