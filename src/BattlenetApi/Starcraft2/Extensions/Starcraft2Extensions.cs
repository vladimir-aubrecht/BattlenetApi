using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ASoft.BattleNet.Battlenet.Models;
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
        public static Task<GrandmasterLeaderboardRoot> GetGrandmasterLeaderBoardAsync(this IBattleNetClient battleNetClient, int regionId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<GrandmasterLeaderboardRoot>($"/sc2/ladder/grandmaster/{regionId}", authToken);
        }

        public static Task<Season> GetSeasonAsync(this IBattleNetClient battleNetClient, int regionId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<Season>($"/sc2/ladder/season/{regionId}", authToken);
        }

        public static Task<IList<Player>> GetPlayers(this IBattleNetClient battleNetClient, ulong accountId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<IList<Player>>($"/sc2/player/{accountId}", authToken);
        }

        public static Task<Player> GetPlayer(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<Player>($"/sc2/metadata/profile/{regionId}/{realmId}/{profileId}", authToken);
        }

        public static Task<StaticRoot> GetStatic(this IBattleNetClient battleNetClient, int regionId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<StaticRoot>($"/sc2/static/profile/{regionId}", authToken);
        }

        public static Task<Profile> GetProfile(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<Profile>($"/sc2/profile/{regionId}/{realmId}/{profileId}", authToken);
        }

        public static Task<LadderSummaryRoot> GetLadderSummary(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<LadderSummaryRoot>($"/sc2/profile/{regionId}/{realmId}/{profileId}/ladder/summary", authToken);
        }

        public static Task<LadderRoot> GetLadder(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId, long ladderId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<LadderRoot>($"/sc2/profile/{regionId}/{realmId}/{profileId}/ladder/{ladderId}", authToken);
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<AchievementsRoot> GetLegacyAchievementsAsync(this IBattleNetClient battleNetClient, int regionId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<AchievementsRoot>($"/sc2/legacy/data/achievements/{regionId}", authToken);
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<LegacyRewardsRoot> GetLegacyRewards(this IBattleNetClient battleNetClient, int regionId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<LegacyRewardsRoot>($"/sc2/legacy/data/rewards/{regionId}", authToken);
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<ProfileLegacyMatchesRoot> GetLegacyMatchHistory(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<ProfileLegacyMatchesRoot>($"/sc2/legacy/profile/{regionId}/{realmId}/{profileId}/matches", authToken);
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<LaddersLegacyRoot> GetLegacyLadders(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<LaddersLegacyRoot>($"/sc2/legacy/profile/{regionId}/{realmId}/{profileId}/ladders", authToken);
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<ProfileLegacyRoot> GetLegacyProfile(this IBattleNetClient battleNetClient, int regionId, int realmId, long profileId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<ProfileLegacyRoot>($"/sc2/legacy/profile/{regionId}/{realmId}/{profileId}", authToken);
        }

        [Obsolete("This API is obsolete by Blizzard.")]
        public static Task<LadderLegacyRoot> GetLegacyLadder(this IBattleNetClient battleNetClient, int regionId, long ladderId, OAuthToken authToken)
        {
            return battleNetClient.QueryBlizzardApiAsync<LadderLegacyRoot>($"/sc2/legacy/ladder/{regionId}/{ladderId}", authToken);
        }
    }
}
