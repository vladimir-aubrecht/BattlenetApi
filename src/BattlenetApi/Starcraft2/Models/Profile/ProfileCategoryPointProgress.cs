
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileCategoryPointProgress
    {
        [JsonConstructor]
        public ProfileCategoryPointProgress(long categoryId, int pointsEarned)
        {
            CategoryId = categoryId;
            PointsEarned = pointsEarned;
        }

        public long CategoryId { get; }
        public int PointsEarned { get; }
    }

}
