using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Newtonsoft.Json;
using Swincher.Core.Properties;

namespace Swincher.Core
{
    public class Config
    {
        public const string FileName = "config.json";

        public static string ConfigPath
        {
            get
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(appDataPath, Resources.AppName, FileName);
            }
        }
        
        public List<AppBinding> Bindings { get; protected set; }

        public Config()
        {
            Bindings = new List<AppBinding>();
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
