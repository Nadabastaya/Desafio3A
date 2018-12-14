using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StarWars3A
{
    
    public class Pelicula
    {
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("episode_id")]
        public int episode_id { get; set; }
        [JsonProperty("opening_crawl")]
        public string opening_crawl { get; set; }
        [JsonProperty("director")]
        public string director { get; set; }
        [JsonProperty("producer")]
        public string producer { get; set; }
        [JsonProperty("release_date")]
        public string release_date { get; set; }
        [JsonProperty("characters")]
        public List<string> characters { get; set; }
        [JsonProperty("planets")]
        public List<string> planets { get; set; }
        [JsonProperty("starships")]
        public List<string> starships { get; set; }
        [JsonProperty("vehicles")]
        public List<string> vehicles { get; set; }
        [JsonProperty("species")]
        public List<string> species { get; set; }
        [JsonProperty("created")]
        public DateTime created { get; set; }
        [JsonProperty("edited")]
        public DateTime edited { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }

        public Pelicula(int episode_id)
        {
            this.episode_id = episode_id;
        }
    }
}
