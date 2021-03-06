﻿using System.Collections.Generic;

namespace QuestMee.Model
{
    public class UserAccount : BaseUserAccount
    {
        public UserStatus UserStatus { get; set; }


        public List<Thread> Threads { get; set; }
        public List<Post> Posts { get; set; }
        public List<Category> Categories { get; set; }


        public virtual ICollection<UserGroup> UserGroups { get; set; }
    }
}