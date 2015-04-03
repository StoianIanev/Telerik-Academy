
// Task 11- Create a database holding users and groups.
//          Create a transactional EF based method that creates an user and puts it in a group "Admins". 
//          In case the group "Admins" do not exist, create the group in the same transaction. 
//          If some of the operations fail (e.g. the username already exist), cancel the entire transaction.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Transactions;

namespace _11.UserGroupsTransaction
{
    public class UserGroupsTransaction
    {
        static void Main()
        {
            try
            {
                UsersGroupsDbContext userContext = new UsersGroupsDbContext();

                using (userContext)
                {
                    using (var dbContextTransaction = userContext.Database.BeginTransaction())
                    {
                         Group adminGroup = new Group { GroupId = 2, GroupName = "Admins" };

                        if (userContext.Groups.Where(g => g.GroupName == "Admins").ToList().Count == 0)
                        {
                            userContext.Groups.Add(adminGroup);
                            userContext.SaveChanges();
                        }

                        User user = new User { UserId = 1, Name = "Pesho", Password = "1234", GroupId = 2 };

                        userContext.Users.Add(user);
                        userContext.SaveChanges();
                        dbContextTransaction.Commit();
                    } 
                    
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
