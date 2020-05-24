using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    public sealed class GrandmasterLeaderboardRoot
    {
        [JsonConstructor]
        public GrandmasterLeaderboardRoot(IList<LadderTeam> ladderTeams)
        {
            LadderTeams = ladderTeams;
        }

        public IList<LadderTeam> LadderTeams { get; }
    }
}
