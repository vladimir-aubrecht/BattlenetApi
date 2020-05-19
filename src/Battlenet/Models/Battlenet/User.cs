using Newtonsoft.Json;

namespace ASoft.BattleNet.Models.Battlenet
{
    public class User
    {
        public User(string sub, ulong id, string battleTag)
        {
            this.Sub = sub;
            this.Id = id;
            this.BattleTag = battleTag;
        }

        [JsonProperty("sub")]
        public string Sub { get; }

        [JsonProperty("id")]
        public ulong Id { get; }

        [JsonProperty("battletag")]
        public string BattleTag { get; }
    }
}
