using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ASoft.BattleNet.Starcraft2.Models;

namespace ASoft.BattleNet.Extensions
{
    public static class Starcraft2Extensions
    {
        public static async Task<IList<LadderTeam>> GetGrandmasterLeaderBoardAsync(this IBattleNetClient battleNetClient, int regionId)
        {
            var result = await battleNetClient.QueryBlizzardApiAsync<IDictionary<string, IList<LadderTeam>>>(BattleNetClient.BlizzardClientName, $"/sc2/ladder/grandmaster/{regionId}").ConfigureAwait(false);

            if (result.Count != 1)
            {
                return new List<LadderTeam>();
            }

            return result.FirstOrDefault().Value;
        }

        public static Task<Season> GetSeasonAsync(this IBattleNetClient battleNetClient, int regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<Season>(BattleNetClient.BlizzardClientName, $"/sc2/ladder/season/{regionId}");
        }

        public static Task<IList<Player>> GetPlayer(this IBattleNetClient battleNetClient, ulong accountId)
        {
            return battleNetClient.QueryBlizzardApiAsync<IList<Player>>(BattleNetClient.BlizzardClientName, $"/sc2/player/{accountId}");
        }

        public static Task<object> GetStatic(this IBattleNetClient battleNetClient, int regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<object>(BattleNetClient.BlizzardClientName, $"/sc2/static/profile/{regionId}");
        }

        public static Task<object> GetMetadata(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<object>(BattleNetClient.BlizzardClientName, $"/sc2/metadata/profile/{regionId}/{realmId}/{profileId}");
        }

        public static Task<object> GetProfile(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<object>(BattleNetClient.BlizzardClientName, $"/sc2/profile/{regionId}/{realmId}/{profileId}");
        }

        public static Task<object> GetLadderSummary(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<object>(BattleNetClient.BlizzardClientName, $"/sc2/profile/{regionId}/{realmId}/{profileId}/ladder/summary");
        }

        public static Task<object> GetLadder(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId, long ladderId)
        {
            return battleNetClient.QueryBlizzardApiAsync<object>(BattleNetClient.BlizzardClientName, $"/sc2/profile/{regionId}/{realmId}/{profileId}/ladder/{ladderId}");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<AchievementsCollection> GetLegacyAchievementsAsync(this IBattleNetClient battleNetClient, int regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<AchievementsCollection>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/data/achievements/{regionId}");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<object> GetLegacyRewards(this IBattleNetClient battleNetClient, int regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<object>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/data/rewards/{regionId}");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<object> GetLegacyMatchHistory(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<object>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/profile/{regionId}/{realmId}/{profileId}/matches");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<object> GetLegacyLadders(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<object>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/profile/{regionId}/{realmId}/{profileId}/ladders");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<object> GetLegacyProfile(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<object>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/profile/{regionId}/{realmId}/{profileId}");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<object> GetLegacyLadder(this IBattleNetClient battleNetClient, int regionId, long ladderId)
        {
            return battleNetClient.QueryBlizzardApiAsync<object>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/ladder/{regionId}/{ladderId}");
        }
    }
}
