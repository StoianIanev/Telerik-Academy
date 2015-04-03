using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twitter.Model;

namespace ASP.NETMVCWorkingWithData.Models
{
    public class TagViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Tweet> Tweet { get; set; }
    }
}