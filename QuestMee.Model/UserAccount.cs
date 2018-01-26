using System.Collections.Generic;

namespace QuestMee.Model
{
    public class UserAccount : BaseUserAccount
    {
        public UserStatus UserStatus { get; set; }


        public List<Thread> Threads { get; set; }
        public List<Post> Posts { get; set; }
        public virtual List<UserGroup> UserGroups { get; set; }
        public List<Category> Categories { get; set; }
    }
}