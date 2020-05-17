using System;

using ASoft.BattleNet.Starcraft2;

using Microsoft.Extensions.DependencyInjection;

namespace ASoft.BattleNet.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBattleNetClient(this IServiceCollection serviceCollection, Action<BattleNetClientOption> options)
        {
            var overridenOptions = new BattleNetClientOption();
            options.Invoke(overridenOptions);
            serviceCollection.Configure(options);

            serviceCollection.AddHttpClient(overridenOptions.ApiClientName, client =>
            {
                client.BaseAddress = new Uri($"https://{overridenOptions.Region}.api.blizzard.com");
            });

            serviceCollection.AddHttpClient(overridenOptions.OAuthClientName, client =>
            {
                client.BaseAddress = new Uri($"https://{overridenOptions.Region}.battle.net");
            });

            serviceCollection.AddSingleton<IStarcraft2Client, Starcraft2Client>();
            return serviceCollection.AddSingleton<IBattleNetClient, BattleNetClient>();
        }
    }
}
