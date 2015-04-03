using Kendo.Mvc.UI;
using LibrarySystem.Model;
using LibrarySystem.Models;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrarySystem.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var result = DbContext.Categories.ToList().Select(x => new TreeViewItemModel
            {
                Text = x.Name,
                Items = DbContext.Books.Where(b => b.Category.Name == x.Name)
                .Select(y => new TreeViewItemModel
                {
                    Text = y.Title
                })
                    .ToList()
            });

            var books = DbContext.Books;

            TreeViewBookCommonViewModel model = new TreeViewBookCommonViewModel();
            model.TreeViewItems = result;
            model.Books = books;
            
            return View(model);
        }
        public ActionResult BookDetails(int? id)
        {
            if (id != null)
            {
                var found = DbContext.Books.Single(x => x.Id == id);
                return View("BookDetails", found);
            }
            return View("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}