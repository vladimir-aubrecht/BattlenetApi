using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    public sealed class LadderSeason
    {
        [JsonConstructor]
        public LadderSeason(IList<LadderPosition> ladder, IList<LadderCharacter> characters, IList<NonRanked> nonRanked)
        {
            Ladder = ladder;
            Characters = characters;
            NonRanked = nonRanked;
        }

        public IList<LadderPosition> Ladder { get; }
        public IList<LadderCharacter> Characters { get; }
        public IList<NonRanked> NonRanked { get; }
    }

}
