using System;
using MiNET;
using MiNET.Net;
using MiNET.Utils;
using MiNET.Worlds;
using MiNET.Plugins;
using MiNETEssentials;
using MiNET.Plugins.Attributes;
using MiNETCNServer;


namespace MiNETEssentials
{
    /* 
          _Target:__________________________________________________________________________________________State:________
          |1、Player made homes, and server warps.                                                        |____SetHome___|
          |2、Player kits and first join kits                                                             |______________|  
          |3、Easy player to player teleports, including teleport requests.                               |______________|
          |4、Full chat and nickname customisation                                                        |______________|
          |5、Full moderator control, with feature such as muting, jailing and temp banning               |______________|
          |6、Economy support, including shop signs and command costs                                     |______________|
          |7、Full permission based build control, with the ability to block certain items                |______________|
          |8、Core world protection, allowing you to block explosions, fire spread and other catastrophes!|______________|
     *    |9、Something Functions API                                                                     |______________|
    */
    [Plugin(PluginName = "MiNETEssentials", Description = "a basic plugin for MiNET", Author = "MiNETCN", PluginVersion = "0.0.1")]
    public class MiNETEssentials : Plugin
    {
        protected override void OnEnable()
        {
            CMDColor.INFO("MiNETEssentials已加载");
        }
        public override void OnDisable()
        {
            CMDColor.Warning("MiNETEssentials已卸载");
        }
    }
}
