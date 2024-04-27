using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Round
    {
        public int Id { get; set; }
        public int RoundNumber { get; set; }
        [DisplayFormat(NullDisplayText = "Round in progress")]
        public Team? RoundWinner { get; set; }

        public int MatchId { get; set; }
        public Match Match { get; set; }
    }
}
