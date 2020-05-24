using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacyPoints
    {
        [JsonConstructor]
        public ProfileLegacyPoints(int totalPoints, IDictionary<long, int> categoryPoints)
        {
            TotalPoints = totalPoints;
            CategoryPoints = categoryPoints;
        }

        public int TotalPoints { get; }
        public IDictionary<long, int> CategoryPoints { get; }
    }

}
