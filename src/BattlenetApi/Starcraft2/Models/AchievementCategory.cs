using System.Collections.Generic;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    [DebuggerDisplay("CategoryId: {CategoryId} Title: {Title}")]
    public class AchievementCategory
    {
        public AchievementCategory(string title, string categoryId, string featuredAchievementId, IList<AchievementCategory>? subCategories)
        {
            Title = title;
            CategoryId = categoryId;
            FeaturedAchievementId = featuredAchievementId;
            SubCategories = subCategories ?? new List<AchievementCategory>();
        }

        [JsonProperty("title")]
        public string Title { get; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; }

        [JsonProperty("featuredAchievementId")]
        public string FeaturedAchievementId { get; }

        [JsonProperty("children")]
        public IList<AchievementCategory> SubCategories { get; }
    }
}
