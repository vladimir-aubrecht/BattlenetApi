using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    [DebuggerDisplay("Id: {Id} DisplayName: {DisplayName} ClanTag: {ClanTag}")]
    public class TeamMember
    {
        public TeamMember(long id, int realm, int region, string displayName, string clanTag, string favoriteRace)
        {
            Id = id;
            Realm = realm;
            Region = region;
            DisplayName = displayName;
            ClanTag = clanTag;
            FavoriteRace = favoriteRace;
        }

        [JsonProperty("id")]
        public long Id { get; }

        [JsonProperty("realm")]
        public int Realm { get; }

        [JsonProperty("region")]
        public int Region { get; }

        [JsonProperty("displayName")]
        public string DisplayName { get; }

        [JsonProperty("clanTag")]
        public string ClanTag { get; }

        [JsonProperty("favoriteRace")]
        public string FavoriteRace { get; }
    }
}
