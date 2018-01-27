using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Swincher.Distribution.Application;
using Swincher.Distribution.Key;
using Swincher.Distribution.Properties;

namespace Swincher.Distribution.Configuration
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

        [JsonProperty("EnterSwitchingModeKeys", ItemConverterType = typeof(StringEnumConverter))]
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
                c.EnterSwitchingModeKeys = new List<KeyCode> {KeyCode.Alt, KeyCode.S};
                c.Save();
                return c;
            }

            string json = File.ReadAllText(ConfigPath);
            Config config = JsonConvert.DeserializeObject<Config>(json);
            if (config.EnterSwitchingModeKeys.Count == 0)
            {
                config.EnterSwitchingModeKeys = new List<KeyCode> { KeyCode.Alt, KeyCode.S };
                config.Save();
            }

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
