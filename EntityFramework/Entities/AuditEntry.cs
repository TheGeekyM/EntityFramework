using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Entities
{
    public class AuditEntry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Action { get; set; } = null!;
        
        [NotMapped]
        public DateTime CreatedDate { get; set; } // will be not reflectd in our table in dv

        [Column("updated_at")]
        public DateTime UpdatedDate { get; set; } // will be named updated_at in our table in db

        [Column(TypeName = "varchar(200)")]
        public string Description { get; set; }
        
        [Column(TypeName = "decimal(5,2)")]
        public decimal Rating { get; set; }

        [MaxLength(200), Comment("Add this comment to this column")]
        public string Comment { get; set; }
    }
}
