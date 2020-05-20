using System.Threading.Tasks;

using ASoft.BattleNet.Battlenet.Models;

namespace ASoft.BattleNet.Battlenet.Extensions
{
    public static class BattleNetExtensions
    {

        public static Task<User> GetUser(this IBattleNetClient battleNetClient)
        {
            return battleNetClient.QueryBlizzardApiAsync<User>(BattleNetClient.BattlenetClientName, "/oauth/userinfo");
        }
    }
}
