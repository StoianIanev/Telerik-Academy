using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Model
{
    public class Category
    {
        public virtual int Id { get; set; }
        [Required]
        public virtual string Name { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
