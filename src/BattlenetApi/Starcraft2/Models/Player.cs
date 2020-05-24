using System;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    [DebuggerDisplay("Name: {Name} ProfileId: {ProfileId} RegionId: {RegionId}")]
    public sealed class Player
    {
        [JsonConstructor]
        public Player(string name, Uri profileUrl, Uri avatarUrl, long profileId, int regionId, int realmId)
        {
            Name = name;
            ProfileUrl = profileUrl;
            AvatarUrl = avatarUrl;
            ProfileId = profileId;
            RegionId = regionId;
            RealmId = realmId;
        }

        public string Name { get; }
        public Uri ProfileUrl { get; }
        public Uri AvatarUrl { get; }
        public long ProfileId { get; }
        public int RegionId { get; }
        public int RealmId { get; }
    }
}
