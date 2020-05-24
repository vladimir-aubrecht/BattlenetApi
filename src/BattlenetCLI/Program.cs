using System.Threading.Tasks;

using ASoft.BattleNet;
using ASoft.BattleNet.Battlenet.Extensions;
using ASoft.BattleNet.Extensions;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ASoft.Battlenet.CLI
{
    class Program
    {
        private readonly IBattleNetClient battlenetClient;
        private readonly ILogger<Program> logger;

        public Program(IBattleNetClient battlenetClient, ILogger<Program> logger)
        {
            this.battlenetClient = battlenetClient;
            this.logger = logger;
        }

        public async Task RunAsync()
        {
            //await this.battlenetClient.AuthenticateByAuthorizationCodeAsync("xxx");
            await this.battlenetClient.AuthenticateByAuthorizationFlowAccessTokenAsync("xxx");
            var user = await this.battlenetClient.GetUser();
            var players = await this.battlenetClient.GetPlayers(user.Id);
            var playerIndex = 1;
            var regionId = players[playerIndex].RegionId;
            var realmId = players[playerIndex].RealmId;
            var profileId = players[playerIndex].ProfileId;

            //var grandmasterLeaderboard = await this.battlenetClient.GetGrandmasterLeaderBoardAsync(regionId);
            //var achievements = await this.battlenetClient.GetLegacyAchievementsAsync(regionId);
            //var @static = await this.battlenetClient.GetStatic(regionId);
            //var metadata = await this.battlenetClient.GetPlayer(regionId, realmId, profileId);
            //var profile = await this.battlenetClient.GetProfile(regionId, realmId, profileId);
            var ladderSummary = await this.battlenetClient.GetLadderSummary(regionId, realmId, profileId);
            //var ladder = await this.battlenetClient.GetLadder(regionId, realmId, profileId, ladderSummary.AllLadderMemberships[0].LadderId);
            //var legacyLadder = await this.battlenetClient.GetLegacyLadder(regionId, ladderSummary.AllLadderMemberships[0].LadderId);
            //var legacyLadders = await this.battlenetClient.GetLegacyLadders(regionId, realmId, profileId);
            //var legacyProfile = await this.battlenetClient.GetLegacyProfile(regionId, realmId, profileId);
            //var legacyMatchHistory = await this.battlenetClient.GetLegacyMatchHistory(regionId, realmId, profileId);
            var legacyRewards = await this.battlenetClient.GetLegacyRewards(regionId);
            //this.logger.LogDebug("{0}", achievements[0]);
        }

        static async Task Main(string[] args)
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true)
            .AddCommandLine(args)
            .Build();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging();
            serviceCollection.AddSingleton<Program>();

            serviceCollection.AddBattleNetClient(config);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var program = serviceProvider.GetRequiredService<Program>();

            await program.RunAsync();
        }
    }
}
