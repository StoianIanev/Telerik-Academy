using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InformationalAspPage.Models;

namespace InformationalAspPage.Controllers
{
    public class BooksController : Controller
    {
        private List<Books> books = new List<Books>{
            new Books{ Id=1, Title = "The Hobbit",  Author="J. R. R. Tolkien", DescriptionAboutAuthor = "John Ronald Reuel Tolkien, (3 January 1892 – 2 September 1973) was an English writer, poet, philologist, and university professor who is best known as the author of the classic high-fantasy works The Hobbit, The Lord of the Rings, and The Silmarillion."},
            new Books{ Id=2, Title = "The Lord of the Rings",  Author="J. R. R. Tolkien",  DescriptionAboutAuthor = "John Ronald Reuel Tolkien, (3 January 1892 – 2 September 1973) was an English writer, poet, philologist, and university professor who is best known as the author of the classic high-fantasy works The Hobbit, The Lord of the Rings, and The Silmarillion."},
            new Books{ Id=3, Title = "Fundamentals of Computer Programming with C#",  Author="Svetlin Nakov",  DescriptionAboutAuthor = "Svetlin Nakov has 20+ years of technical background as software engineer, project manager, consultant and trainer"},
            new Books{ Id=4, Title = "Introduction to Programming with Java",  Author="Svetlin Nakov",  DescriptionAboutAuthor = "Svetlin Nakov has 20+ years of technical background as software engineer, project manager, consultant and trainer"}
        };
        public List<Books> Books
        {
            get
            {
                return this.books;
            }
        }

        // GET: Books
        public ActionResult Index()
        {
            var books = this.Books;
            return View(books);

        }
        public ActionResult BookAuthor(int id)
        {
            var book = this.Books[id];
            return View(book);

        }
        public ActionResult AboutAuthor(int id)
        {
            var b = this.Books[id];
            return View(b);
        }
    }
}