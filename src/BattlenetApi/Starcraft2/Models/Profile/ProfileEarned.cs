
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileEarned
    {
        [JsonConstructor]
        public ProfileEarned(int quantity, int startTime)
        {
            Quantity = quantity;
            StartTime = startTime;
        }

        public int Quantity { get; }
        public int StartTime { get; }
    }

}
