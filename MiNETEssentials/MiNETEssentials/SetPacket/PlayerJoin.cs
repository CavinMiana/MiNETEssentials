using System;
using MiNET;
using MiNET.Net;
using MiNET.Utils;
using MiNET.Worlds;
using MiNET.Plugins;
using MiNETEssentials;
using MiNET.Plugins.Attributes;
using MiNETCNServer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiNETEssentials.Functions
{
    public class PlayerJoin : Plugin
    {
        [PacketHandler]
        public Package playerjoin(Player player,McpeLogin login)
        {
            CMDColor.INFO("玩家:" + login.username + ",加入了游戏,IP:" + player.EndPoint.Address);
            return login;
        }
        public Package kit(McpeAddPlayer adp,Player player)
        {
            if (adp.username == player.Username)
            {
                
            }
            return adp;
        }
    }
}
