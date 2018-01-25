using QuestMee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee.Model
{
    public class Thread : BaseThread
    {
        public UserAccount UserAccount { get; set; }
        public Status Status { get; set; }


        public List<Post> Posts { get; set; }
        public List<Votes> Votes { get; set; }
    }
}