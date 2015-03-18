﻿using System;
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

namespace MiNETEssentials.SetPacket
{
    //Full chat and nickname customisation 
    public class Message : Plugin
    {
        [PacketHandler]
        public Package message(McpeMessage message, Player player)
        {
            MiNETEssentials.Log.Info("<" + player.Username + ">:" + message.message);
            MiNETEssentials.SavePlayerConfig();
            return message;
        }
    }
}
