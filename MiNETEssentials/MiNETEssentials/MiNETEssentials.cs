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
    [Plugin(PluginName = "MiNETEssentials", Description = "a basic plugin for MiNET", Author = "MiNETCN", PluginVersion = "0.0.1")]
    public class MiNETEssentials : Plugin
    {
        protected override void OnEnable()
        {
            CMDColor.INFO("MiNETEssentials OnEnable");
        }
        public override void OnDisable()
        {
            CMDColor.Warning("MiNETEssentials Disable");
        }
    }
}
