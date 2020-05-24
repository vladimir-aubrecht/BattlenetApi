using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{

    public sealed class Profile
    {
        [JsonConstructor]
        public Profile(ProfileSummary summary, ProfileSnapshot snapshot, ProfileCareer career, ProfileSwarmlevels swarmLevels, ProfileCampaign campaign, IList<ProfileCategoryPointProgress> categoryPointProgress, IList<long> achievementShowcase, IList<ProfileEarnedReward> earnedRewards, IList<ProfileEarnedAchievement> earnedAchievements)
        {
            Summary = summary;
            Snapshot = snapshot;
            Career = career;
            SwarmLevels = swarmLevels;
            Campaign = campaign;
            CategoryPointProgress = categoryPointProgress;
            AchievementShowcase = achievementShowcase;
            EarnedRewards = earnedRewards;
            EarnedAchievements = earnedAchievements;
        }

        public ProfileSummary Summary { get; }
        public ProfileSnapshot Snapshot { get; }
        public ProfileCareer Career { get; }
        public ProfileSwarmlevels SwarmLevels { get; }
        public ProfileCampaign Campaign { get; }
        public IList<ProfileCategoryPointProgress> CategoryPointProgress { get; }
        public IList<long> AchievementShowcase { get; }
        public IList<ProfileEarnedReward> EarnedRewards { get; }
        public IList<ProfileEarnedAchievement> EarnedAchievements { get; }
    }
}
