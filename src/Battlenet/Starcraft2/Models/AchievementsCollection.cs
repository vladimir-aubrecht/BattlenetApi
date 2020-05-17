using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ASoft.BattleNet.Starcraft2.Models
{
    public class AchievementsCollection
    {
        [JsonPropertyName("achievements")]
        public IList<Achievement> Achievements { get; set; }

        [JsonPropertyName("categories")]
        public IList<object> Categories { get; set; }
    }
}
