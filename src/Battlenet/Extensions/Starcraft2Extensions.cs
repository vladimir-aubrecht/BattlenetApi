using System.Threading.Tasks;

using ASoft.BattleNet.Models.Battlenet;
using ASoft.BattleNet.Models.Starcraft2;

namespace ASoft.BattleNet.Extensions
{
    public static class Starcraft2Extensions
    {
        public static Task<AchievementsCollection> GetAchievementsAsync(this IBattleNetClient battleNetClient, string regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<AchievementsCollection>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/data/achievements/{regionId}");
        }

        public static Task<Player> GetPlayer(this IBattleNetClient battleNetClient, ulong accountId)
        {
            return battleNetClient.QueryBlizzardApiAsync<Player>(BattleNetClient.BlizzardClientName, $"/sc2/player/{accountId}");
        }
    }
}
