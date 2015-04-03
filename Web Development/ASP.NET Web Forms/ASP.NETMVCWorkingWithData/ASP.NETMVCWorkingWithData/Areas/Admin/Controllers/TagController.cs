using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twitter.Data;

namespace ASP.NETMVCWorkingWithData.Areas.Admin.Controllers
{
    public class TagController : Controller
    {
        private TwitterDbContext db = new TwitterDbContext();

        // GET: Admin/Tag
        public ActionResult Index(string tag)
        {
            var model = db.Tag.Where(t => t.Title == tag).ToList();
            return View(model);
        }
    }
}