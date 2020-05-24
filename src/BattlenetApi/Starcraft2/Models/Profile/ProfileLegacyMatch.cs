
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLegacyMatch
    {
        [JsonConstructor]
        public ProfileLegacyMatch(string map, string type, string decision, string speed, int date)
        {
            Map = map;
            Type = type;
            Decision = decision;
            Speed = speed;
            Date = date;
        }

        public string Map { get; }
        public string Type { get; }
        public string Decision { get; }
        public string Speed { get; }
        public int Date { get; }
    }

}
