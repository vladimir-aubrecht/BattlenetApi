﻿using System.Threading.Tasks;

using ASoft.BattleNet;
using ASoft.BattleNet.Battlenet.Extensions;
using ASoft.BattleNet.Extensions;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ASoft.Battlenet.CLI
{
    class Program
    {
        private readonly IBattleNetClient battlenetClient;
        private readonly IOptions<BattleNetClientOption> battleNetClientOption;
        private readonly ILogger<Program> logger;

        public Program(IBattleNetClient battlenetClient, IOptions<BattleNetClientOption> battleNetClientOption, ILogger<Program> logger)
        {
            this.battlenetClient = battlenetClient;
            this.battleNetClientOption = battleNetClientOption;
            this.logger = logger;
        }

        public async Task RunAsync()
        {
            var options = this.battleNetClientOption.Value;

            var token = await this.battlenetClient.AuthenticateByAccessTokenAsync("xxxxx");

            var user = await this.battlenetClient.GetUser(token);
            var players = await this.battlenetClient.GetPlayers(user.Id, token);
            var playerIndex = 1;
            var regionId = players[playerIndex].RegionId;
            var realmId = players[playerIndex].RealmId;
            var profileId = players[playerIndex].ProfileId;

            var grandmasterLeaderboard = await this.battlenetClient.GetGrandmasterLeaderBoardAsync(regionId, token);
            var season = await this.battlenetClient.GetSeasonAsync(regionId, token);
            //var achievements = await this.battlenetClient.GetLegacyAchievementsAsync(regionId, token);
            //var @static = await this.battlenetClient.GetStatic(regionId, token);
            //var metadata = await this.battlenetClient.GetPlayer(regionId, realmId, profileId, token);
            //var profile = await this.battlenetClient.GetProfile(regionId, realmId, profileId, token);
            //var ladderSummary = await this.battlenetClient.GetLadderSummary(regionId, realmId, profileId, token);
            //var ladder = await this.battlenetClient.GetLadder(regionId, realmId, profileId, ladderSummary.AllLadderMemberships[0].LadderId, token);
            //var legacyLadder = await this.battlenetClient.GetLegacyLadder(regionId, ladderSummary.AllLadderMemberships[0].LadderId, token);
            //var legacyLadders = await this.battlenetClient.GetLegacyLadders(regionId, realmId, profileId, token);
            //var legacyProfile = await this.battlenetClient.GetLegacyProfile(regionId, realmId, profileId, token);
            //var legacyMatchHistory = await this.battlenetClient.GetLegacyMatchHistory(regionId, realmId, profileId, token);
            //var legacyRewards = await this.battlenetClient.GetLegacyRewards(regionId, token);
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
