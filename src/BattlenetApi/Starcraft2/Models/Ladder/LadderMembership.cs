using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    public sealed class LadderMembership
    {
        [JsonConstructor]
        public LadderMembership(long ladderId, string localizedGameMode, int? rank)
        {
            LadderId = ladderId;
            LocalizedGameMode = localizedGameMode;
            Rank = rank;
        }

        public long LadderId { get; }
        public string LocalizedGameMode { get; }
        public int? Rank { get; }
    }
}
