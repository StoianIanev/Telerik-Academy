namespace _11.UserGroupsTransaction
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        private ICollection<Group> group;

        public User()
        {
            this.group = new HashSet<Group>(); 
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int GroupId { get; set; }

        public virtual ICollection<Group> Group
        {
            get
            {
                return this.group;
            }

            set
            {
                this.group = value;
            }
        }
    }
}
