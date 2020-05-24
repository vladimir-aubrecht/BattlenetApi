using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Achievements
{
    public sealed class AchievementsRoot
    {
        [JsonConstructor]
        public AchievementsRoot(IList<Achievement> achievements, IList<AchievementCategory> categories)
        {
            Achievements = achievements;
            Categories = categories;
        }

        public IList<Achievement> Achievements { get; }
        public IList<AchievementCategory> Categories { get; }
    }
}
