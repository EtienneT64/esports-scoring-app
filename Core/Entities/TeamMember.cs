namespace Core.Entities
{
    public class TeamMember : BaseEntity
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }

        public Team Team { get; set; }
    }
}
