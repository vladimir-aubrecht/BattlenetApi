using System.Collections.Generic;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    [DebuggerDisplay("TeamMembers: {TeamMembers} Mmr: {Mmr}")]
    public sealed class LadderTeam
    {
        [JsonConstructor]
        public LadderTeam(IList<LadderTeamMember> teamMembers, int previousRank, int points, int wins, int losses, int mmr, long joinTimestamp)
        {
            TeamMembers = teamMembers;
            PreviousRank = previousRank;
            Points = points;
            Wins = wins;
            Losses = losses;
            Mmr = mmr;
            JoinTimestamp = joinTimestamp;
        }

        public IList<LadderTeamMember> TeamMembers { get; }
        public int PreviousRank { get; }
        public int Points { get; }
        public int Wins { get; }
        public int Losses { get; }
        public int Mmr { get; }
        public long JoinTimestamp { get; }
    }
}
