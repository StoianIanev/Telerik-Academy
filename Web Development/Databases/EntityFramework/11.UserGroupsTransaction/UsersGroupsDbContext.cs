namespace _11.UserGroupsTransaction
{
    using System;
    using System.Data.Entity;

    class UsersGroupsDbContext : DbContext
    {
        public IDbSet<Group> Groups {get; set;}
        public IDbSet<User> Users { get; set; }
    }
}
