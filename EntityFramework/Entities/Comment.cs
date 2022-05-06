using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Descrption { get; set; } = null!;
        public Post Post { get; set; } = null!;
        public User user{ get; set; } = null!;
    }
}
