using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    public sealed class LadderRanks
    {
        [JsonConstructor]
        public LadderRanks(int rank, int mmr, int bonusPool)
        {
            Rank = rank;
            Mmr = mmr;
            BonusPool = bonusPool;
        }

        public int Rank { get; }
        public int Mmr { get; }
        public int BonusPool { get; }
    }
}
