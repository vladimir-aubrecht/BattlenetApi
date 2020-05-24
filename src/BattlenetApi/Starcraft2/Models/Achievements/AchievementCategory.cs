using System.Collections.Generic;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Achievements
{
    [DebuggerDisplay("CategoryId: {CategoryId} Title: {Title}")]
    public sealed class AchievementCategory
    {
        [JsonConstructor]
        public AchievementCategory(string title, long categoryId, long featuredAchievementId, IList<AchievementCategory>? subCategories)
        {
            Title = title;
            CategoryId = categoryId;
            FeaturedAchievementId = featuredAchievementId;
            SubCategories = subCategories ?? new List<AchievementCategory>();
        }

        public string Title { get; }
        public long CategoryId { get; }
        public long FeaturedAchievementId { get; }
        [JsonProperty("children")]
        public IList<AchievementCategory> SubCategories { get; }
    }
}
