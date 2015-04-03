using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApp.Models
{
    public class Actor
    {
        public Actor()
        {
            this.Movie = new HashSet<Movie>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public ICollection<Movie> Movie { get; set; }
    }
}