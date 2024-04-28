using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace API.Dtos
{
    public class SeriesToReturnDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public DateTime Date { get; set; }
        public int FirstToWins { get; set; }
        public int TeamOneScore { get; set; }
        public int TeamTwoScore { get; set; }

        [DisplayFormat(NullDisplayText = "Series in progress")]
        public string Victor { get; set; }
        public string TeamOne { get; set; }
        public string TeamTwo { get; set; }
        public List<int> Matches { get; set; }
    }
}
