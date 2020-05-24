
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacyCareer
    {
        [JsonConstructor]
        public ProfileLegacyCareer(string primaryRace, int terranWins, int protossWins, int zergWins, string highest1v1Rank, string highestTeamRank, int seasonTotalGames, int careerTotalGames)
        {
            PrimaryRace = primaryRace;
            TerranWins = terranWins;
            ProtossWins = protossWins;
            ZergWins = zergWins;
            Highest1v1Rank = highest1v1Rank;
            HighestTeamRank = highestTeamRank;
            SeasonTotalGames = seasonTotalGames;
            CareerTotalGames = careerTotalGames;
        }

        public string PrimaryRace { get; }
        public int TerranWins { get; }
        public int ProtossWins { get; }
        public int ZergWins { get; }
        public string Highest1v1Rank { get; }
        public string HighestTeamRank { get; }
        public int SeasonTotalGames { get; }
        public int CareerTotalGames { get; }
    }

}
