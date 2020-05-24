using System.Net.Http;
using System.Threading.Tasks;

using ASoft.BattleNet.Battlenet.Models;

namespace ASoft.BattleNet
{
    public interface IBattleNetClient
    {
        Task<TResponseModel> QueryBlizzardApiAsync<TResponseModel>(string endpoint, OAuthToken authToken);

        Task<TResponseModel> QueryBattleNetApiAsync<TResponseModel>(HttpMethod httpMethod, string endpoint, string? payload, string? cookies, OAuthToken? authToken);
    }
}