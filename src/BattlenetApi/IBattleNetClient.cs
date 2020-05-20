using System.Threading.Tasks;

namespace ASoft.BattleNet
{
    public interface IBattleNetClient
    {
        Task AuthenticateByAuthorizationCodeAsync(string authorizationCode);

        Task AuthenticateByAuthorizationFlowAccessTokenAsync(string accessToken);
        Task<TResponseModel> QueryBlizzardApiAsync<TResponseModel>(string clientName, string endpoint);
    }
}