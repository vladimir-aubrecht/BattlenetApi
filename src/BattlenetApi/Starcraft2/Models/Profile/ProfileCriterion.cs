
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileCriterion
    {
        [JsonConstructor]
        public ProfileCriterion(string criterionId, ProfileEarned earned)
        {
            CriterionId = criterionId;
            Earned = earned;
        }

        public string CriterionId { get; }
        public ProfileEarned Earned { get; }
    }

}
