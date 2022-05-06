namespace EntityFramework.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Post> Posts { get; set; } = null!; // Navigation Property
    }
}
