﻿namespace EntityFramework.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string DisplayedName { get; set; }
        public List<Post> Posts { get; set; } = null!; // Navigation Property
    }
}
