using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models.Static
{
    [DebuggerDisplay("AchievementId: {AchievementId} Id: {Id}")]
    public sealed class StaticCriterion
    {
        [JsonConstructor]
        public StaticCriterion(long achievementId, string description, string evaluationClass, int flags, long id, int necessaryQuantity, int uiOrderHint)
        {
            AchievementId = achievementId;
            Description = description;
            EvaluationClass = evaluationClass;
            Flags = flags;
            Id = id;
            NecessaryQuantity = necessaryQuantity;
            UiOrderHint = uiOrderHint;
        }

        public long AchievementId { get; }
        public string Description { get; }
        public string EvaluationClass { get; }
        public int Flags { get; }
        public long Id { get; }
        public int NecessaryQuantity { get; }
        public int UiOrderHint { get; }
    }

}
