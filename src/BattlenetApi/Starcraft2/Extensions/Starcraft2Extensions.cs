using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ASoft.BattleNet.Starcraft2.Models;
using ASoft.BattleNet.Starcraft2.Models.Achievements;
using ASoft.BattleNet.Starcraft2.Models.Ladder;
using ASoft.BattleNet.Starcraft2.Models.Profile;
using ASoft.BattleNet.Starcraft2.Models.Rewards;
using ASoft.BattleNet.Starcraft2.Models.Static;

namespace ASoft.BattleNet.Extensions
{
    public static class Starcraft2Extensions
    {
        public static async Task<GrandmasterLeaderboardRoot> GetGrandmasterLeaderBoardAsync(this IBattleNetClient battleNetClient, int regionId)
        {
            return await battleNetClient.QueryBlizzardApiAsync<GrandmasterLeaderboardRoot>(BattleNetClient.BlizzardClientName, $"/sc2/ladder/grandmaster/{regionId}").ConfigureAwait(false);
        }

        public static Task<Season> GetSeasonAsync(this IBattleNetClient battleNetClient, int regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<Season>(BattleNetClient.BlizzardClientName, $"/sc2/ladder/season/{regionId}");
        }

        public static Task<IList<Player>> GetPlayers(this IBattleNetClient battleNetClient, ulong accountId)
        {
            return battleNetClient.QueryBlizzardApiAsync<IList<Player>>(BattleNetClient.BlizzardClientName, $"/sc2/player/{accountId}");
        }

        public static Task<Player> GetPlayer(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<Player>(BattleNetClient.BlizzardClientName, $"/sc2/metadata/profile/{regionId}/{realmId}/{profileId}");
        }

        public static Task<StaticRoot> GetStatic(this IBattleNetClient battleNetClient, int regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<StaticRoot>(BattleNetClient.BlizzardClientName, $"/sc2/static/profile/{regionId}");
        }

        public static Task<Profile> GetProfile(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<Profile>(BattleNetClient.BlizzardClientName, $"/sc2/profile/{regionId}/{realmId}/{profileId}");
        }

        public static Task<LadderSummaryRoot> GetLadderSummary(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<LadderSummaryRoot>(BattleNetClient.BlizzardClientName, $"/sc2/profile/{regionId}/{realmId}/{profileId}/ladder/summary");
        }

        public static Task<LadderRoot> GetLadder(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId, long ladderId)
        {
            return battleNetClient.QueryBlizzardApiAsync<LadderRoot>(BattleNetClient.BlizzardClientName, $"/sc2/profile/{regionId}/{realmId}/{profileId}/ladder/{ladderId}");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<AchievementsRoot> GetLegacyAchievementsAsync(this IBattleNetClient battleNetClient, int regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<AchievementsRoot>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/data/achievements/{regionId}");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<LegacyRewardsRoot> GetLegacyRewards(this IBattleNetClient battleNetClient, int regionId)
        {
            return battleNetClient.QueryBlizzardApiAsync<LegacyRewardsRoot>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/data/rewards/{regionId}");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<ProfileLegacyMatchesRoot> GetLegacyMatchHistory(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<ProfileLegacyMatchesRoot>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/profile/{regionId}/{realmId}/{profileId}/matches");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<LaddersLegacyRoot> GetLegacyLadders(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<LaddersLegacyRoot>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/profile/{regionId}/{realmId}/{profileId}/ladders");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<ProfileLegacyRoot> GetLegacyProfile(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId)
        {
            return battleNetClient.QueryBlizzardApiAsync<ProfileLegacyRoot>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/profile/{regionId}/{realmId}/{profileId}");
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<LadderLegacyRoot> GetLegacyLadder(this IBattleNetClient battleNetClient, int regionId, long ladderId)
        {
            return battleNetClient.QueryBlizzardApiAsync<LadderLegacyRoot>(BattleNetClient.BlizzardClientName, $"/sc2/legacy/ladder/{regionId}/{ladderId}");
        }
    }
}
