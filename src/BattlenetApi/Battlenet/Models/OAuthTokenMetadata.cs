using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Battlenet.Models
{

    public class OAuthTokenMetadata
    {
        public OAuthTokenMetadata(long expiration, string username, IList<string> authorities, string clientId, IList<object> scope)
        {
            Expiration = expiration;
            Username = username;
            Authorities = authorities;
            ClientId = clientId;
            Scope = scope;
        }

        [JsonProperty("exp")]
        public long Expiration { get; }

        [JsonProperty("user_name")]
        public string Username { get; }
        public IList<string> Authorities { get; }

        [JsonProperty("client_id")]
        public string ClientId { get; }
        public IList<object> Scope { get; }
    }

}
