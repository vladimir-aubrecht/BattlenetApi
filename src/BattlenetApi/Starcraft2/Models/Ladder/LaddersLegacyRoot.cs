using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    public sealed class LaddersLegacyRoot
    {
        [JsonConstructor]
        public LaddersLegacyRoot(IList<LadderSeason> currentSeason, IList<LadderSeason> previousSeason, IList<object> showcasePlacement)
        {
            CurrentSeason = currentSeason;
            PreviousSeason = previousSeason;
            ShowcasePlacement = showcasePlacement;
        }

        public IList<LadderSeason> CurrentSeason { get; }
        public IList<LadderSeason> PreviousSeason { get; }
        public IList<object> ShowcasePlacement { get; }
    }
}
