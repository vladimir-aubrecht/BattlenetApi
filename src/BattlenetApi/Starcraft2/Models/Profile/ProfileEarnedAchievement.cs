
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileEarnedAchievement
    {
        [JsonConstructor]
        public ProfileEarnedAchievement(long achievementId, string completionDate, int numCompletedAchievementsInSeries, int totalAchievementsInSeries, bool isComplete, bool inProgress, ProfileCriterion[] criteria)
        {
            AchievementId = achievementId;
            CompletionDate = completionDate;
            NumCompletedAchievementsInSeries = numCompletedAchievementsInSeries;
            TotalAchievementsInSeries = totalAchievementsInSeries;
            IsComplete = isComplete;
            InProgress = inProgress;
            Criteria = criteria;
        }

        public long AchievementId { get; }
        public string CompletionDate { get; }
        public int NumCompletedAchievementsInSeries { get; }
        public int TotalAchievementsInSeries { get; }
        public bool IsComplete { get; }
        public bool InProgress { get; }
        public ProfileCriterion[] Criteria { get; }
    }

}
