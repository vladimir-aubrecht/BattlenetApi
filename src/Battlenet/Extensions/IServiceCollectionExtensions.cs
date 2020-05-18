using System;
using System.Net.Http.Headers;
using System.Text;

using ASoft.BattleNet.Starcraft2;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASoft.BattleNet.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBattleNetClient(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var battlenetClientOption = configuration.Get<BattleNetClientOption>();

            serviceCollection.AddHttpClient(battlenetClientOption.ApiClientName, client =>
            {
                client.BaseAddress = new Uri($"https://{battlenetClientOption.Region}.api.blizzard.com");
            });

            serviceCollection.AddHttpClient(battlenetClientOption.OAuthClientName, client =>
            {
                var credentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{battlenetClientOption.ClientId}:{battlenetClientOption.Secret}"));

                client.BaseAddress = new Uri($"https://{battlenetClientOption.Region}.battle.net");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
            });

            serviceCollection.AddSingleton<IStarcraft2Client, Starcraft2Client>();
            return serviceCollection.AddSingleton<IBattleNetClient, BattleNetClient>();
        }
    }
}
