namespace API.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int NumPlayers { get; set; }

        public ICollection<Series>? SeriesAsTeamOne { get; set; }
        public ICollection<Series>? SeriesAsTeamTwo { get; set; }

        public ICollection<TeamMember> Members { get; set; } = new List<TeamMember>();
    }
}
