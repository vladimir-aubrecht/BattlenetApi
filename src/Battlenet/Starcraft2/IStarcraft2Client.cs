using System.Threading.Tasks;

using ASoft.BattleNet.Starcraft2.Models;

namespace ASoft.BattleNet.Starcraft2
{
    public interface IStarcraft2Client
    {
        Task<AchievementsCollection> GetAchievementsAsync(string regionId);
    }
}