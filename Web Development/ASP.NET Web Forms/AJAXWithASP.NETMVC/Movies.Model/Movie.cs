using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public string Studio { get; set; }

        public string StudioAddress { get; set; }

        public int Year { get; set; }

        public Actor LeadingMaleRole { get; set; }

        public Actor LeadingFemaleRole { get; set; }

        public virtual Actor Actor { get; set; }
    }
}