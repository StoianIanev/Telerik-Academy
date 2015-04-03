using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Twitter.Data;
using Twitter.Model;

namespace ASP.NETMVCWorkingWithData.Areas.Admin.Controllers
{
    public class TwitterController : Controller
    {
        private TwitterDbContext db = new TwitterDbContext();

        // GET: Admin/Home

        //[OutputCache(Duration = 15 * 60)]
        public ActionResult Index()
        {
            return View(db.Tweet.ToList());
        }
        public ActionResult MyTweets()
        {
            var currentUser = User.Identity.Name;
            var model = db.Tweet.Where(t => t.Onwer.UserName == currentUser).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return PartialView("_Create");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveData(Tweet tweet)
        {
            if (ModelState.IsValid)
            {
                this.db.Tweet.Add(tweet);
                this.db.SaveChanges();
                return RedirectToAction("Index");
            }

            return PartialView("_Create", tweet);
        }
        public ActionResult Delete(int? id)
        {
            Tweet book = db.Tweet.Find(id);
            return PartialView("_Delete", book);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tweet b = db.Tweet.Find(id);
            db.Tweet.Remove(b);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tweet movie = this.db.Tweet.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return PartialView("_Details", movie);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tweet tweet = db.Tweet.Find(id);
            if (tweet == null)
            {
                return HttpNotFound();
            }
            return View(tweet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tweet tweet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tweet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tweet);
        }
    }
}