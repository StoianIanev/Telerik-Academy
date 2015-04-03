using Movies.Data;
using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MoviesApp.Controllers
{
    public class MovieController : BaseController
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View(DbContext.Movie.ToList());
        }
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveData(Movie movie)
        {
            if (ModelState.IsValid)
            {
                this.DbContext.Movie.Add(movie);
                this.DbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("_Create", movie);
        }
        private IEnumerable<SelectListItem> GetMovieList()
        {
            var movieList = this.DbContext.Movie.Select(x => new SelectListItem
            {
                Text = x.Title,
                Value = x.Id.ToString()
            }).ToList();

            return movieList;
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = this.DbContext.Movie.Find(id);
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
            Movie tweet = DbContext.Movie.Find(id);
            if (tweet == null)
            {
                return HttpNotFound();
            }
            return View(tweet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie mov)
        {
            if (ModelState.IsValid)
            {
                DbContext.Entry(mov).State = EntityState.Modified;
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mov);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = DbContext.Movie.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return PartialView("_Delete", movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = DbContext.Movie.Find(id);
            DbContext.Movie.Remove(movie);
            DbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}