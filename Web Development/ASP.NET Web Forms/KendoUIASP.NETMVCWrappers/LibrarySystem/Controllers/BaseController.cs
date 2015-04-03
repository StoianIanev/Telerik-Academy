using LibrarySystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrarySystem.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public BaseController()
        {
            this.DbContext = new BooksDbContext();
        }

        public BooksDbContext DbContext { get; set; }
    }
}