using System.Threading.Tasks;

using ASoft.BattleNet.Starcraft2.Models;

namespace ASoft.BattleNet.Starcraft2
{
    public class Starcraft2Client : IStarcraft2Client
    {
        private readonly IBattleNetClient battleNetClient;

        public Starcraft2Client(IBattleNetClient battleNetClient)
        {
            this.battleNetClient = battleNetClient;
        }

        public Task<AchievementsCollection> GetAchievementsAsync(string regionId)
        {
            return this.battleNetClient.QueryBlizzardApiAsync<AchievementsCollection>($"/sc2/legacy/data/achievements/{regionId}");
        }
    }
}
