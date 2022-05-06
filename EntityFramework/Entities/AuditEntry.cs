﻿namespace EntityFramework.Entities
{
    public class AuditEntry
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Action { get; set; } = null!;
    }
}
