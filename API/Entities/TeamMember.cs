namespace API.Entities
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public int TeamId { get; set; }
        public Team? Team { get; set; }
    }
}
