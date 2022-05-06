using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Descrption { get; set; } = null!;
        public User User { get; set; } = null!;
        public List<Comment> Comments { get; set; } = null!;
    }
}
