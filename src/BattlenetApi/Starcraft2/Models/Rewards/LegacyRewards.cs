using System.Collections.Generic;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Rewards
{

    public sealed class LegacyRewardsRoot
    {
        [JsonConstructor]
        public LegacyRewardsRoot(IList<LegacyRewardsPortrait> portraits, IList<LegacyRewardsPortrait> terranDecals, IList<LegacyRewardsPortrait> zergDecals, IList<LegacyRewardsPortrait> protossDecals, IList<LegacyRewardsSkin> skins, IList<LegacyRewardsAnimation> animations)
        {
            Portraits = portraits;
            TerranDecals = terranDecals;
            ZergDecals = zergDecals;
            ProtossDecals = protossDecals;
            Skins = skins;
            Animations = animations;
        }

        public IList<LegacyRewardsPortrait> Portraits { get; }
        public IList<LegacyRewardsPortrait> TerranDecals { get; }
        public IList<LegacyRewardsPortrait> ZergDecals { get; }
        public IList<LegacyRewardsPortrait> ProtossDecals { get; }
        public IList<LegacyRewardsSkin> Skins { get; }
        public IList<LegacyRewardsAnimation> Animations { get; }
    }
}
