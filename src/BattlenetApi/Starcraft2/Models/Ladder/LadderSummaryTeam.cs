
using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    public sealed class LadderSummaryTeam
    {
        [JsonConstructor]
        public LadderSummaryTeam(string localizedGameMode, IList<LadderSummaryMember> members)
        {
            LocalizedGameMode = localizedGameMode;
            Members = members;
        }

        public string LocalizedGameMode { get; }
        public IList<LadderSummaryMember> Members { get; }
    }
}
