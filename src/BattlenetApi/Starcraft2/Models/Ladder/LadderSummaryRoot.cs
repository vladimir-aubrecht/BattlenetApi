using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{

    public sealed class LadderSummaryRoot
    {
        [JsonConstructor]
        public LadderSummaryRoot(IList<LadderSummaryShowcaseEntry> showCaseEntries, IList<object> placementMatches, IList<LadderMembership> allLadderMemberships)
        {
            ShowCaseEntries = showCaseEntries;
            PlacementMatches = placementMatches;
            AllLadderMemberships = allLadderMemberships;
        }

        public IList<LadderSummaryShowcaseEntry> ShowCaseEntries { get; }
        public IList<object> PlacementMatches { get; }
        public IList<LadderMembership> AllLadderMemberships { get; }
    }
}
