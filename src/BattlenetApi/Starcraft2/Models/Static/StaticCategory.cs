using System.Collections.Generic;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Static
{
    [DebuggerDisplay("Id: {Id} Name: {Name}")]
    public sealed class StaticCategory
    {
        [JsonConstructor]
        public StaticCategory(IList<long> childrenCategoryIds, long featuredAchievementId, long id, string name, long? parentCategoryId, int points, int uiOrderHint, IList<int> medalTiers)
        {
            ChildrenCategoryIds = childrenCategoryIds;
            FeaturedAchievementId = featuredAchievementId;
            Id = id;
            Name = name;
            ParentCategoryId = parentCategoryId;
            Points = points;
            UiOrderHint = uiOrderHint;
            MedalTiers = medalTiers;
        }

        public IList<long> ChildrenCategoryIds { get; }
        public long FeaturedAchievementId { get; }
        public long Id { get; }
        public string Name { get; }
        public long? ParentCategoryId { get; }
        public int Points { get; }
        public int UiOrderHint { get; }
        public IList<int> MedalTiers { get; }
    }

}
