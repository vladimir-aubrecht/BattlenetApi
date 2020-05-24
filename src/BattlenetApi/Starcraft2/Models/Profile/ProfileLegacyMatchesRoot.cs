using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{

    public sealed class ProfileLegacyMatchesRoot
    {
        [JsonConstructor]
        public ProfileLegacyMatchesRoot(IList<ProfileLegacyMatch> matches)
        {
            Matches = matches;
        }

        public IList<ProfileLegacyMatch> Matches { get; }
    }

}
