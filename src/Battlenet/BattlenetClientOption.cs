
using System.Diagnostics;

using ASoft.BattleNet.Enums;

namespace ASoft.BattleNet
{
    [DebuggerDisplay("Region: {Region} ClientId: {ClientId}")]
    public class BattleNetClientOption
    {
        public string ClientId { get; set; }
        public string Secret { get; set; }

        public Region Region { get; set; }

        public string ApiClientName { get; } = "BattleNetApi";
        public string OAuthClientName { get; } = "BattleNetOAuth";
    }
}