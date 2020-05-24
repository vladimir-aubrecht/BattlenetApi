using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    public sealed class LadderCharacter
    {
        [JsonConstructor]
        public LadderCharacter(long id, int realm, int region, string displayName, string clanName, string clanTag, string profilePath)
        {
            Id = id;
            Realm = realm;
            Region = region;
            DisplayName = displayName;
            ClanName = clanName;
            ClanTag = clanTag;
            ProfilePath = profilePath;
        }

        public long Id { get; set; }
        public int Realm { get; set; }
        public int Region { get; set; }
        public string DisplayName { get; set; }
        public string ClanName { get; set; }
        public string ClanTag { get; set; }
        public string ProfilePath { get; set; }
    }

}
