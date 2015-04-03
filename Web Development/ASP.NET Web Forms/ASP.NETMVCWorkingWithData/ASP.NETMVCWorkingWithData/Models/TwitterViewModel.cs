using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twitter.Model;

namespace ASP.NETMVCWorkingWithData.Models
{
    public class TwitterViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public virtual ApplicationUser Onwer { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }
    }
}