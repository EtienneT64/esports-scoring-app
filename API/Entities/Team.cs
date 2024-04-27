namespace API.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int NumPlayers { get; set; }

        public ICollection<TeamMember> Members { get; set; } = new List<TeamMember>();
    }
}
