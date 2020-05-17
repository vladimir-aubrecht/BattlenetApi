using System.Threading.Tasks;

using ASoft.BattleNet.Enums;
using ASoft.BattleNet.Extensions;
using ASoft.BattleNet.Starcraft2;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ASoft.Battlenet.CLI
{
    class Program
    {
        private readonly IStarcraft2Client starcraft2Client;
        private readonly ILogger<Program> logger;

        public Program(IStarcraft2Client starcraft2Client, ILogger<Program> logger)
        {
            this.starcraft2Client = starcraft2Client;
            this.logger = logger;
        }

        public async Task RunAsync()
        {
            var achievements = await this.starcraft2Client.GetAchievementsAsync("2");
            //this.logger.LogDebug("{0}", achievements[0]);
        }

        static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging();
            serviceCollection.AddSingleton<Program>();
            serviceCollection.AddBattleNetClient(
                (option) =>
                {
                    option.Region = Region.Eu;
                });

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var program = serviceProvider.GetRequiredService<Program>();

            await program.RunAsync();
        }
    }
}
