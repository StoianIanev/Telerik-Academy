using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Data.Migrations;
using Twitter.Model;

namespace Twitter.Data
{
    public class TwitterDbContext : IdentityDbContext<ApplicationUser>
    {
        public TwitterDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<TwitterDbContext, Configuration>());
        }

        public static TwitterDbContext Create()
        {
            return new TwitterDbContext();
        }

        public IDbSet<Tweet> Tweet { get; set; }

        public IDbSet<Tag> Tag { get; set; }
    }
}
