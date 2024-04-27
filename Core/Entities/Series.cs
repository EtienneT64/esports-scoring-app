using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Series : BaseEntity
    {
        public string Title { get; set; } = "";
        public DateTime Date { get; set; }
        public int FirstToWins { get; set; }
        public int TeamOneScore { get; set; }
        public int TeamTwoScore { get; set; }

        [DisplayFormat(NullDisplayText = "Series in progress")]
        public Team Victor { get; set; }
        public ICollection<Team> Teams { get; set; } = new List<Team>();
        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}
