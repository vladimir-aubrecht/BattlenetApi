using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacyRewards
    {
        [JsonConstructor]
        public ProfileLegacyRewards(IList<string> selected, IList<string> earned)
        {
            Selected = selected;
            Earned = earned;
        }

        public IList<string> Selected { get; }
        public IList<string> Earned { get; }
    }

}
