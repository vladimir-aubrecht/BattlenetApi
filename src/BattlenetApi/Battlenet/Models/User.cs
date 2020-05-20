using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Battlenet.Models
{
    [DebuggerDisplay("Id: {Id} BattleTag: {BattleTag}")]
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
