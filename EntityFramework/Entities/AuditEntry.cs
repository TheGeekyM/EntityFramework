using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Entities
{
    public class AuditEntry
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Action { get; set; } = null!;
        
        [NotMapped]
        public DateTime CreatedDate { get; set; } // will be not reflectd in our table in dv

        [Column("updated_at")]
        public DateTime UpdatedDate { get; set; } // will be named updated_at in our table in db
    }
}
