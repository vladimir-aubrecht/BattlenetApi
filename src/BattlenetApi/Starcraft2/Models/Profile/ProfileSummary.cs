
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileSummary
    {
        [JsonConstructor]
        public ProfileSummary(long id, int realm, string displayName, string portrait, string decalTerran, string decalProtoss, string decalZerg, int totalSwarmLevel, int totalAchievementPoints)
        {
            Id = id;
            Realm = realm;
            DisplayName = displayName;
            Portrait = portrait;
            DecalTerran = decalTerran;
            DecalProtoss = decalProtoss;
            DecalZerg = decalZerg;
            TotalSwarmLevel = totalSwarmLevel;
            TotalAchievementPoints = totalAchievementPoints;
        }

        public long Id { get; }
        public int Realm { get; }
        public string DisplayName { get; }
        public string Portrait { get; }
        public string DecalTerran { get; }
        public string DecalProtoss { get; }
        public string DecalZerg { get; }
        public int TotalSwarmLevel { get; }
        public int TotalAchievementPoints { get; }
    }

}
