using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestMee
{
    public class BaseThread : BaseEntity
    {
        public int UserStatusId { get; set; }
        public int ContentStatusId { get; set; }


        public string Subject { get; set; }
        public string CreatedTime { get; set; }
    }
}