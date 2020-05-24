
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileSnapshot
    {
        [JsonConstructor]
        public ProfileSnapshot(ProfileSeasonSnapshot seasonSnapshot, int totalRankedSeasonGamesPlayed)
        {
            SeasonSnapshot = seasonSnapshot;
            TotalRankedSeasonGamesPlayed = totalRankedSeasonGamesPlayed;
        }

        public ProfileSeasonSnapshot SeasonSnapshot { get; }
        public int TotalRankedSeasonGamesPlayed { get; }
    }

}
