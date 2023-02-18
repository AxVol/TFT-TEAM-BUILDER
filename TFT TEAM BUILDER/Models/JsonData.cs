using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TFT_TEAM_BUILDER.Models
{
    class JsonData
    {
        public static List<Champions> GetChampions()
        {
            using (StreamReader reader = new StreamReader("Content\\champions\\champions.json"))
            {
                string json = reader.ReadToEnd();

                var root = JsonConvert.DeserializeObject<Dictionary<string, Champions>>(json);

                var champions = new List<Champions>(root.Values);

                return champions;
            }
        }
        public static List<Traits> GetTraits()
        {
            using (StreamReader reader = new StreamReader("Content\\traits\\traits.json"))
            {
                string json = reader.ReadToEnd();

                var root = JsonConvert.DeserializeObject<Dictionary<string, Traits>>(json);

                var traits = new List<Traits>(root.Values);

                return traits;
            }
        }
        public static List<Items> GetItems()
        {
            using (StreamReader reader = new StreamReader("Content\\items\\items.json"))
            {
                string json = reader.ReadToEnd();

                var root = JsonConvert.DeserializeObject<Dictionary<string, Items>>(json);

                var items = new List<Items>(root.Values);

                return items;
            }
        }
    }
}
