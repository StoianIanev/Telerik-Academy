using LibrarySystem.Data.Migrations;
using LibrarySystem.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data
{
    //class BooksDbContext
    //{
    //}
    public class BooksDbContext : IdentityDbContext<ApplicationUser>
    {
        public BooksDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(
               new MigrateDatabaseToLatestVersion<BooksDbContext, Configuration>());
        }

        public static BooksDbContext Create()
        {
            return new BooksDbContext();
        }

        public IDbSet<Book> Books { get; set; }

        public IDbSet<Category> Categories { get; set; }
    }
}
