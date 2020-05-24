using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    public sealed class LadderMember
    {
        [JsonConstructor]
        public LadderMember(LadderCharacter character, int joinTimestamp, int points, int wins, int losses, int highestRank, int previousRank, string favoriteRaceP1, string favoriteRaceP2)
        {
            Character = character;
            JoinTimestamp = joinTimestamp;
            Points = points;
            Wins = wins;
            Losses = losses;
            HighestRank = highestRank;
            PreviousRank = previousRank;
            FavoriteRaceP1 = favoriteRaceP1;
            FavoriteRaceP2 = favoriteRaceP2;
        }

        public LadderCharacter Character { get; set; }
        public int JoinTimestamp { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int HighestRank { get; set; }
        public int PreviousRank { get; set; }
        public string FavoriteRaceP1 { get; set; }
        public string FavoriteRaceP2 { get; set; }
    }

}
