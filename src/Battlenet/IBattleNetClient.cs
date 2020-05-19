using System.Threading.Tasks;

namespace ASoft.BattleNet
{
    public interface IBattleNetClient
    {
        Task<TResponseModel> QueryBlizzardApiAsync<TResponseModel>(string clientName, string endpoint);
    }
}