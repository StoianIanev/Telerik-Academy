using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Tweet> Tweet { get; set; }

        public Tag()
        {
            this.Tweet = new HashSet<Tweet>();
        }
    }
}
