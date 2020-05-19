using System.Threading.Tasks;

using ASoft.BattleNet.Models.Battlenet;

namespace ASoft.BattleNet.Extensions
{
    public static class BattleNetExtensions
    {

        public static Task<User> GetUser(this IBattleNetClient battleNetClient)
        {
            return battleNetClient.QueryBlizzardApiAsync<User>(BattleNetClient.BattlenetClientName, "/oauth/userinfo");
        }
    }
}
