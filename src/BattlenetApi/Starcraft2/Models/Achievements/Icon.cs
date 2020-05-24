using System;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Achievements
{
    [DebuggerDisplay("Url: {Url}")]
    public sealed class Icon
    {
        [JsonConstructor]
        public Icon(int x, int y, int width, int height, int offset, Uri url)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Offset = offset;
            Url = url;
        }

        public int X { get; }
        public int Y { get; }
        [JsonProperty("w")]
        public int Width { get; }
        [JsonProperty("h")]
        public int Height { get; }
        public int Offset { get; }
        public Uri Url { get; }
    }
}
