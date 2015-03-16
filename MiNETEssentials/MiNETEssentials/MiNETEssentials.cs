using System;
using MiNET;
using MiNET.Net;
using MiNET.Utils;
using MiNET.Worlds;
using MiNET.Plugins;
using MiNETEssentials;
using MiNET.Plugins.Attributes;
using MiNETCNServer;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MiNETEssentials
{
    [Plugin(PluginName = "MiNETEssentials", Description = "a basic plugin for MiNET", Author = "MiNETCN", PluginVersion = "0.0.1")]
    public class MiNETEssentials : Plugin
    {
        public static JObject config;
        public static Dictionary<string, JObject> playerConfig = new Dictionary<string, JObject>();

        public static void SavePlayerConfig()
        {
            var obj = new JArray();
            foreach(var ply in playerConfig.Select(x => x.Value))
            {
                obj.Add(ply);
            }
            File.WriteAllText("Plugins/minetessentials/players.json", obj.ToString());
        }

        protected override void OnEnable()
        {
            CMDColor.INFO("MiNETEssentials OnEnable");

            if (!Directory.Exists("Plugins/minetessentials"))
                Directory.CreateDirectory("Plugins/minetessentials");

            if (!File.Exists("Plugins/minetessentials/config.json"))
                File.WriteAllText("Plugins/minetessentials/config.json", "{}");

            config = JObject.Parse(File.ReadAllText("Plugins/minetessentials/config.json"));

            if (!File.Exists("Plugins/minetessentials/players.json"))
                File.WriteAllText("Plugins/minetessentials/players.json", "[]");


            foreach(JObject ply in JArray.Parse(File.ReadAllText("Plugins/minetessentials/players.json"))) {
                playerConfig.Add((string)ply["username"], ply);
            }
            
        }
        public override void OnDisable()
        {
            CMDColor.Warning("MiNETEssentials Disable");
        }
    }
}
