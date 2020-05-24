
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    public sealed class LadderSummaryShowcaseEntry
    {
        [JsonConstructor]
        public LadderSummaryShowcaseEntry(long ladderId, LadderTeam team, string leagueName, string localizedDivisionName, int rank, int wins, int losses)
        {
            LadderId = ladderId;
            Team = team;
            LeagueName = leagueName;
            LocalizedDivisionName = localizedDivisionName;
            Rank = rank;
            Wins = wins;
            Losses = losses;
        }

        public long LadderId { get; }
        public LadderTeam Team { get; }
        public string LeagueName { get; }
        public string LocalizedDivisionName { get; }
        public int Rank { get; }
        public int Wins { get; }
        public int Losses { get; }
    }
}
