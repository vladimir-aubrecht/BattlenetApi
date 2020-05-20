using System.Collections.Generic;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    [DebuggerDisplay("TeamMembers: {TeamMembers} Mmr: {Mmr}")]
    public class LadderTeam
    {
        public LadderTeam(IList<TeamMember> teamMembers, int previousRank, int points, int wins, int losses, int mmr, long joinTimestamp)
        {
            TeamMembers = teamMembers;
            PreviousRank = previousRank;
            Points = points;
            Wins = wins;
            Losses = losses;
            Mmr = mmr;
            JoinTimestamp = joinTimestamp;
        }

        [JsonProperty("teamMembers")]
        public IList<TeamMember> TeamMembers { get; }

        [JsonProperty("previousRank")]
        public int PreviousRank { get; }

        [JsonProperty("points")]
        public int Points { get; }

        [JsonProperty("wins")]
        public int Wins { get; }

        [JsonProperty("losses")]
        public int Losses { get; }

        [JsonProperty("mmr")]
        public int Mmr { get; }

        [JsonProperty("joinTimestamp")]
        public long JoinTimestamp { get; }
    }
}
