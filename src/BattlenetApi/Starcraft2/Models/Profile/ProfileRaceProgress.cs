
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileRaceProgress
    {
        [JsonConstructor]
        public ProfileRaceProgress(int level, int maxLevelPoints, int currentLevelPoints)
        {
            Level = level;
            MaxLevelPoints = maxLevelPoints;
            CurrentLevelPoints = currentLevelPoints;
        }

        public int Level { get; }
        public int MaxLevelPoints { get; }
        public int CurrentLevelPoints { get; }
    }

}
