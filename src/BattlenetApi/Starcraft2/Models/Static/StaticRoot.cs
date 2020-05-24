using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Static
{

    public sealed class StaticRoot
    {
        [JsonConstructor]
        public StaticRoot(IList<StaticAchievement> achievements, IList<StaticCriterion> criteria, IList<StaticCategory> categories, IList<StaticReward> rewards)
        {
            Achievements = achievements;
            Criteria = criteria;
            Categories = categories;
            Rewards = rewards;
        }

        public IList<StaticAchievement> Achievements { get; }
        public IList<StaticCriterion> Criteria { get; }
        public IList<StaticCategory> Categories { get; }
        public IList<StaticReward> Rewards { get; }
    }
}
