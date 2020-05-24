
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    public sealed class LadderPosition
    {
        [JsonConstructor]
        public LadderPosition(string ladderName, long ladderId, int division, int rank, string league, string matchMakingQueue, int wins, int losses, bool showcase)
        {
            LadderName = ladderName;
            LadderId = ladderId;
            Division = division;
            Rank = rank;
            League = league;
            MatchMakingQueue = matchMakingQueue;
            Wins = wins;
            Losses = losses;
            Showcase = showcase;
        }

        public string LadderName { get; }
        public long LadderId { get; }
        public int Division { get; }
        public int Rank { get; }
        public string League { get; }
        public string MatchMakingQueue { get; }
        public int Wins { get; }
        public int Losses { get; }
        public bool Showcase { get; }
    }

}
