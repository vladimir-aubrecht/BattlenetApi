using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Models.Starcraft2
{
    public class AchievementsCollection
    {
        public AchievementsCollection(IList<Achievement> achievements, IList<object> categories)
        {
            Achievements = achievements;
            Categories = categories;
        }

        [JsonProperty("achievements")]
        public IList<Achievement> Achievements { get; }

        [JsonProperty("categories")]
        public IList<object> Categories { get; }
    }
}
