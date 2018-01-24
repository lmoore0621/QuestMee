using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BaseThread : BaseEntity
    {
        public string Subject { get; set; }
        public string CreatedTime { get; set; }
    }
}