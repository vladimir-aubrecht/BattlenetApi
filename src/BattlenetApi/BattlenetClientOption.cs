
using System;
using System.Diagnostics;

using ASoft.BattleNet.Enums;

namespace ASoft.BattleNet
{
    [DebuggerDisplay("Region: {Region} ClientId: {ClientId} Region: {Region} RedirectUrl: {RedirectUrl}")]
    public class BattleNetClientOption
    {
        public string? ClientId { get; set; }
        public string? Secret { get; set; }

        public Region Region { get; set; }

        public Uri RedirectUrl { get; set; }
    }
}