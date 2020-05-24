
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacySwarmlevels
    {
        [JsonConstructor]
        public ProfileLegacySwarmlevels(int level, ProfileLegacyRaceProgress terran, ProfileLegacyRaceProgress zerg, ProfileLegacyRaceProgress protoss)
        {
            Level = level;
            Terran = terran;
            Zerg = zerg;
            Protoss = protoss;
        }

        public int Level { get; }
        public ProfileLegacyRaceProgress Terran { get; }
        public ProfileLegacyRaceProgress Zerg { get; }
        public ProfileLegacyRaceProgress Protoss { get; }
    }

}
