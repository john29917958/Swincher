using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using Swincher.Core.Properties;

namespace Swincher.Core
{
    public class Config
    {
        [JsonIgnore]
        public const string FileName = "config.json";

        [JsonIgnore]
        public static string ConfigPath
        {
            get
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(appDataPath, Resources.AppName, FileName);
            }
        }
        
        public bool AutoActivate { get; set; }
        public bool AutoOpenApps { get; set; }
        public BindingList<AppBinding> Bindings { get; set; }
        public List<KeyCode> EnterSwitchingModeKeys { get; set; }
        public bool StartWithOs { get; set; }

        public Config()
        {
            Bindings = new BindingList<AppBinding>();
            EnterSwitchingModeKeys = new List<KeyCode>();
        }

        public static Config Load()
        {
            if (!File.Exists(ConfigPath))
            {
                Config c = new Config();
                c.Save();
                return c;
            }

            string json = File.ReadAllText(ConfigPath);
            Config config = JsonConvert.DeserializeObject<Config>(json);

            return config;
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            string dir = Path.GetDirectoryName(ConfigPath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            File.WriteAllText(ConfigPath, json);
        }
    }
}
