
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacyCampaign
    {
        [JsonConstructor]
        public ProfileLegacyCampaign(string wol, string hots, string lotv)
        {
            Wol = wol;
            Hots = hots;
            Lotv = lotv;
        }

        public string Wol { get; }
        public string Hots { get; }
        public string Lotv { get; }
    }

}
