using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    public class AchievementsCollection
    {
        public AchievementsCollection(IList<Achievement> achievements, IList<AchievementCategory> categories)
        {
            Achievements = achievements;
            Categories = categories;
        }

        [JsonProperty("achievements")]
        public IList<Achievement> Achievements { get; }

        [JsonProperty("categories")]
        public IList<AchievementCategory> Categories { get; }
    }
}
