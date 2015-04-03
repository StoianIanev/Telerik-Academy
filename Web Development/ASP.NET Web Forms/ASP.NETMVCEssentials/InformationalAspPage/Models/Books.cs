using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationalAspPage.Models
{
    public class Books
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string DescriptionAboutAuthor { get; set; }
    }
}