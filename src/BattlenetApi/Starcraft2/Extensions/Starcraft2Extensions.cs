using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ASoft.BattleNet.Starcraft2.Models;

namespace ASoft.BattleNet.Extensions
{
    public static class Starcraft2Extensions
    {
        public static async Task<IList<LadderTeam>> GetGrandmasterLadderAsync(this IBattleNetClient battleNetClient, int regionId)
        {
            var result = await battleNetClient.QueryBlizzardApiAsync<IDictionary<string, IList<LadderTeam>>>(BattleNetClient.BlizzardClientName, $"/sc2/ladder/grandmaster/{regionId}").ConfigureAwait(false);

            if (result.Count != 1)
            {
                return new List<LadderTeam>();
            }

            return result.FirstOrDefault().Value;
        }

        public static Task<Season> GetCurrentSeasonAsync(this IBattleNetClient battleNetClient, int regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<Season>(BattleNetClient.BlizzardClientName, $"/sc2/ladder/season/{regionId}");
        }

        public static Task<AchievementsCollection> GetAchievementsAsync(this IBattleNetClient battleNetClient, int regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<AchievementsCollection>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/data/achievements/{regionId}");
        }

        public static Task<IList<Player>> GetPlayer(this IBattleNetClient battleNetClient, ulong accountId)
        {
            return battleNetClient.QueryBlizzardApiAsync<IList<Player>>(BattleNetClient.BlizzardClientName, $"/sc2/player/{accountId}");
        }
    }
}
