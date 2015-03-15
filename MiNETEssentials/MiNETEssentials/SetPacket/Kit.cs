﻿using System;
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

namespace MiNETEssentials.SetPacket
{
    //this set a kit when player join the game
    class Kit : Plugin
    {
        [PacketHandler]
        public Package kit(McpeAddPlayer addPlayer)
        {
            return addPlayer;
        }
    }
}
