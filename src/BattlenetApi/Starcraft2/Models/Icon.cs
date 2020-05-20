using System;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    [DebuggerDisplay("Url: {Url}")]
    public class Icon
    {
        public Icon(int x, int y, int width, int height, int offset, Uri url)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Offset = offset;
            Url = url;
        }

        [JsonProperty("x")]
        public int X { get; }
        [JsonProperty("y")]
        public int Y { get; }
        [JsonProperty("w")]
        public int Width { get; }
        [JsonProperty("h")]
        public int Height { get; }
        [JsonProperty("offset")]
        public int Offset { get; }
        [JsonProperty("url")]
        public Uri Url { get; }
    }
}
