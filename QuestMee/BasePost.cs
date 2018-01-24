using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BasePost : BaseEntity
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public string CreatedTime { get; set; }
    }
}