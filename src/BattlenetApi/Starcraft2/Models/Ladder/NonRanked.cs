
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    public sealed class NonRanked
    {
        [JsonConstructor]
        public NonRanked(string mmq, int gamesPlayed)
        {
            Mmq = mmq;
            GamesPlayed = gamesPlayed;
        }

        public string Mmq { get; }
        public int GamesPlayed { get; }
    }

}
