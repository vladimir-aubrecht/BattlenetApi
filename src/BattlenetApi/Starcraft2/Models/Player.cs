using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    [DebuggerDisplay("Name: {Name} ProfileId: {ProfileId} RegionId: {RegionId}")]
    public class Player
    {
        public Player(string name, string profileUrl, string avatarUrl, string profileId, int regionId, int realmId)
        {
            Name = name;
            ProfileUrl = profileUrl;
            AvatarUrl = avatarUrl;
            ProfileId = profileId;
            RegionId = regionId;
            RealmId = realmId;
        }

        [JsonProperty("name")]
        public string Name { get; }
        [JsonProperty("profileUrl")]
        public string ProfileUrl { get; }
        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; }
        [JsonProperty("profileId")]
        public string ProfileId { get; }
        [JsonProperty("regionId")]
        public int RegionId { get; }
        [JsonProperty("realmId")]
        public int RealmId { get; }
    }
}
