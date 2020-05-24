
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLadderSnapshot
    {
        [JsonConstructor]
        public ProfileLadderSnapshot(int rank, string leagueName, int totalGames, int totalWins)
        {
            Rank = rank;
            LeagueName = leagueName;
            TotalGames = totalGames;
            TotalWins = totalWins;
        }

        public int Rank { get; }
        public string LeagueName { get; }
        public int TotalGames { get; }
        public int TotalWins { get; }
    }

}
