
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacyStat
    {
        [JsonConstructor]
        public ProfileLegacyStat(string type, int wins, int games)
        {
            Type = type;
            Wins = wins;
            Games = games;
        }

        public string Type { get; }
        public int Wins { get; }
        public int Games { get; }
    }

}
