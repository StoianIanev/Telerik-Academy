using LibrarySystem.Controllers;
using LibrarySystem.Data;
using LibrarySystem.Model;
using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LibrarySystem.Areas.Admin.Controllers
{
    public class CategoriesController : BaseController
    {
        // GET: Admin/Categories
        public ActionResult Index(int? id)
        {
            BooksDbContext db = new BooksDbContext();
            var found = db.Categories;
            return View(found);
        }
        public ActionResult Create()
        {
            return PartialView("_Create");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SaveData(Category category)
        {
            if (ModelState.IsValid)
            {
                this.DbContext.Categories.Add(category);
                this.DbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return PartialView("_Create", category);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category tweet = DbContext.Categories.Find(id);
            if (tweet == null)
            {
                return HttpNotFound();
            }
            return View(tweet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                DbContext.Entry(category).State = EntityState.Modified;
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public JsonResult GetAllCategories()
        {
            BooksDbContext db = new BooksDbContext();
            var categories = db.Categories.ToList();

            return Json(categories, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Delete(int? id)
        {
            Category category = DbContext.Categories.Find(id);
            return PartialView("_Delete", category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category cate = DbContext.Categories.Find(id);
            DbContext.Categories.Remove(cate);
            DbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}