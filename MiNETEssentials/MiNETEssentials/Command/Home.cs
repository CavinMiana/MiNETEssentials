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

namespace MiNETEssentials.Command
{
    public class Home:Plugin
    {
        [Command(Command = "sethome", Description = "Set a spawn point for level", Usage = "/sethome [target/x,y,z/none]", Permission = "MiNETEssentials.SetHome")]
        public void SetHome(Player player, Level level, string[] args)
        {
            if (args.Length > 0)
            {

            }
            else
            {

            }
        }
    }
}
