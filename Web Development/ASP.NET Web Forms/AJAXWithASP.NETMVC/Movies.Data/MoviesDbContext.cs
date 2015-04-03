using Microsoft.AspNet.Identity.EntityFramework;
using Movies.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Data.Migrations;
using MoviesApp.Models;

namespace Movies.Data
{
    public class MoviesDbContext : IdentityDbContext<ApplicationUser>
    {
        public MoviesDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<MoviesDbContext, Configuration>());
        }

        public static MoviesDbContext Create()
        {
            return new MoviesDbContext();
        }
        public IDbSet<Movie> Movie { get; set; }

        public IDbSet<Actor> Actor { get; set; }
    }
}
