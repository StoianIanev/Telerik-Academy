using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesApp.Models
{
    public class ActorViewModel
    {
        public virtual int Id {get; set;}

        [Required]
        public virtual string Name { get; set; }

        [Required]
        [Range(15, 60)]
        public virtual int Age { get; set; }
    }
}