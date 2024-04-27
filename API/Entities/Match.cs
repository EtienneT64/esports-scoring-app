using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public int MatchNumber { get; set; }
        public int NumberOfRounds { get; set; }
        public int FirstToWins { get; set; }
        public int TeamOneScore { get; set; }
        public int TeamTwoScore { get; set; }

        public int VictorId { get; set; }
        [DisplayFormat(NullDisplayText = "Match in progress")]
        public Team? Victor { get; set; }

        public int SeriesId { get; set; }
        public Series Series { get; set; }

        public ICollection<Round> Rounds { get; set; } = new List<Round>();
    }
}
