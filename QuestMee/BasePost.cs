using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BasePost : BaseEntity
    {
        public int ThreadId { get; set; }
        public int UserAccountId { get; set; }
        public int ContentStatusId { get; set; }


        public string Subject { get; set; }
        public string Content { get; set; }
        public string CreatedTime { get; set; }
    }
}