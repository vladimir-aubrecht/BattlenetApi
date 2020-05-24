using System;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Static
{
    [DebuggerDisplay("Id: {Id} Name: {Name}")]
    public sealed class StaticReward
    {
        [JsonConstructor]
        public StaticReward(int flags, long id, long achievementId, string name, Uri imageUrl, string unlockableType, bool isSkin, int uiOrderHint, string command)
        {
            Flags = flags;
            Id = id;
            AchievementId = achievementId;
            Name = name;
            ImageUrl = imageUrl;
            UnlockableType = unlockableType;
            IsSkin = isSkin;
            UiOrderHint = uiOrderHint;
            Command = command;
        }

        public int Flags { get; }
        public long Id { get; }
        public long AchievementId { get; }
        public string Name { get; }
        public Uri ImageUrl { get; }
        public string UnlockableType { get; }
        public bool IsSkin { get; }
        public int UiOrderHint { get; }
        public string Command { get; }
    }

}
