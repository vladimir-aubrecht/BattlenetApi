using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using ASoft.BattleNet.Models;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;

namespace ASoft.BattleNet
{
    public class BattleNetClient : IBattleNetClient
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly IOptions<BattleNetClientOption> options;
        private readonly ILogger<BattleNetClient> logger;

        public BattleNetClient(IHttpClientFactory httpClientFactory, IOptions<BattleNetClientOption> options) : this(httpClientFactory, options, NullLogger<BattleNetClient>.Instance)
        {
        }

        public BattleNetClient(IHttpClientFactory httpClientFactory, IOptions<BattleNetClientOption> options, ILogger<BattleNetClient> logger)
        {
            this.httpClientFactory = httpClientFactory;
            this.options = options;
            this.logger = logger;

        }

        private async Task<OAuthResult> AuthenticateAsync()
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "/oauth/token") { Content = new StringContent("grant_type=client_credentials", Encoding.ASCII, "application/x-www-form-urlencoded") };
            return await MakeRequestAsync<OAuthResult>(this.options.Value.OAuthClientName, message).ConfigureAwait(false);
        }

        private async Task<TResponse> MakeRequestAsync<TResponse>(string httpClientName, HttpRequestMessage message)
        {
            var httpClient = httpClientFactory.CreateClient(httpClientName);

            var result = await httpClient.SendAsync(message).ConfigureAwait(false);
            logger.LogInformation("Response status code: {statusCode}", result.StatusCode);

            var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<TResponse>(resultContent);
        }

        public async Task<TResponseModel> QueryBlizzardApiAsync<TResponseModel>(string endpoint)
        {
            var trimmedEndpoint = endpoint.Trim('/');
            logger.LogInformation("Making HTTP request to: {trimmedEndpoint}", trimmedEndpoint);

            var oAuth = await AuthenticateAsync().ConfigureAwait(false);

            var message = new HttpRequestMessage(HttpMethod.Get, trimmedEndpoint);
            message.Headers.Authorization = new AuthenticationHeaderValue(oAuth.TokenType, oAuth.AccessToken);

            return await MakeRequestAsync<TResponseModel>(this.options.Value.ApiClientName, message).ConfigureAwait(false);
        }
    }
}
