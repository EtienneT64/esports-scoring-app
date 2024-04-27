namespace Core.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; } = "";
        public int NumPlayers { get; set; }

        public ICollection<TeamMember> Members { get; set; } = new List<TeamMember>();
    }
}
