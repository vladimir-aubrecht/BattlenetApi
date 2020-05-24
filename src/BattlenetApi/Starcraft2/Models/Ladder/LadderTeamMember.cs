using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Ladder
{
    [DebuggerDisplay("Id: {Id} DisplayName: {DisplayName} ClanTag: {ClanTag}")]
    public sealed class LadderTeamMember
    {
        [JsonConstructor]
        public LadderTeamMember(long id, int realm, int region, string displayName, string clanTag, string favoriteRace)
        {
            Id = id;
            Realm = realm;
            Region = region;
            DisplayName = displayName;
            ClanTag = clanTag;
            FavoriteRace = favoriteRace;
        }

        public long Id { get; }
        public int Realm { get; }
        public int Region { get; }
        public string DisplayName { get; }
        public string ClanTag { get; }
        public string FavoriteRace { get; }
    }
}
