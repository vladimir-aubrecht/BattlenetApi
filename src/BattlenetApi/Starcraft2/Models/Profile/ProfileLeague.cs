
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileLeague
    {
        [JsonConstructor]
        public ProfileLeague(string leagueName, int timesAchieved)
        {
            LeagueName = leagueName;
            TimesAchieved = timesAchieved;
        }

        public string LeagueName { get; }
        public int TimesAchieved { get; }
    }

}
