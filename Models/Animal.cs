using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace AnimalSource.Models
{
    public class Animal
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("type")]
        public string Type  { get; set; }
        
        [JsonPropertyName("species")]
        public string Species { get; set; }
        
        [JsonPropertyName("size")]
        public string Size { get; set; }
        
        [JsonPropertyName("age")]
        public int Age { get; set; }
        
        [JsonPropertyName("endangered")]
        public bool Endangered { get; set; }
        
        [JsonPropertyName("dangerLevels")]
        public int[] DangerLevels { get; set; }
        
        [JsonPropertyName("url")]
        public string Url { get; set; }
        
        [JsonPropertyName("img")]
        public string Image { get; set; }
        
        
        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
    
}