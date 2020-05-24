using System;
using System.Collections.Generic;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Static
{
    [DebuggerDisplay("CategoryId: {CategoryId} Title: {Title}")]
    public sealed class StaticAchievement
    {
        [JsonConstructor]
        public StaticAchievement(long categoryId, IList<long> chainAchievementIds, int chainRewardSize, IList<long> criteriaIds, string description, int flags, long id, Uri imageUrl, bool isChained, int points, string title, int uiOrderHint)
        {
            CategoryId = categoryId;
            ChainAchievementIds = chainAchievementIds;
            ChainRewardSize = chainRewardSize;
            CriteriaIds = criteriaIds;
            Description = description;
            Flags = flags;
            Id = id;
            ImageUrl = imageUrl;
            IsChained = isChained;
            Points = points;
            Title = title;
            UiOrderHint = uiOrderHint;
        }

        public long CategoryId { get; }
        public IList<long> ChainAchievementIds { get; }
        public int ChainRewardSize { get; }
        public IList<long> CriteriaIds { get; }
        public string Description { get; }
        public int Flags { get; }
        public long Id { get; }
        public Uri ImageUrl { get; }
        public bool IsChained { get; }
        public int Points { get; }
        public string Title { get; }
        public int UiOrderHint { get; }
    }

}
