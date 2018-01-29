using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BaseVotes : BaseEntity
    {
        public int ThreadId { get; set; }
        public int PostId { get; set; }


        public int UpVote { get; set; }
        public int DownVote { get; set; }
    }
}