using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    public sealed class LadderLegacyRoot
    {
        [JsonConstructor]
        public LadderLegacyRoot(IList<LadderMember> ladderMembers)
        {
            LadderMembers = ladderMembers;
        }

        public IList<LadderMember> LadderMembers { get; }
    }
}
