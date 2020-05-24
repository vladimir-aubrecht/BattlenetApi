
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacyRaceProgress
    {
        [JsonConstructor]
        public ProfileLegacyRaceProgress(int level, int totalLevelXP, int currentLevelXP)
        {
            Level = level;
            TotalLevelXP = totalLevelXP;
            CurrentLevelXP = currentLevelXP;
        }

        public int Level { get; }
        public int TotalLevelXP { get; }
        public int CurrentLevelXP { get; }
    }

}
