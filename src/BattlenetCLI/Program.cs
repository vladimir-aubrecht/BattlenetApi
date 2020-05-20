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
            var user = await this.battlenetClient.GetUser();
            var player = await this.battlenetClient.GetPlayer(user.Id);
            var regionId = player[0].RegionId;
            var realmId = player[0].RealmId;
            //var achievements = await this.battlenetClient.GetAchievementsAsync(regionId);
            var x = await this.battlenetClient.GetStatic(regionId);
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
