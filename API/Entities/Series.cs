using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public enum MatchType {
        Bo1 = 1,
        Bo3= 2,
        Bo5 = 3
    }
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public DateTime Date { get; set; }
        public MatchType MatchType { get; set; }
        public int TeamOneScore { get; set; }
        public int TeamTwoScore { get; set; }

        [DisplayFormat(NullDisplayText = "Series in progress")]
        public Team? Victor { get; set; }
        public int VictorId { get; set; }

        public int TeamOneId { get; set; }
        public Team TeamOne { get; set; }

        public int TeamTwoId { get; set; }
        public Team TeamTwo { get; set; }

        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}
