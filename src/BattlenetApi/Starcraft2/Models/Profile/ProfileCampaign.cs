using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileCampaign
    {
        [JsonConstructor]
        public ProfileCampaign(IDictionary<string, string> difficultyCompleted)
        {
            DifficultyCompleted = difficultyCompleted;
        }

        public IDictionary<string, string> DifficultyCompleted { get; }
    }

}
