using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BaseVotes : BaseEntity
    {
        public int UpVote { get; set; }
        public int DownVote { get; set; }
    }
}