using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

using ASoft.BattleNet.Battlenet.Models;

namespace ASoft.BattleNet.Battlenet.Extensions
{
    public static class BattleNetExtensions
    {

        public static Task<User> GetUser(this IBattleNetClient battleNetClient, OAuthToken authToken)
        {
            return battleNetClient.QueryBattleNetApiAsync<User>(HttpMethod.Get, "/oauth/userinfo", null, null, authToken);
        }

        public static Task<OAuthToken> AuthenticateByClientCredentialsAsync(this IBattleNetClient battleNetClient)
        {
            return battleNetClient.QueryBattleNetApiAsync<OAuthToken>(HttpMethod.Post, "/oauth/token", "grant_type=client_credentials&scope=openid wow.profile d3.profile sc2.profile", null, null);
        }

        public static Task<OAuthToken> AuthenticateByUserCredentialsAsync(this IBattleNetClient battleNetClient, string clientId, string secret, string code, Uri redirectUrl)
        {
            return battleNetClient.QueryBattleNetApiAsync<OAuthToken>(HttpMethod.Post, "/oauth/token", $"code={code}&client_id={clientId}&client_secret={secret}&redirect_uri={redirectUrl}&grant_type=authorization_code&scope=openid wow.profile d3.profile sc2.profile", null, null);
        }

        public static Task<OAuthToken> AuthenticateByCookieAsync(this IBattleNetClient battleNetClient, string clientId, string cookies, Uri redirectUrl)
        {
            var encodedUrlRedirect = HttpUtility.UrlEncode(redirectUrl.ToString());
            return battleNetClient.QueryBattleNetApiAsync<OAuthToken>(HttpMethod.Get, $"/oauth/authorize?access_type=online&client_id={clientId}&redirect_uri={encodedUrlRedirect}&response_type=code&state=", null, cookies, null);
        }

        public static async Task<OAuthToken> AuthenticateByAccessTokenAsync(this IBattleNetClient battleNetClient, string accessToken)
        {
            var tokenMetadata = await battleNetClient.VerifyTokenAsync(accessToken).ConfigureAwait(false);
            return new OAuthToken(accessToken, "Bearer", tokenMetadata.Expiration, null, null);
        }

        public static Task<OAuthTokenMetadata> VerifyTokenAsync(this IBattleNetClient battleNetClient, string accessToken)
        {
            return battleNetClient.QueryBattleNetApiAsync<OAuthTokenMetadata>(HttpMethod.Post, "/oauth/check_token", $"token={accessToken}", null, null);
        }
    }
}
