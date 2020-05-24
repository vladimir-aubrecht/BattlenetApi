
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileCareer
    {
        [JsonConstructor]
        public ProfileCareer(int terranWins, int zergWins, int protossWins, int totalCareerGames, int totalGamesThisSeason, string? current1v1LeagueName, string? currentBestTeamLeagueName, ProfileLeague best1v1Finish, ProfileLeague bestTeamFinish)
        {
            TerranWins = terranWins;
            ZergWins = zergWins;
            ProtossWins = protossWins;
            TotalCareerGames = totalCareerGames;
            TotalGamesThisSeason = totalGamesThisSeason;
            Current1v1LeagueName = current1v1LeagueName;
            CurrentBestTeamLeagueName = currentBestTeamLeagueName;
            Best1v1Finish = best1v1Finish;
            BestTeamFinish = bestTeamFinish;
        }

        public int TerranWins { get; }
        public int ZergWins { get; }
        public int ProtossWins { get; }
        public int TotalCareerGames { get; }
        public int TotalGamesThisSeason { get; }
        public string? Current1v1LeagueName { get; }
        public string? CurrentBestTeamLeagueName { get; }
        public ProfileLeague Best1v1Finish { get; }
        public ProfileLeague BestTeamFinish { get; }
    }

}
