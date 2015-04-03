using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Movies.Data;

namespace MoviesApp.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            this.DbContext = new MoviesDbContext();
        }

        public MoviesDbContext DbContext { get; set; }
    }
}