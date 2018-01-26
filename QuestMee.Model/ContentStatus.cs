using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee.Model
{
    public class ContentStatus : BaseContentStatus
    {
        public List<Category> Categories { get; set; }
        public List<Thread> Threads { get; set; }
        public List<Post> Posts { get; set; }
    }
}