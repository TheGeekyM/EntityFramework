﻿namespace EntityFramework.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string DisplayedName { get; set; } = null!;
        public List<Post> Posts { get; set; } = null!; // Navigation Property
    }
}
