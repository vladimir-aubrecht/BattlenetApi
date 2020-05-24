
using System.Collections.Generic;

using ASoft.BattleNet.Starcraft2.Models.Ladder;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{

    public sealed class LadderRoot
    {
        [JsonConstructor]
        public LadderRoot(IList<LadderTeam> ladderTeams, IList<LadderMembership> allLadderMemberships, string localizedDivision, string league, LadderMembership currentLadderMembership, IList<LadderRanks> ranksAndPools)
        {
            LadderTeams = ladderTeams;
            AllLadderMemberships = allLadderMemberships;
            LocalizedDivision = localizedDivision;
            League = league;
            CurrentLadderMembership = currentLadderMembership;
            this.ranksAndPools = ranksAndPools;
        }

        public IList<LadderTeam> LadderTeams { get; }
        public IList<LadderMembership> AllLadderMemberships { get; }
        public string LocalizedDivision { get; }
        public string League { get; }
        public LadderMembership CurrentLadderMembership { get; }
        public IList<LadderRanks> ranksAndPools { get; }
    }
}
