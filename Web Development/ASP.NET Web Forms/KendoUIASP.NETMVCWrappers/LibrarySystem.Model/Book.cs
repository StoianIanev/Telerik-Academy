using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Model
{
    public class Book
    {
        public virtual int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public virtual string Author { get; set; }
        public virtual string ISBN { get; set; }
        public virtual string Website { get; set; }
        public virtual string Description { get; set; }

        public virtual Category Category { get; set; }
    }
}
