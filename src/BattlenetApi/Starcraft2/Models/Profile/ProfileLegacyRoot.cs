
using ASoft.BattleNet.Starcraft2.Models.Achievements;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacyRoot
    {
        [JsonConstructor]
        public ProfileLegacyRoot(string id, int realm, string displayName, string clanName, string clanTag, string profilePath, Icon portrait, ProfileLegacyCareer career, ProfileLegacySwarmlevels swarmLevels, ProfileLegacyCampaign campaign, ProfileLegacySeason season, ProfileLegacyRewards rewards, ProfileLegacyAchievements achievements)
        {
            Id = id;
            Realm = realm;
            DisplayName = displayName;
            ClanName = clanName;
            ClanTag = clanTag;
            ProfilePath = profilePath;
            Portrait = portrait;
            Career = career;
            SwarmLevels = swarmLevels;
            Campaign = campaign;
            Season = season;
            Rewards = rewards;
            Achievements = achievements;
        }

        public string Id { get; }
        public int Realm { get; }
        public string DisplayName { get; }
        public string ClanName { get; }
        public string ClanTag { get; }
        public string ProfilePath { get; }
        public Icon Portrait { get; }
        public ProfileLegacyCareer Career { get; }
        public ProfileLegacySwarmlevels SwarmLevels { get; }
        public ProfileLegacyCampaign Campaign { get; }
        public ProfileLegacySeason Season { get; }
        public ProfileLegacyRewards Rewards { get; }
        public ProfileLegacyAchievements Achievements { get; }
    }

}
