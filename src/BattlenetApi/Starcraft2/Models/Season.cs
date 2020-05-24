using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    [DebuggerDisplay("SeasonId: {SeasonId} Number: {Number} Year: {Year} StartDate: {StartDate} EndDate: {EndDate}")]
    public sealed class Season
    {
        [JsonConstructor]
        public Season(long seasonId, int number, int year, string startDate, string endDate)
        {
            SeasonId = seasonId;
            Number = number;
            Year = year;
            StartDate = startDate;
            EndDate = endDate;
        }

        public long SeasonId { get; }
        public int Number { get; }
        public int Year { get; }
        public string StartDate { get; }
        public string EndDate { get; }
    }

}
