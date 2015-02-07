using System;
using MiNET.API;
using MiNET.PluginSystem.Attributes;


namespace MiNETEssentials
{
    [Plugin("MiNETEssentials", "A Essentials Plugin for MiNET", "Build 1", "MiNETCN")]
    
    public class MiNETEssentials : MiNETPlugin
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
        */

        public override void OnEnable()
        {
            Console.WriteLine("Succesfully enabled MiNETEssentials.....");
        }
        public override void OnDisable()
        {
            Console.WriteLine("Succesfully disabled MiNETEssentials.....");
        }
    }
}
