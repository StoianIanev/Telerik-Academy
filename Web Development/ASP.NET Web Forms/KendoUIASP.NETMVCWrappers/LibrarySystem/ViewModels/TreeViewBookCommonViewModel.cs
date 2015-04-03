using LibrarySystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrarySystem.Models
{
    public class TreeViewBookCommonViewModel
    {
        public IEnumerable<Kendo.Mvc.UI.TreeViewItemModel> TreeViewItems { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}