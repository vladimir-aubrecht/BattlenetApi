using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using ASoft.BattleNet.Battlenet.Models;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

using Newtonsoft.Json;

namespace ASoft.BattleNet
{
    public class BattleNetClient : IBattleNetClient
    {
        public const string BattlenetClientName = "BattlenetClient";
        public const string BlizzardClientName = "BlizzardClient";

        private readonly IHttpClientFactory httpClientFactory;
        private readonly ILogger<BattleNetClient> logger;

        public BattleNetClient(IHttpClientFactory httpClientFactory) : this(httpClientFactory, NullLogger<BattleNetClient>.Instance)
        {
        }

        public BattleNetClient(IHttpClientFactory httpClientFactory, ILogger<BattleNetClient> logger)
        {
            this.httpClientFactory = httpClientFactory;
            this.logger = logger;
        }

        public async Task<TResponseModel> QueryBlizzardApiAsync<TResponseModel>(string endpoint, OAuthToken authToken)
        {
            var trimmedEndpoint = endpoint.Trim('/');
            logger.LogInformation("Making HTTP request to: {trimmedEndpoint}", trimmedEndpoint);

            var message = new HttpRequestMessage(HttpMethod.Get, trimmedEndpoint);

            if (authToken != null)
            {
                message.Headers.Authorization = new AuthenticationHeaderValue(authToken.TokenType, authToken.AccessToken);
            }

            return await MakeRequestAsync<TResponseModel>(BlizzardClientName, message, null).ConfigureAwait(false);
        }

        public async Task<TResponseModel> QueryBattleNetApiAsync<TResponseModel>(HttpMethod httpMethod, string endpoint, string? payload, string? cookies, OAuthToken? authToken)
        {
            var trimmedEndpoint = endpoint.Trim('/');
            logger.LogInformation("Making HTTP request to: {trimmedEndpoint}", trimmedEndpoint);

            var message = new HttpRequestMessage(httpMethod, trimmedEndpoint);

            if (payload != null)
            {
                message.Content = new StringContent(payload, Encoding.ASCII, "application/x-www-form-urlencoded");
            }

            if (authToken != null)
            {
                message.Headers.Authorization = new AuthenticationHeaderValue(authToken.TokenType, authToken.AccessToken);
            }

            return await MakeRequestAsync<TResponseModel>(BattlenetClientName, message, cookies).ConfigureAwait(false);
        }

        internal async Task<TResponse> MakeRequestAsync<TResponse>(string httpClientName, HttpRequestMessage message, string? cookies)
        {
            var httpClient = httpClientFactory.CreateClient(httpClientName);

            if (cookies != null)
            {
                httpClient.DefaultRequestHeaders.Add("Cookie", cookies);
            }

            var result = await httpClient.SendAsync(message).ConfigureAwait(false);
            logger.LogInformation("Response status code: {statusCode}", result.StatusCode);

            if (result.StatusCode == System.Net.HttpStatusCode.Redirect)
            {
                var newMessage = new HttpRequestMessage(message.Method, result.Headers.Location);
                string newCookies = cookies + "; " + String.Join(';', result.Headers.GetValues("Set-Cookie"));

                return await MakeRequestAsync<TResponse>(httpClientName, newMessage, newCookies).ConfigureAwait(false);
            }

            result.EnsureSuccessStatusCode();

            var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<TResponse>(resultContent);
        }
    }
}
