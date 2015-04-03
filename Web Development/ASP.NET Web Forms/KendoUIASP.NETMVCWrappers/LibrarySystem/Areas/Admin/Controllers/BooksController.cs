using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibrarySystem.Data;
using LibrarySystem.Model;
using LibrarySystem.Models;
using System.Net;
using LibrarySystem.Controllers;
using System.Data.Entity;

namespace LibrarySystem.Areas.Admin.Controllers
{
    public class BooksController : BaseController
    {
        // GET: Admin/Books
        public ActionResult Index()
        {
            BooksDbContext db = new BooksDbContext();
            var found = db.Books;
            return View(found);
        }
        public ActionResult Create()
        {
            return PartialView("_Create");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book tweet = DbContext.Books.Find(id);
            if (tweet == null)
            {
                return HttpNotFound();
            }
            return View(tweet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                DbContext.Entry(book).State = EntityState.Modified;
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveData(Book book)
        {
            if (ModelState.IsValid)
            {
                this.DbContext.Books.Add(book);
                this.DbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return PartialView("_Create", book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveEdit(BookViewModel model)
        {
            BooksDbContext db = new BooksDbContext();
            var cat = db.Categories.FirstOrDefault(c => c.Id == model.Category);

            var book = db.Books.FirstOrDefault(b => b.Id == model.Id);
            book.Title = model.Title;
            book.Author = model.Author;
            book.Description = model.Description;
            book.ISBN = model.ISBN;
            book.Website = model.Website;
            book.Category = cat;
            db.SaveChanges();
            return View();
        }
        public ActionResult Delete(int? id)
        {
            Book book = DbContext.Books.Find(id);
            return PartialView("_Delete", book);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book b = DbContext.Books.Find(id);
            DbContext.Books.Remove(b);
            DbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = this.DbContext.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return PartialView("_Details", book);
        }
    }
}