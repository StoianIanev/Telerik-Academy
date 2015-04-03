using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MoviesApp.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Director { get; set; }

        public string Studio { get; set; }

        public string StudioAddress { get; set; }

        [Required]
        public int Year { get; set; }

        public ActorViewModel LeadingMaleRole { get; set; }

        public ActorViewModel LeadingFemaleRole { get; set; }


        public ActorViewModel Actor { get; set; }


    }
}