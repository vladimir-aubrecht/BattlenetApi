using System;
using System.Text.Json.Serialization;

namespace ASoft.BattleNet.Starcraft2.Models
{
    public class Icon
    {
        [JsonPropertyName("x")]
        public int X { get; set; }
        [JsonPropertyName("y")]
        public int Y { get; set; }
        [JsonPropertyName("w")]
        public int Width { get; set; }
        [JsonPropertyName("h")]
        public int Height { get; set; }
        [JsonPropertyName("offset")]
        public int Offset { get; set; }
        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
