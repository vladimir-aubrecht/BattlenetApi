using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ASoft.BattleNet.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddBattleNetClient(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var battlenetClientOption = configuration.Get<BattleNetClientOption>();

            // IOptions needs parameterless ctor as of now as we need to allow null values ... :-/
            _ = battlenetClientOption.ClientId ?? throw new ArgumentNullException(nameof(battlenetClientOption.ClientId));
            _ = battlenetClientOption.Secret ?? throw new ArgumentNullException(nameof(battlenetClientOption.Secret));

            serviceCollection.AddHttpClient(BattleNetClient.BlizzardClientName, client =>
            {
                client.BaseAddress = new Uri($"https://{battlenetClientOption.Region}.api.blizzard.com");
            });

            serviceCollection.AddHttpClient(BattleNetClient.BattlenetClientName, client =>
            {
                var credentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{battlenetClientOption.ClientId}:{battlenetClientOption.Secret}"));

                client.BaseAddress = new Uri($"https://{battlenetClientOption.Region}.battle.net");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
            }).ConfigurePrimaryHttpMessageHandler((handler) =>
            {
                return new HttpClientHandler()
                {
                    AllowAutoRedirect = true,
                    MaxAutomaticRedirections = 20,
                    UseCookies = false
                };
            });

            serviceCollection.AddSingleton((sp) => Options.Create(battlenetClientOption));
            return serviceCollection.AddSingleton<IBattleNetClient, BattleNetClient>();
        }
    }
}
