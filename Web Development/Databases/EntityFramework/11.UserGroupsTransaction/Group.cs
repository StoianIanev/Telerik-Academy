namespace _11.UserGroupsTransaction
{
    using System;
    using System.Collections.Generic;

    public class Group
    {
        private ICollection<User> users;
        public Group()
        {
            this.users = new HashSet<User>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        
        public virtual ICollection<User> Users 
        { 
            get
            {
                return this.users;
            }
            
            set
            {
                this.users = value;
            }
        }
    }
}
