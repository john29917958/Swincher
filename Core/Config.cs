using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Swincher.Core
{
    public class Config
    {
        public Dictionary<App, List<Keys[]>> Bindings { get; protected set; }

        public Config()
        {
            Bindings = new Dictionary<App, List<Keys[]>>();
        }

        public static Config Load(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException("Config file cannot be found at path\"" + path + '"');
            }

            string json = File.ReadAllText(path);
            Config config = JsonConvert.DeserializeObject<Config>(json);

            return config;
        }

        public void Save(string path)
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
