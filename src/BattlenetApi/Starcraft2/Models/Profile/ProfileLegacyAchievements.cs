using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacyAchievements
    {
        [JsonConstructor]
        public ProfileLegacyAchievements(ProfileLegacyPoints points, IList<ProfileLegacyAchievement> achievements)
        {
            Points = points;
            Achievements = achievements;
        }

        public ProfileLegacyPoints Points { get; }
        public IList<ProfileLegacyAchievement> Achievements { get; }
    }

}
