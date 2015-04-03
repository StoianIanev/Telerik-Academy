using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Model
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public virtual ApplicationUser Onwer { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }

        public Tweet()
        {
            this.Tag = new HashSet<Tag>();
        }

    }
}
