using System.Diagnostics;

using Newtonsoft.Json;

namespace ASoft.BattleNet.Starcraft2.Models
{
    [DebuggerDisplay("SeasonId: {SeasonId} Number: {Number} Year: {Year} StartDate: {StartDate} EndDate: {EndDate}")]
    public class Season
    {
        public Season(long seasonId, int number, int year, string startDate, string endDate)
        {
            SeasonId = seasonId;
            Number = number;
            Year = year;
            StartDate = startDate;
            EndDate = endDate;
        }

        [JsonProperty("seasonId")]
        public long SeasonId { get; }

        [JsonProperty("number")]
        public int Number { get; }

        [JsonProperty("year")]
        public int Year { get; }

        [JsonProperty("startDate")]
        public string StartDate { get; }

        [JsonProperty("endDate")]
        public string EndDate { get; }
    }

}
