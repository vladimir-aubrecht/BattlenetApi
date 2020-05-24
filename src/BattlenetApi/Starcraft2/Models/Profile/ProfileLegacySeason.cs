using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacySeason
    {
        [JsonConstructor]
        public ProfileLegacySeason(int seasonId, int seasonNumber, int seasonYear, int totalGamesThisSeason, IList<ProfileLegacyStat> stats)
        {
            SeasonId = seasonId;
            SeasonNumber = seasonNumber;
            SeasonYear = seasonYear;
            TotalGamesThisSeason = totalGamesThisSeason;
            Stats = stats;
        }

        public int SeasonId { get; }
        public int SeasonNumber { get; }
        public int SeasonYear { get; }
        public int TotalGamesThisSeason { get; }
        public IList<ProfileLegacyStat> Stats { get; }
    }

}
