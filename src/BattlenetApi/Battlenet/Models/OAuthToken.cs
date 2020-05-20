using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Battlenet.Models
{
    [DebuggerDisplay("AccessToken: {AccessToken}")]
    internal class OAuthToken
    {
        public OAuthToken(string accessToken, string tokenType, long expiresIn, string? scope, string? idtoken)
        {
            AccessToken = accessToken;
            TokenType = tokenType;
            ExpiresIn = expiresIn;
            Scope = scope;
            IdToken = idtoken;
        }

        [JsonProperty("access_token")]
        public string AccessToken { get; }

        [JsonProperty("token_type")]
        public string TokenType { get; }

        [JsonProperty("expires_in")]
        public long ExpiresIn { get; }

        [JsonProperty("scope")]
        public string? Scope { get; }

        [JsonProperty("id_token")]
        public string? IdToken { get; }
    }
}
