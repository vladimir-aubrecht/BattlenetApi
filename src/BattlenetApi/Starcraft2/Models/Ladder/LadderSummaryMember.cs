using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    public sealed class LadderSummaryMember
    {
        [JsonConstructor]
        public LadderSummaryMember(string favoriteRace, string name, long playerId, int region)
        {
            FavoriteRace = favoriteRace;
            Name = name;
            PlayerId = playerId;
            Region = region;
        }

        public string FavoriteRace { get; }
        public string Name { get; }
        public long PlayerId { get; }
        public int Region { get; }
    }
}
