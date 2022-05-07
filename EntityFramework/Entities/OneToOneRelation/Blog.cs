using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities.OneToOneRelation
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public BlogImage BlogImage { get; set; }
    }
}
