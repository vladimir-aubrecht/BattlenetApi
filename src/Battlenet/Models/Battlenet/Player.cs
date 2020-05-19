using Newtonsoft.Json;

namespace ASoft.BattleNet.Models.Battlenet
{
    public class Player
    {
        public Player()
        {

        }

        [JsonProperty("name")]
        public string Name { get; }
        [JsonProperty("profile_url")]
        public string ProfileUrl { get; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; }
        [JsonProperty("profile_id")]
        public string ProfileId { get; }
        [JsonProperty("region_id")]
        public int RegionId { get; }
        [JsonProperty("realm_id")]
        public int RealmId { get; }
    }
}
