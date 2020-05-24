
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileSwarmlevels
    {
        [JsonConstructor]
        public ProfileSwarmlevels(int level, ProfileRaceProgress terran, ProfileRaceProgress zerg, ProfileRaceProgress protoss)
        {
            Level = level;
            Terran = terran;
            Zerg = zerg;
            Protoss = protoss;
        }

        public int Level { get; }
        public ProfileRaceProgress Terran { get; }
        public ProfileRaceProgress Zerg { get; }
        public ProfileRaceProgress Protoss { get; }
    }

}
