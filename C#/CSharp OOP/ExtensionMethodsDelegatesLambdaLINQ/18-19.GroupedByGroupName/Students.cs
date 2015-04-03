namespace _18_19.GroupedByGroupName
{
    public class Students
    {
        public string FullName {get; set;}
        public string GroupName { get; set; }


        public Students(string FullName, string GroupName)
        {
            this.FullName = FullName;
            this.GroupName = GroupName;
        }
    }
}
