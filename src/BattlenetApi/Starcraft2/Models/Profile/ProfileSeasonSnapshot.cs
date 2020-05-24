
using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Profile
{
    public sealed class ProfileSeasonSnapshot
    {
        [JsonConstructor]
        public ProfileSeasonSnapshot(ProfileLadderSnapshot oneVsOne, ProfileLadderSnapshot twoVsTwo, ProfileLadderSnapshot threeVsThree, ProfileLadderSnapshot fourVsFour, ProfileLadderSnapshot archon)
        {
            OneVsOne = oneVsOne;
            TwoVsTwo = twoVsTwo;
            ThreeVsThree = threeVsThree;
            FourVsFour = fourVsFour;
            Archon = archon;
        }

        public ProfileLadderSnapshot OneVsOne { get; }
        public ProfileLadderSnapshot TwoVsTwo { get; }
        public ProfileLadderSnapshot ThreeVsThree { get; }
        public ProfileLadderSnapshot FourVsFour { get; }
        public ProfileLadderSnapshot Archon { get; }
    }

}
