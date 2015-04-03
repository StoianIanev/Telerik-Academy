using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twitter.Data;

namespace ASP.NETMVCWorkingWithData.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public BaseController()
        {
            this.DbContext = new TwitterDbContext();
        }

        public TwitterDbContext DbContext { get; set; }
    }
}