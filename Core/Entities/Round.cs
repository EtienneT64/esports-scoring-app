using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Round : BaseEntity
    {
        public int RoundNumber { get; set; }

        [DisplayFormat(NullDisplayText = "Round in progress")]
        public Team RoundWinner { get; set; }
        public Match Match { get; set; }
    }
}
