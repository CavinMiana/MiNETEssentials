using System;
using MiNET;
using MiNET.Net;
using MiNET.Utils;
using MiNET.Worlds;
using MiNET.Plugins;
using MiNETEssentials;
using MiNET.Plugins.Attributes;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MiNETEssentials.SetPacket
{
    //this is show player join game in the console
    public class PlayerJoin : Plugin
    {
        [PacketHandler]
        public Package PlayerJoinPacket(McpeLogin login, Player player)
        {
            if (!MiNETEssentials.playerConfig.ContainsKey(login.username))
            {
                JObject obj = new JObject();
                obj["username"] = login.username;
                obj["lastjoin"] = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

                MiNETEssentials.playerConfig.Add(login.username, obj);

                MiNETEssentials.SavePlayerConfig();

                MiNETEssentials.Log.Info(login.username + " has joined for the first time!");
            }
            else
                MiNETEssentials.Log.Info(login.username + " has joined! Last joined: " + (string)MiNETEssentials.playerConfig[login.username]["lastjoin"]);

            return login;
        }
    }
}
