using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using ASoft.BattleNet.Battlenet.Models;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;

using Newtonsoft.Json;

namespace ASoft.BattleNet
{
    public class BattleNetClient : IBattleNetClient
    {
        public const string BattlenetClientName = "BattlenetClient";
        public const string BlizzardClientName = "BlizzardClient";

        private readonly IHttpClientFactory httpClientFactory;
        private readonly IOptions<BattleNetClientOption> options;
        private readonly ILogger<BattleNetClient> logger;

        private OAuthToken s2sToken;
        private OAuthToken userToken;

        public BattleNetClient(IHttpClientFactory httpClientFactory, IOptions<BattleNetClientOption> options) : this(httpClientFactory, options, NullLogger<BattleNetClient>.Instance)
        {
        }

        public BattleNetClient(IHttpClientFactory httpClientFactory, IOptions<BattleNetClientOption> options, ILogger<BattleNetClient> logger)
        {
            this.httpClientFactory = httpClientFactory;
            this.options = options;
            this.logger = logger;
        }

        public async Task<TResponseModel> QueryBlizzardApiAsync<TResponseModel>(string clientName, string endpoint)
        {
            var trimmedEndpoint = endpoint.Trim('/');
            logger.LogInformation("Making HTTP request to: {trimmedEndpoint}", trimmedEndpoint);

            var message = new HttpRequestMessage(HttpMethod.Get, trimmedEndpoint);
            message.Headers.Authorization = new AuthenticationHeaderValue(userToken.TokenType, userToken.AccessToken);
            return await MakeRequestAsync<TResponseModel>(clientName, message).ConfigureAwait(false);
        }

        public async Task AuthenticateByAuthorizationCodeAsync(string authorizationCode)
        {
            this.s2sToken = await AuthenticateS2SAsync().ConfigureAwait(false);
            this.userToken = await AuthenticateUserAsync(authorizationCode).ConfigureAwait(false);
        }

        public async Task AuthenticateByAuthorizationFlowAccessTokenAsync(string accessToken)
        {
            this.s2sToken = await AuthenticateS2SAsync().ConfigureAwait(false);
            this.userToken = new OAuthToken(accessToken, "Bearer", long.MaxValue, null, null);
        }

        private async Task<OAuthToken> AuthenticateS2SAsync()
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "/oauth/token") { Content = new StringContent("grant_type=client_credentials&scope=openid wow.profile d3.profile sc2.profile", Encoding.ASCII, "application/x-www-form-urlencoded") };
            return await MakeRequestAsync<OAuthToken>(BattlenetClientName, message).ConfigureAwait(false);
        }

        private async Task<OAuthToken> AuthenticateUserAsync(string code)
        {
            var clientId = this.options.Value.ClientId;
            var secret = this.options.Value.Secret;
            var redirectUri = "https://localhost";
            var message = new HttpRequestMessage(HttpMethod.Post, "/oauth/token") { Content = new StringContent($"code={code}&client_id={clientId}&client_secret={secret}&redirect_uri={redirectUri}&grant_type=authorization_code&scope=openid wow.profile d3.profile sc2.profile", Encoding.ASCII, "application/x-www-form-urlencoded") };
            return await MakeRequestAsync<OAuthToken>(BattlenetClientName, message).ConfigureAwait(false);
        }

        private async Task<TResponse> MakeRequestAsync<TResponse>(string httpClientName, HttpRequestMessage message)
        {
            var httpClient = httpClientFactory.CreateClient(httpClientName);

            var result = await httpClient.SendAsync(message).ConfigureAwait(false);
            logger.LogInformation("Response status code: {statusCode}", result.StatusCode);

            var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<TResponse>(resultContent);
        }
    }
}
